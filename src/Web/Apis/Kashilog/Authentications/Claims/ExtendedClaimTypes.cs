namespace Api.Kashilog.Authentications.Claims;

public static class ExtendedClaimTypes {
    const string ClaimTypesKashilogNamespace = "http://schemas.kashilog.co.jp/members/ws/2016/08/web-front-identity/claims";

    public const string HashedUid = ClaimTypesKashilogNamespace + "/hashed-uid";
    public const string OzName = ClaimTypesKashilogNamespace + "/oz-name";
    public const string UniqueName = ClaimTypesKashilogNamespace + "/unique-name";
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
    public const string IsMarried = ClaimTypesKashilogNamespace + "/is-married";
    public const string OccupationId = ClaimTypesKashilogNamespace + "/occupation-id";
    public const string OccupationName = ClaimTypesKashilogNamespace + "/occupation-name";
    public const string WebMemberId = ClaimTypesKashilogNamespace + "/web-member-id";
    public const string WebMemberEmail = ClaimTypesKashilogNamespace + "/web-member-email";
    public const string MobileMemberId = ClaimTypesKashilogNamespace + "/mobile-member-id";
    public const string MobileMemberEmail = ClaimTypesKashilogNamespace + "/mobile-member-email";
    public const string IsYumenaviMember = ClaimTypesKashilogNamespace + "/is-yumenavi-member";
    public const string IsSaisonMember = ClaimTypesKashilogNamespace + "/is-saison-member";
}
