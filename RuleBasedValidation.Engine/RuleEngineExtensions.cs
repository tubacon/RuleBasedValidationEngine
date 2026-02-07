using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public static class RuleEngineExtensions
{
    // This extension method allows users to directly get a ValidationSummary from the rule engine without having to manually summarize the results.
    // It simplifies the common use case of validating an input and getting a summary of the results in one step.

    public static async ValueTask<ValidationSummary> ValidateAsync<T>(
        this IRuleEngine<T> engine,
        T input,
        CancellationToken cancellationToken = default)
    {
        var results = await engine.EvaluateAsync(input, cancellationToken);
        return RuleResultProcessor.Summarize(results);
    }
}
