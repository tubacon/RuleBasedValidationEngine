using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public static class RuleEngineExtensions
{
    public static async ValueTask<ValidationSummary> ValidateAsync<T>(
        this IRuleEngine<T> engine,
        T input,
        CancellationToken cancellationToken = default)
    {
        var results = await engine.EvaluateAsync(input, cancellationToken);
        return RuleResultProcessor.Summarize(results);
    }
}
