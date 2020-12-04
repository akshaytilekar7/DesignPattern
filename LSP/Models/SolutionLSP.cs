using System.Linq;

namespace LSP.Models
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }
    public class SumCalculator1 : Calculator
    {
        public SumCalculator1(int[] numbers)
            : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Sum();
    }

    public class EvenNumbersSumCalculator1 : Calculator
    {
        public EvenNumbersSumCalculator1(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
