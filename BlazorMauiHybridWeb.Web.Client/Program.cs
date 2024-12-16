using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorMauiHybridWeb.Shared.Services;
using BlazorMauiHybridWeb.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the BlazorMauiHybridWeb.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
