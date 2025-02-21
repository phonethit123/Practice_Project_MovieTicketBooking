using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MovieTicketBooking;
using Blazored.LocalStorage;
using MovieTicketBooking.Services;
using MudBlazor;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddBlazoredLocalStorageAsSingleton();
builder.Services.AddSingleton<IDbService, MovieService>();
builder.Services.AddSingleton<PageChangeStateContainer>();


await builder.Build().RunAsync();
