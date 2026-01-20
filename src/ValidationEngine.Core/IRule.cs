namespace RuleBasedValidation.Core;

public interface IRule<in T>
{
    //Her validation kuralının kontratı
    //Engine bu interface üzerinden çalışacak
    //in T → farklı türleri esnek kullanabilmek için

    ValueTask<RuleResult> EvaluateAsync(
        T input,
        CancellationToken cancellationToken = default);
}
