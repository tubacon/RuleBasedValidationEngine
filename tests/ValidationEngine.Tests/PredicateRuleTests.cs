using RuleEngine.Rules;

using Xunit;

public class PredicateRuleTests
{
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
