using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdaptorDesignPattern.Validator;


public interface IValidationRule<T>
{
    Task<bool> IsValid(T value);
    string ErrorMessage { get; }
}


