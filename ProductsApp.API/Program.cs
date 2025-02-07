using ProductsApp.API.Extensions;
using ProductsApp.Infra.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(config => config.LowercaseUrls = true);
builder.Services.AddSwaggerConfig(); //metodo de extensao
builder.Services.AddEntityFramework(builder.Configuration); //metodo de extensao

var app = builder.Build();

app.UseSwaggerConfig(); //metodo de extensao
app.UseAuthorization();
app.MapControllers();

app.Run();
