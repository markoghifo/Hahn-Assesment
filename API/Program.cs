using Business.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddDatabaseService(configuration);
builder.Services.AddServices(configuration);
builder.Services.AddDataAccessServices();

builder.Services.AddSingleton<IServiceProvider, ServiceProvider>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
	app.AddSwagger();
}

app.UseAuthorization();

app.MapControllers();

IServiceProvider serviceProvider = app.Services.GetService<IServiceProvider>();
app.SetupMigrations(serviceProvider);
app.Run();
