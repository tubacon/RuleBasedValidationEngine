using RuleEngine.Rules;

using Xunit;

public class PredicateRuleTests
{
    // This test verifies that the PredicateRule correctly identifies a match when the predicate condition is satisfied.
    [Fact]
    public async Task EvaluateAsync_WhenPredicateMatches_ReturnsMatch()
    {
        // Arrange
        var rule = new PredicateRule<int>(
            "PositiveNumber",
            x => x > 0);

        // Act
        var result = await rule.EvaluateAsync(5);

        // Assert
        Assert.True(result.IsMatch);
        Assert.Equal("PositiveNumber", result.RuleName);
    }

    // This test verifies that the PredicateRule correctly identifies a non-match when the predicate condition is not satisfied.
    [Fact]
    public async Task EvaluateAsync_WhenPredicateDoesNotMatch_ReturnsNoMatch()
    {
        var rule = new PredicateRule<int>(
            "PositiveNumber",
            x => x > 0);

        var result = await rule.EvaluateAsync(-1);

        Assert.False(result.IsMatch);
    }
}
