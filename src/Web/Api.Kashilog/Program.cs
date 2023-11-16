using Api.Kashilog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

Log.Logger = new ConfigurationBuilder().CreateDefaultLogger();

try {
    Log.Information("Starting Web Host");

    CreateHostBuilder(args).Build().Run();
}
catch (Exception exception) {
    Log.Fatal(exception, "Host terminated unexpectedly");
}
finally {
    Log.CloseAndFlush();
}

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.
        CreateDefaultBuilder(args)
        .UseSerilog()
        .ConfigureAppConfiguration(config => config.AddEnvironmentVariables())
        .ConfigureWebHostDefaults(webBuilder => {
            webBuilder
                .ConfigureKestrel(options => options.AddServerHeader = false)
                .UseStartup<Startup>();

            if (DefaultWebEnvironment.WebApps.IsNotDevelopment()) {
                // setting points : is not Local dev case... 
            }
        });
