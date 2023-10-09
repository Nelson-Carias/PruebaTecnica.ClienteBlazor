using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PruebaTecnica.ClienteBlazor;
using PruebaTecnica.ClienteBlazor.Services;

using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PruebaTecnica.ClienteBlazor.Extensiones;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7195/api/") });

builder.Services.AddScoped<IRolService, RolService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IVehiculoService, VehiculoService>();

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider,AutenticacionExtension>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
