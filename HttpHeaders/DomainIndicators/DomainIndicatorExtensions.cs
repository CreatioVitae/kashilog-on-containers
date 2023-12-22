namespace Core.Tokyo.Experience.Cn.Playguide.HttpHeaders.DomainIndicators;

public class HeaderKeyDefaults {
    public const string ForceExecuteOption = "x-force-execute-option";
    public const string ForceDefaultExecutionDate = "x-force-default-execution-date";
}

public static class DomainIndicatorExtensions {
    public static bool GetForceExecuteOption(this HttpContext context, bool canFallBack = true, bool defaultOption = false) =>
        context.GetBoolValueFromHeader(canFallBack, defaultOption, HeaderKeyDefaults.ForceExecuteOption, nameof(HeaderKeyDefaults.ForceExecuteOption));

    public static bool GetForceDefaultExecutionDate(this HttpContext context, bool canFallBack = true, bool defaultOption = false) =>
        context.GetBoolValueFromHeader(canFallBack, defaultOption, HeaderKeyDefaults.ForceDefaultExecutionDate, nameof(HeaderKeyDefaults.ForceDefaultExecutionDate));

    internal static bool GetBoolValueFromHeader(this HttpContext context, bool canFallBack, bool defaultOption, string headerKey, string headerName) =>
        context.GetHeaderValue(headerKey) is not string headerValue
            ? canFallBack ? defaultOption : throw new ArgumentNullException($"{headerName} header is not available.")
            : bool.TryParse(headerValue, out var result)
            ? result
            : canFallBack
            ? defaultOption
            : throw new InvalidCastException($"{headerName} header is not available.");
}
