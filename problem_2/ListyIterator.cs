using System;
using System.Collections;

class ListyIterator<T> : IEnumerable<T>
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

    public void PrintAll()
    {
        foreach (T item in list)
        {
            Console.Write(item + " ");
        }
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

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in list)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}