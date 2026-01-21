namespace RuleBasedValidation.Core;

public sealed class RuleResult
{
    public bool IsMatch { get; }
    public string RuleName { get; }

    private RuleResult(bool isMatch, string ruleName)
    {
        IsMatch = isMatch;
        RuleName = ruleName;
    }

    public static RuleResult Match(string ruleName)
        => new(true, ruleName);

    public static RuleResult NoMatch(string ruleName)
        => new(false, ruleName);
}
