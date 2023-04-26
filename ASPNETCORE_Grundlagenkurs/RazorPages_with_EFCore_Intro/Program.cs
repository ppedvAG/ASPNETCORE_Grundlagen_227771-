using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPages_with_EFCore_Intro.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    
});
builder.Services.AddDbContext<MovieDbContext>(options =>
{
    //Provider werden hier festgelegt
    //Relationale Strategien werden festgelegt (Lazy Loading, Eager Loading, Impliziet Loading) 

    //In Memory Provider
    //options.UseInMemoryDatabase("MovieDb");

    //bevor wird UseSQLServer starten, müssen wir sicher sein, dass Add-Migration und Update-Database ausgeführt wird 
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPages_with_EFCore_IntroContext") ?? throw new InvalidOperationException("Connection string 'RazorPages_with_EFCore_IntroContext' not found."));

});
    
var app = builder.Build();

//Achtung!!! Wenn man einen Dienst als Scope-Lifetime ablegt, kann man diese in dier Programm.cs nicht direkt auslesen. Wir müssen ServiceProvider.CreateScope verwenden
//geht nicht -> MovieDbContext myDbContext = app.Services.GetService<MovieDbContext>();

//Ist vorgesehen, wenn man Objekte mit dem Lifecycle "Scope" auflösen möchte:
using (IServiceScope scope = app.Services.CreateScope())
{
    MovieDbContext ctx = scope.ServiceProvider.GetService<MovieDbContext>();
    DataSeeder.SeedMoviesInDb(ctx);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
