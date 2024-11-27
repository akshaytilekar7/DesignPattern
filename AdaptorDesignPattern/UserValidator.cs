using AdaptorDesignPattern.Validator;

namespace AdaptorDesignPattern;

public class User
{
    public string Email { get; set; }
    public int Age { get; set; }
}

public class UserValidator
{
    public RuleBuilder<string> RuleForEmail { get; } = new RuleBuilder<string>();

    public UserValidator()
    {
        RuleForEmail
            .NotEmpty()
            .EmailAddress();
    }

    public async Task<List<string>> ValidateAsync(User user)
    {
        var errors = new List<string>();

        // Validate Email
        var emailErrors = await RuleForEmail.ValidateAsync(user.Email);
        errors.AddRange(emailErrors);

        // You can add more validation logic here for other properties like Age.

        return errors;
    }
}
