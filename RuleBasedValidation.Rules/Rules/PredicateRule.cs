using RuleBasedValidation.Core;

namespace RuleEngine.Rules;

public sealed class PredicateRule<T> : IRule<T>
{
    private readonly Func<T, bool> _predicate;
    private readonly string _name;

    public PredicateRule(string name, Func<T, bool> predicate)
    {
        _name = name;
        _predicate = predicate;
    }

    public ValueTask<RuleResult> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default)
    {
        var isMatch = _predicate(input);

        return ValueTask.FromResult(
            isMatch
                ? RuleResult.Match(_name)
                : RuleResult.NoMatch(_name)
        );
    }
}
