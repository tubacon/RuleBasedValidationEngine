namespace RuleBasedValidation.Core;

public sealed record RuleResult(
    bool IsValid,
    string Code,
    string Message)
{
    //Bir kuralın sonucunu standart ve immutable şekilde temsil eder
    //Exception yerine explicit result modeli
    //Pattern matching için ideal

    public static RuleResult Success(string code = "OK") =>
        new(true, code, string.Empty);

    public static RuleResult Failure(string code, string message) =>
        new(false, code, message);
}
