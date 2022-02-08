using Business.Extensions;

var builder = WebApplication.CreateBuilder(args);

var myAllowSpecificOrigin = "_myAllowSpecificOrigin";

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDatabaseService(configuration);
builder.Services.AddServices(configuration);
builder.Services.AddDataAccessServices();

builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IServiceProvider, ServiceProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseCors(myAllowSpecificOrigin);
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); 

IServiceProvider serviceProvider = app.Services.GetService<IServiceProvider>();
app.SetupMigrations(serviceProvider);
app.Run();
