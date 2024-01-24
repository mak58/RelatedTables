using Carter;
using RelatedTables.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCarter();

builder.Services.AddSingleton<ClientData>();

var app = builder.Build();

app.MapCarter();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
