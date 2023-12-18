namespace Api.Members.Authentications.Claims;

public static class ExtendedClaimTypes {
    const string ClaimTypesOZmallNamespace = "http://schemas.ozmall.co.jp/members/ws/2016/08/web-front-identity/claims";

    public const string HashedUid = ClaimTypesOZmallNamespace + "/hashed-uid";
    public const string OzName = ClaimTypesOZmallNamespace + "/oz-name";
    public const string UniqueName = ClaimTypesOZmallNamespace + "/unique-name";
    public const string LastName = ClaimTypesOZmallNamespace + "/last-name";
    public const string LastNameKana = ClaimTypesOZmallNamespace + "/last-name-kana";
    public const string FirstName = ClaimTypesOZmallNamespace + "/first-name";
    public const string FirstNameKana = ClaimTypesOZmallNamespace + "/first-name-kana";
    public const string PhoneNumber = ClaimTypesOZmallNamespace + "/phone-number";
    public const string ZipCode = ClaimTypesOZmallNamespace + "/zip-code";
    public const string Prefecture = ClaimTypesOZmallNamespace + "/prefecture";
    public const string City = ClaimTypesOZmallNamespace + "/city";
    public const string Street = ClaimTypesOZmallNamespace + "/street";
    public const string Building = ClaimTypesOZmallNamespace + "/building";
    public const string Gender = ClaimTypesOZmallNamespace + "/gender";
    public const string Birthday = ClaimTypesOZmallNamespace + "/birthday";
    public const string IsMarried = ClaimTypesOZmallNamespace + "/is-married";
    public const string OccupationId = ClaimTypesOZmallNamespace + "/occupation-id";
    public const string OccupationName = ClaimTypesOZmallNamespace + "/occupation-name";
    public const string WebMemberId = ClaimTypesOZmallNamespace + "/web-member-id";
    public const string WebMemberEmail = ClaimTypesOZmallNamespace + "/web-member-email";
    public const string MobileMemberId = ClaimTypesOZmallNamespace + "/mobile-member-id";
    public const string MobileMemberEmail = ClaimTypesOZmallNamespace + "/mobile-member-email";
    public const string IsYumenaviMember = ClaimTypesOZmallNamespace + "/is-yumenavi-member";
    public const string IsSaisonMember = ClaimTypesOZmallNamespace + "/is-saison-member";
}
