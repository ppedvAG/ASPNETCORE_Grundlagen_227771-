using ASPNETCORE_IOCSample.Services;

var builder = WebApplication.CreateBuilder(args);
//IOC Container Initialsiierungsphase -> builder.Service 
// Add services to the container.
builder.Services.AddRazorPages();


//Singleton, wird einmal instanziiert und existiert immer 
builder.Services.AddSingleton<ITimeService, TimeService>();
builder.Services.AddScoped<ITimeService, TimeService>();
builder.Services.AddTransient<ITimeService, TimeService>(); //Letzter Eintrag, überschreibt die anderen ITimeService, TimerService Zuordnungen

//Beispiel 2: 
builder.Services.AddTransient<ITimeService, TimeService>();
builder.Services.AddTransient<ITimeService, TimeService2>(); //Letzter Eintrag gewinnt. 


//Weitere Variantgen siehe (MultipleImp.md)
builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();


var app = builder.Build(); //IOC Container ist fertig initializiert





//Frühstmögliche Zugriff für Testdaten

//Variante 1
//ITimeService timeService1 = app.Services.GetService<ITimeService>();
//ITimeService timeService2 = app.Services.GetRequiredService<ITimeService>();



// ASPNET Core 2.x 
using (IServiceScope scope = app.Services.CreateScope())
{
    // 
    ITimeService timeService3  =scope.ServiceProvider.GetService<ITimeService>();   
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



