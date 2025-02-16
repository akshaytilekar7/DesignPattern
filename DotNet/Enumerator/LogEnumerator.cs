using System.Collections;

namespace Enumerator;

class FibonacciSeries : IEnumerable
{
    private int _maxCount;

    public FibonacciSeries(int maxCount)
    {
        _maxCount = maxCount;
    }

    public IEnumerator GetEnumerator()
    {
        return new FibonacciEnumerator(_maxCount);
    }
}
