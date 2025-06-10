using Blazored.Toast;
using Malvin_Lopez_AP1_P1.Components;
using Malvin_Lopez_AP1_P1.Dal;
using Malvin_Lopez_AP1_P1.Services; 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var ConStr = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContextFactory<Contexto>(options =>
    options.UseNpgsql(ConStr));

builder.Services.AddScoped<RegistroService>();
builder.Services.AddBlazoredToast();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();