using MyFluentValidation.Rule;
using MyFluentValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFluentValidation;

public class User
{
    public string Email { get; set; }
    public int Age { get; set; }
}

public class UserValidator : IValidationRule<User>
{
    public Task<ValidationResult> ValidateAsync(User entity)
    {
        entity.Email.
    }
}