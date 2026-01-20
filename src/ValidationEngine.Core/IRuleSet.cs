namespace RuleBasedValidation.Core;

public interface IRuleSet<in T>
{
    //Birden fazla kuralı mantıksal grup olarak temsil eder
    //Engine bu interface üzerinden kural setlerini işleyecek

    IReadOnlyCollection<IRule<T>> Rules { get; }
}
