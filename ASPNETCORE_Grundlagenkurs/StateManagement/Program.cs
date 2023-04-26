var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();

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

app.UseSession();

app.MapRazorPages();

app.Run();

Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "hallihallo");
//dict.Add(new KeyValuePair<int, string>(3, "Hallooooo")); -> nicht callbar ist private 

IDictionary<int, string> dict2 = new Dictionary<int, string>();
dict2.Add(2, "test");
dict2.Add(new KeyValuePair<int, string>(3, "Hallooooo"));
