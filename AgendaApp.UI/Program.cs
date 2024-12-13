using AgendaApp.UI;
using AgendaApp.UI.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

/*
 * Configura��o da biblioteca HTTP CLIENT 
 * para executar os servi�os da API
 */
builder.Services.AddScoped(sp => new HttpClient());

/*
 * Configura��o da biblioteca Blazored LocalStorage
 */
builder.Services.AddBlazoredLocalStorage();

/*
 * Configura��o para inje��es de depend�ncia
 */
builder.Services.AddTransient<AuthService>();

await builder.Build().RunAsync();



