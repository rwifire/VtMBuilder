using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VtMBuilder.Web;
using VtMBuilder.Web.Services;
using VtMBuilder.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("https://localhost:7000/")});
builder.Services.AddScoped<ICharactersService, CharactersService>();

await builder.Build().RunAsync();