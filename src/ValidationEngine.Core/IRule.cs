namespace RuleBasedValidation.Core;

public interface IRule<in T>
{
    // Evaluates the rule against the provided input and returns the result.
    // The evaluation is asynchronous to allow for any potential I/O operations or complex computations.
    // The cancellation token allows the evaluation to be cancelled if needed, providing better responsiveness in scenarios where multiple rules are being evaluated.

    ValueTask<RuleResult> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default);
}
