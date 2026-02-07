using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public sealed class RuleEngine<T> : IRuleEngine<T>
{
    private readonly IReadOnlyList<IRule<T>> _rules;

    // Initializes a new instance of the RuleEngine class with the specified rules.
    public RuleEngine(IEnumerable<IRule<T>> rules)
    {
        _rules = rules.ToList();
    }

    // Evaluates the rules against the provided input and returns a list of rule results.
    public async ValueTask<IReadOnlyList<RuleResult>> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default)
    {
        var results = new List<RuleResult>(_rules.Count);

        foreach (var rule in _rules)
        {
            // Check for cancellation before evaluating each rule.
            cancellationToken.ThrowIfCancellationRequested();

            var result = await rule.EvaluateAsync(input, cancellationToken);
            results.Add(result);
        }

        return results;
    }
}
