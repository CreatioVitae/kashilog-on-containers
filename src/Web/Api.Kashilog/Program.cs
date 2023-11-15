using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace Api.Kashilog {
    public class Program {
        public static void Main(string[] args) {
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
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder
                    .ConfigureKestrel(options => options.AddServerHeader = false)
                    .UseStartup<Startup>();
                });
    }
}
