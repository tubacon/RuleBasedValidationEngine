using RuleBasedValidation.Core;
using RuleBasedValidation.Demo.Domain;

using RuleEngine.Rules;

namespace RuleBasedValidation.Demo.Rules;

public static class UserRules
{
    // This is a simple example of how to define rules for a User entity.
    // In a real application, you might want to load these rules from a configuration file or database,
    // or even define them using a fluent API for better readability.
    // The rules are defined as a list of IRule<User> instances, which can be evaluated against a User object.
    // Each rule consists of a description and a predicate that checks a specific condition on the User object.

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
