namespace MyFluentValidation;

public class Program
{
    public static async Task Main(string[] args)
    {
        var user = new User
        {
            Email = "testemail.com",  // Invalid email
            Age = 17  // Invalid age (less than 18)
        };

        var validator = new UserValidator();
        var validationResult = await validator.ValidateAsync(user);

        Console.WriteLine($"Is Valid: {validationResult.IsValid}");
        if (!validationResult.IsValid)
        {
            Console.WriteLine("Validation Errors:");
            foreach (var error in validationResult.Errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
