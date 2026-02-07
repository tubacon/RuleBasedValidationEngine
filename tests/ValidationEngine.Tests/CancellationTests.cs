using System.Threading;

using RuleBasedValidation.Core;
using RuleBasedValidation.Engine;

using Xunit;

public class CancellationTests
{
    [Fact]
    public async Task EvaluateAsync_WhenCancelled_ThrowsOperationCanceledException()
    {
        var rule = new SlowRule();
        var engine = new RuleEngine<int>(new[] { rule });

        using var cts = new CancellationTokenSource();
        cts.Cancel();

        await Assert.ThrowsAsync<OperationCanceledException>(async () =>
        {
            await engine.EvaluateAsync(1, cts.Token);
        });

    }

    private sealed class SlowRule : IRule<int>
    {
        public async ValueTask<RuleResult> EvaluateAsync(
            int input,
            CancellationToken cancellationToken = default)
        {
            await Task.Delay(1000, cancellationToken);
            return RuleResult.Match("SlowRule");
        }
    }
}
