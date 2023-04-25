using Serilog;

var builder = WebApplication.CreateBuilder(args);


IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddUserSecrets<Program>(optional: true)
    .AddEnvironmentVariables()
    .Build();

//Ab hier überschreibt Serilor den Default-Logger von .NET Core 
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

builder.Host.UseSerilog();


// Add services to the container.
builder.Services.AddRazorPages();

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

try
{
    app.Run();
}
catch (Exception ex)
{
    Log.Error(ex.ToString());
}
finally
{
    Log.CloseAndFlush();
}



// < .NET Framework 4.8 (NLog, Log4Net)
// ab .NET Core > Serilog 


