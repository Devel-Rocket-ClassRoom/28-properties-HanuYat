using System.Reflection.Metadata.Ecma335;

class Counter
{
    private int _count;

    public int Count
    {
        get => _count;
        set => _count = value;
    }

    public void Increase() => _count++;
}