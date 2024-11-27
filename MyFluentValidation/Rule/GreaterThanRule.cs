using MyFluentValidation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFluentValidation.Rule;

public class EmailCalidation : IValidationRule<string>
{
    private readonly string value;

    public EmailCalidation(string value)
    {
        this.value = value;
    }
    public IValidationRule<string> Email()
    {
        if(!value.Contains("@"))
            
    }

    public IValidationRule<string> NotEmpty()
    {
        throw new NotImplementedException();
    }

    public IValidationRule<string> Required()
    {
        throw new NotImplementedException();
    }

    public IValidationRule<string> WithMessage(string value)
    {
        throw new NotImplementedException();
    }
}
