using RuleBasedValidation.Core;

namespace RuleEngine.Rules;

public sealed class AlwaysTrueRule<T> : IRule<T>
{
    private readonly string _name;

    public AlwaysTrueRule(string name)
    {
        _name = name;
    }

    public ValueTask<RuleResult> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default)
    {
        return ValueTask.FromResult(
            RuleResult.Match(_name)
        );
    }
}
