namespace RuleBasedValidation.Core;

public interface IRuleSet<in T>
{
    // Gets the collection of rules in the rule set.
    // The rules are evaluated in the order they are defined in the collection.

    IReadOnlyCollection<IRule<T>> Rules { get; }
}
