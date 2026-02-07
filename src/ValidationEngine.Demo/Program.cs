using RuleBasedValidation.Engine;
using RuleBasedValidation.Demo.Domain;
using RuleBasedValidation.Demo.Rules;

// Create a sample user that violates some of the defined rules
var user = new User
{
    Email = "testexample.com",
    Age = 16,
    IsActive = true
};

// Create a rule engine with the defined rules for the User entity
var engine = new RuleEngine<User>(UserRules.All);

// Using extension methods for a more concise syntax
var results = await engine.EvaluateAsync(user);

if (results.IsSuccessful())
{
    Console.WriteLine("Validation passed");
}
else
{
    Console.WriteLine("Validation failed:");
    foreach (var rule in results.FailedRuleNames())
    {
        Console.WriteLine($"- {rule}");
    }
}


