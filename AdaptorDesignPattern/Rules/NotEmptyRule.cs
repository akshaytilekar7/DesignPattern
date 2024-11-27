using AdaptorDesignPattern.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern.Rules;

public class NotEmptyRule<T> : IValidationRule<T>
{
    public string ErrorMessage { get; } = "Value cannot be empty";

    public async Task<bool> IsValid(T value)
    {
        return value != null && !string.IsNullOrWhiteSpace(value.ToString());
    }
}
