using RuleBasedValidation.Core;
using RuleBasedValidation.Engine;

using RuleEngine.Rules;

using Xunit;

public class RuleEngineTests
{
    // This test verifies that the RuleEngine correctly evaluates all provided rules and returns the expected results.
    [Fact]
    public async Task EvaluateAsync_EvaluatesAllRules()
    {
        // Arrange
        var rules = new IRule<int>[]
        {
            new PredicateRule<int>("GreaterThanZero", x => x > 0),
            new PredicateRule<int>("EvenNumber", x => x % 2 == 0)
        };

        var engine = new RuleEngine<int>(rules);

        // Act
        var results = await engine.EvaluateAsync(2);

        // Assert
        Assert.Equal(2, results.Count);
        Assert.All(results, r => Assert.True(r.IsMatch));
    }
}
