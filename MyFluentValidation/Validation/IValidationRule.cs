namespace MyFluentValidation.Validation;

public class ValidationResult
{
    public bool IsValid { get; set; } = true;
    public List<string> Errors { get; } = new List<string>();
}

public interface ICustomValidator<T>
{
    ValidationResult Validate(T instance);
}
