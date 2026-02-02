using RuleBasedValidation.Core;
using RuleBasedValidation.Demo.Domain;

using RuleEngine.Rules;

namespace RuleBasedValidation.Demo.Rules;

public static class UserRules
{
    public static IReadOnlyList<IRule<User>> All => new IRule<User>[]
    {
        new PredicateRule<User>(
            "User must be active",
            user => user.IsActive
        ),

        new PredicateRule<User>(
            "User must be adult",
            user => user.Age >= 18
        ),

        new PredicateRule<User>(
            "User must have a valid email",
            user => user.Email.Contains('@')
        )
    };
}
