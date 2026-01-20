namespace RuleBasedValidation.Core;

public interface IRuleContext
{
    //Kurallar arası shared context için altyapı
    //Logging, correlation, tracing gibi ihtiyaçlara açık kapı bırakır

    DateTimeOffset Timestamp { get; }
    IDictionary<string, object?> Metadata { get; }
}
