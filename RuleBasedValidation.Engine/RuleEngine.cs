using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public sealed class RuleEngine<T> : IRuleEngine<T>
{
    private readonly IReadOnlyList<IRule<T>> _rules;

    public RuleEngine(IEnumerable<IRule<T>> rules)
    {
        _rules = rules.ToList();
    }

    public async ValueTask<IReadOnlyList<RuleResult>> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default)
    {
        var results = new List<RuleResult>(_rules.Count);

        foreach (var rule in _rules)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await rule.EvaluateAsync(input, cancellationToken);
            results.Add(result);
        }

        return results;
    }
}
