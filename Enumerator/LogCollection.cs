namespace Enumerator;
using System.Collections;

class FibonacciEnumerator : IEnumerator
{
    private int _prev = 0, _current = 1;
    private int _count;
    private int _maxCount;

    public FibonacciEnumerator(int maxCount)
    {
        _maxCount = maxCount;
    }

    public object Current => _prev; 

    public bool MoveNext()
    {
        if (_count >= _maxCount)
            return false; 

        int next = _prev + _current;
        _prev = _current;
        _current = next;
        _count++;

        return true;
    }

    public void Reset()
    {
        _prev = 0;
        _current = 1;
        _count = 0;
    }
}
