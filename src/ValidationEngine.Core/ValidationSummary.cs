namespace RuleBasedValidation.Core;

public sealed record ValidationSummary(
    bool IsValid,
    IReadOnlyList<RuleResult> FailedRules,
    IReadOnlyList<RuleResult> PassedRules
);
