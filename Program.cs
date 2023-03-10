using BlazorApp.Data;
using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<PizzaService>();
// allows the app the access HTTP commands
// app uses an HttpClient to get the JSON for pizza specials
builder.Services.AddHttpClient();
// registers the new PizzaContext and provides the filename for the SqLite DB
builder.Services.AddSqlite<PizzaContext>("Data Source=pizza.db");
// adding a scoped service
// this allows us to access it anywhere in the app
// in order to use it in a file though, you must "inject the state"
// @inject PizzaSalesState <name used to reference state in file>
// then you can reference it using the name you gave it ^
builder.Services.AddScoped<PizzaSalesState>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
// sets up controllers (i added this)
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Initialize the database (i added this)
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PizzaContext>();
    if (db.Database.EnsureCreated())
    {
        SeedData.Initialize(db);
    }
}

app.Run();
