namespace RuleBasedValidation.Demo.Domain;

public sealed class User
{
    public required string Email { get; init; }
    public required int Age { get; init; }
    public bool IsActive { get; init; }
}
