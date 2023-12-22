using Api.Kashilog.Authentications;
using Api.Kashilog.Filters;

// ReSharper disable once CheckNamespace
namespace Api.Kashilog;
public class Startup {
    public Startup(IConfiguration configuration) =>
        Configuration = configuration;

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services) {

        services.ConfigureDependencyInjection(Configuration);

        services.AddDefaultSwaggerService<OpenApiOperationBuildFilter>(Configuration, Assembly.GetExecutingAssembly());

        services.AddTokenAuthenticationService<TokenAuthenticationService>(Configuration);

        services.CreateDefaultBuilder();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        app.UseDefaultSwaggerBuilder(Configuration, env.EnvironmentName);

        app.UseDefaultBuilder(env.EnvironmentName, Configuration.GetConfigureSettings());

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
