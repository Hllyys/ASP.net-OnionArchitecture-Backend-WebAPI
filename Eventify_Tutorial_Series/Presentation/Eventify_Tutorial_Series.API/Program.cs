using Eventify_Tutorial_Series.Applicaiton;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services;
using Eventify_Tutorial_Series.Applicaiton.Abstractions.Services.Concreate;
using Eventify_Tutorial_Series.Infrastructure;
using Eventify_Tutorial_Series.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//AddScoped ile kaydedilen nesneler,s
//her HTTP isteði için bir kez oluþturulur ve tüm istek boyunca ayný nesne kullanýlýr.


builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddSwaggerDocument();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
