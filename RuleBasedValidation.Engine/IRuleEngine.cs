using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public interface IRuleEngine<T>
{
    ValueTask<IReadOnlyList<RuleResult>> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default);
}
