using SwaggerHierarchySupport;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.AddHierarchySupport();
});

app.MapControllers();

app.Run();
