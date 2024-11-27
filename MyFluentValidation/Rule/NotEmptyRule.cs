using MyFluentValidation.Validation;

namespace MyFluentValidation.Rule;

public class EmailValidator<T> : AbstractCustomValidator<T>
{
    public override ValidationResult Validate(T instance)
    {
        var validationResult = new ValidationResult();

        if (string.IsNullOrEmpty(instance.Email))
        {
            validationResult.Errors.Add("Email is required"));
        }
        else if (!new EmailAddressAttribute().IsValid(instance.Email))
        {
            validationResult.Errors.Add(new ValidationFailure("Email", "Invalid email format"));
        }

        return validationResult;
    }
}

public class AgeValidator : AbstractCustomValidator<User>
{
    public override ValidationResult Validate(T instance)
    {
        var validationResult = new ValidationResult();

        if (instance.Age <= 18)
        {
            validationResult.Errors.Add(new ValidationFailure("Age", "Age must be greater than 18"));
        }
        else if (instance.Age >= 100)
        {
            validationResult.Errors.Add(new ValidationFailure("Age", "Age must be less than 100"));
        }

        return validationResult;
    }
}