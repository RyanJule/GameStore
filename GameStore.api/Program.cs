using GameStore.api;
using GameStore.api.Dtos;
using GameStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
