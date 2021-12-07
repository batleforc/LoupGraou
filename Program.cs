using LoupGraou.Hubs;
using Moteur;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<IGameHandler,SingleGameHandler>();
builder.Services.AddControllers();
builder.Services.AddSignalRCore();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints=> {
    endpoints.MapHub<ChatHub>("/async/chat");
});

app.Run();
