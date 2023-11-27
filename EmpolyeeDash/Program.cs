using EmpolyeeDash;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;  

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt8QHFqVkBrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRcQ1xiTX5WckxgX35fdHI=;Mgo+DSMBPh8sVXJ3S0d+X1dPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSH9SckVmXXZddnVRR2c=;Mgo+DSMBMAY9C3t2VlhhQlJCfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn9Sd0FjXHtXc3JXRmRe;MjgxMjA4N0AzMjMzMmUzMDJlMzBMQ3Bwa0Q5czM0VkMvQWhydXNRZE15SzJiK1hFS1ZPb3dXNDExcU5jQ0c4PQ==");
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
