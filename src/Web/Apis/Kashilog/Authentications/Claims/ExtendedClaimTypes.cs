namespace Api.Kashilog.Authentications.Claims;

public static class ExtendedClaimTypes {
    const string ClaimTypesKashilogNamespace = "http://schemas.kashilog.co.jp/members/ws/2016/08/web-front-identity/claims";

    public const string LastName = ClaimTypesKashilogNamespace + "/last-name";
    public const string LastNameKana = ClaimTypesKashilogNamespace + "/last-name-kana";
    public const string FirstName = ClaimTypesKashilogNamespace + "/first-name";
    public const string FirstNameKana = ClaimTypesKashilogNamespace + "/first-name-kana";
    public const string PhoneNumber = ClaimTypesKashilogNamespace + "/phone-number";
    public const string ZipCode = ClaimTypesKashilogNamespace + "/zip-code";
    public const string Prefecture = ClaimTypesKashilogNamespace + "/prefecture";
    public const string City = ClaimTypesKashilogNamespace + "/city";
    public const string Street = ClaimTypesKashilogNamespace + "/street";
    public const string Building = ClaimTypesKashilogNamespace + "/building";
    public const string Gender = ClaimTypesKashilogNamespace + "/gender";
    public const string Birthday = ClaimTypesKashilogNamespace + "/birthday";
}
