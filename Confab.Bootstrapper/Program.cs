using Confab.Modules.Conferences.Api;
using Confab.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGlobalInfrastructure();
builder.Services.AddConferences();


var app = builder.Build();

app.UseGlobalInfrastructure();

app.Run();