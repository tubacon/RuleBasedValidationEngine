using RuleBasedValidation.Core;

namespace RuleBasedValidation.Engine;

public static class RuleResultProcessor
{
    public static ValidationSummary Summarize(
        IReadOnlyList<RuleResult> results)
    {
        var passed = new List<RuleResult>();
        var failed = new List<RuleResult>();

        foreach (var result in results)
        {
            switch (result)
            {
                case { IsMatch: true }:
                    passed.Add(result);
                    break;

                case { IsMatch: false }:
                    failed.Add(result);
                    break;
            }
        }

        return new ValidationSummary(
            IsValid: failed.Count == 0,
            FailedRules: failed,
            PassedRules: passed
        );
    }
}
