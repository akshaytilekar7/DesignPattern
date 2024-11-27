using AdaptorDesignPattern.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern.Validator;

public class RuleBuilder<T>
{
    private List<IValidationRule<T>> _rules = new List<IValidationRule<T>>();
    private List<string> _errorMessages = new List<string>();

    public RuleBuilder<T> NotEmpty()
    {
        _rules.Add(new NotEmptyRule<T>());
        return this;
    }

    public RuleBuilder<T> EmailAddress()
    {
        _rules.Add(new EmailAddressRule<T>());
        return this;
    }

    public async Task<List<string>> ValidateAsync(T value)
    {
        _errorMessages.Clear();

        foreach (var rule in _rules)
            if (!await rule.IsValid(value))
                _errorMessages.Add(rule.ErrorMessage);

        return _errorMessages;
    }
}