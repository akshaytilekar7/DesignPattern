using AdaptorDesignPattern.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdaptorDesignPattern.Rules;

public class EmailAddressRule<T> : IValidationRule<T>
{
    public string ErrorMessage { get; } = "Invalid email format";

    public async Task<bool> IsValid(T value)
    {
        var email = value?.ToString();
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailRegex);
    }
}
