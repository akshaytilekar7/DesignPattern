using System.Linq;

namespace LSP.Models
{
    public class SumCalculator
    {
        protected readonly int[] Numbers;
        public SumCalculator(int[] numbers)
        {
            Numbers = numbers;
        }
        public int Calculate() => Numbers.Sum();
    }
}
