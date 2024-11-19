using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternMiddleware
{
    public class CustomDelegate
    {
        public delegate Task RequestDelegate(HttpContext context);
    }
}
