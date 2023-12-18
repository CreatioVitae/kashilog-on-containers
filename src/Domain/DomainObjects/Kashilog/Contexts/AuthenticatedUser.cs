namespace DomainObject.Kashilog.Contexts;

public class AuthenticatedUser {
    public required string Id { get; init; }

    public required string Email { get; init; }
}
