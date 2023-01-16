using System;
using System.Collections;

class Frog : IEnumerable<int>
{
    private int[] list;

    public Frog(int[] stone)
    {
        list = stone;
    }
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (i % 2 == 0)
            {
                yield return list[i];
            }
        }

        for (int i = list.Length; i > 0; i--)
        {
            if (i % 2 != 0)
            {
                yield return list[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}