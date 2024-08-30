

using DemoLibrary.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// Configuration
IConfigurationBuilder builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true);
IConfigurationRoot config = builder.Build();



// Dependency Injection
// Build the DI
ServiceCollection container = new ServiceCollection();
container.AddTransient<IDemo, UtcDemo>();
container.AddTransient<IProcessDemo, ProcessDemo>();

ServiceProvider serviceProvider =  container.BuildServiceProvider();



// Resolve the DI
IDemo app =  serviceProvider.GetRequiredService<IDemo>();
IDemo app1 =  serviceProvider.GetRequiredService<IDemo>();
IProcessDemo proApp = serviceProvider.GetRequiredService<IProcessDemo>();

// 
Console.WriteLine(app.StartupTime.ToString("hh:mm:ss fffffff"));
Console.WriteLine(app1.StartupTime.ToString("hh:mm:ss fffffff"));
Console.WriteLine(proApp.GetDaysInMonth());