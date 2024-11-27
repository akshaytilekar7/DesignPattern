using MyFluentValidation.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFluentValidation.Validation;

public abstract class AbstractCustomValidator<T> : ICustomValidator<T>
{
    protected readonly List<ICustomValidator<T>> Validators = new List<ICustomValidator<T>>();
    public virtual ValidationResult Validate(T instance)
    {
        var validationResult = new ValidationResult();

        foreach (var validator in Validators)
        {
            var innerResult = validator.Validate(instance);
            validationResult.Errors.AddRange(innerResult.Errors);

            if (!validationResult.IsValid)
                break;
        }

        return validationResult;
    }

    public AbstractCustomValidator<T> AddValidator(ICustomValidator<T> validator)
    {
        Validators.Add(validator);
        return this;
    }
}
