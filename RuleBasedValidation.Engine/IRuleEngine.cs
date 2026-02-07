using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public interface IRuleEngine<T>
{
    // Evaluates the rules against the provided input and returns a list of rule results.
    ValueTask<IReadOnlyList<RuleResult>> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default);
}
