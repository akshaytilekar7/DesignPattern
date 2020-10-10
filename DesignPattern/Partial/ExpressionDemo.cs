using System;
using System.Linq.Expressions;

namespace DesignPattern.Partial
{
    public class Demo
    {
        public Demo()
        {
            ConstructGreetingExpression();

        }
        public void ConstructGreetingExpression()
        {
            var personNameParameter = Expression.Parameter(typeof(int), "personName");

            // Condition
            var canTryParse = typeof(int).GetMethod(nameof(int.TryParse));

            var condition = Expression.Not(Expression.Call(canTryParse, personNameParameter));

            // True clause
            var trueClause = Expression.Add(Expression.Constant("Greetings, "), personNameParameter);

            // False clause
            var falseClause = Expression.Constant(null, typeof(int));

            // Ternary conditional
            ConditionalExpression e = Expression.Condition(condition, trueClause, falseClause);

            var lambda = Expression.Lambda<Func<int, bool>>(e, personNameParameter);

            var d = lambda.Compile();
            var ans = d(5);

            Console.WriteLine(ans);

        }
        public Demo(int a)
        {
            //Create the expression parameters
            ParameterExpression num1 = Expression.Parameter(typeof(int), "num1");
            ParameterExpression num2 = Expression.Parameter(typeof(int), "num2");
            //Create the expression parameters
            ParameterExpression[] parameters = new[] { num1, num2 };
            //Create the expression body
            BinaryExpression body = Expression.Add(num1, num2);
            //Create the expression
            Expression<Func<int, int, int>> expression = Expression.Lambda<Func<int, int, int>>(body, parameters);
            // Compile the expression
            Func<int, int, int> compiledExpression = expression.Compile();
            // Execute the expression
            int result = compiledExpression(3, 4); //return 7

        }
    }
}


