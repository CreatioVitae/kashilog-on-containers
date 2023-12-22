using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Web.Kashilog.Core.HttpHeaders.DomainIndicators;

namespace Api.Kashilog.Filters;

public class OpenApiOperationBuildFilter(IConfiguration configuration) : IOperationFilter {
    private IConfiguration Configuration { get; } = configuration;

    public void Apply(OpenApiOperation operation, OperationFilterContext context) {
        operation.Parameters ??= new List<OpenApiParameter>();

        operation.AddRequestedDatetimeOverrideOperationParameters(Configuration.GetAvailableValueByKey("requestContextSettings:timezoneId"), "yyyy/MM/dd HH:mm:ss");

        operation.Parameters.Add(new OpenApiParameter {
            Name = HeaderKeyDefaults.ForceExecuteOption,
            In = ParameterLocation.Header,
            AllowEmptyValue = true,
            Required = false,
            Schema = new OpenApiSchema { Type = "boolean" }
        });
    }
}
