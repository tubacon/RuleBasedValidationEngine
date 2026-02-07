using System.Collections.Generic;
using System.Linq;

namespace RuleBasedValidation.Engine;

public static class RuleResultExtensions
{
    public static bool IsSuccessful(
        this IReadOnlyCollection<RuleResult> results)
        => results.All(r => r.IsMatch);

    public static IEnumerable<string> FailedRuleNames(
        this IReadOnlyCollection<RuleResult> results)
        => results
            .Where(r => !r.IsMatch)
            .Select(r => r.RuleName);

    public static IEnumerable<string> MatchedRuleNames(
        this IReadOnlyCollection<RuleResult> results)
        => results
            .Where(r => r.IsMatch)
            .Select(r => r.RuleName);
}
