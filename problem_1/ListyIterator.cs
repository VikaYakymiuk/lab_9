using System;

class ListyIterator<T>
{
    private List<T> list;
    int position = 0;

    public ListyIterator(T[] lists)
    {
        list = new List<T>(lists);
    }

    public void Print()
    {
        Console.WriteLine(list[position]);
    }

    public bool Move()
    {
        if (position < list.Count - 1)
        {
            position++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasNext()
    {
        if (position < list.Count - 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}