WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


#region Abwärtskombatibel


//IHost -> .NET 3.1/5
//builder.Host

//builder.WebHost //IWebHostBuilder -> .Net 2.x
#endregion

#region IOC Container kann befüllt werden
// Add services to the container.
builder.Services.AddRazorPages();
#endregion

WebApplication app = builder.Build();


#region Configuration Part
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
#endregion


//App.Run 
app.Run();

//Programm.cs ab .NET 6 Vorteile gegenüber .NET 5 Programm.cs/Startup.cs

// - Weniger Codzeilen
// - Prozeduale Aufrufe -> Lamba->Expression werden nicht verwendet




