using System;
using System.Collections;

class Stack<T> : IEnumerable<T>
{
    List<T> list;
    int index = 0;

    public Stack()
    {
        list = new List<T>();
    }

    public void Push(T[] element)
    {
        foreach (var item in element)
        {
            list.Insert(index++, item);
        }
    }

    public void Pop()
    {
        index--;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = index; i >= 0; i--)
        {
            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}