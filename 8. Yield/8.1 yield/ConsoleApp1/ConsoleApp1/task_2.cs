using System.Collections;
public class CustomIterator : IEnumerable<int>, IEnumerator<int>
{
    int currentNumber = 0;
    int maxNumber = 100;

    public void Dispose()
    {
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if (currentNumber < maxNumber)
        {
            currentNumber++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
    }

    IEnumerator<int> IEnumerable<int>.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public object Current => currentNumber;

    int IEnumerator<int>.Current => currentNumber;
}