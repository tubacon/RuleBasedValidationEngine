using RuleBasedValidation.Engine;
using RuleBasedValidation.Demo.Domain;
using RuleBasedValidation.Demo.Rules;

var user = new User
{
    Email = "testexample.com",
    Age = 16,
    IsActive = true
};

var engine = new RuleEngine<User>(UserRules.All);

/*

var results = await engine.EvaluateAsync(user);

foreach (var result in results)
{
    Console.WriteLine(
        $"{result.RuleName}: {(result.IsMatch ? "PASSED" : "FAILED")}"
    );
}*/


var summary = await engine.ValidateAsync(user);

Console.WriteLine($"Is valid: {summary.IsValid}");

foreach (var failed in summary.FailedRules)
{
    Console.WriteLine($"FAILED: {failed.RuleName}");
}

