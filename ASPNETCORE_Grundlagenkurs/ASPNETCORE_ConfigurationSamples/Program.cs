using ASPNETCORE_ConfigurationSamples.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


//Wir fügen eine weitere Konfigurationsdatei hinzu -> Im Hintergrund wird IConfiguration auch erweitert 
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("GameSettings.json", true, true);

});


builder.Services.Configure<GameSettings>(builder.Configuration.GetSection("GameSettings"));



var app = builder.Build();

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
