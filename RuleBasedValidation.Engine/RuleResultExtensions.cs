using System.Collections.Generic;
using System.Linq;

namespace RuleBasedValidation.Engine;

public static class RuleResultExtensions
{
     /// <summary>
     /// Determines whether all rule results in the collection are successful matches.
     /// </summary>
     /// <remarks>Use this method to quickly verify that all rules have been satisfied. If the collection is
     /// empty, the method returns true.</remarks>
     /// <param name="results">The collection of rule results to evaluate. Cannot be null.</param>
     /// <returns>true if every rule result in the collection is a match; otherwise, false.</returns>
     ///

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
