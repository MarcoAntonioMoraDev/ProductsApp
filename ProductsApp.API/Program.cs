using ProductsApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRouting(config => config.LowercaseUrls = true);
builder.Services.AddSwaggerConfig(); //metodo de extensao

var app = builder.Build();

app.UseSwaggerConfig(); //metodo de extensao
app.UseAuthorization();
app.MapControllers();

app.Run();
