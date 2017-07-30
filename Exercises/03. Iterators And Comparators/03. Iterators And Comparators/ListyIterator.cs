using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

public class ListyIterator<T> : IEnumerable<T>
{
    private const string ExceptionMessage = "Invalid Operation!";
    private readonly IList<T> elements;

    public ListyIterator(params T[] elements)
    {
        this.CurrentIndex = 0;
        this.elements = new List<T>(elements);
    }
    public int CurrentIndex { get; protected set; }
    public bool Move()
    {
        if (this.CurrentIndex < this.elements.Count - 1)
        {
            ++this.CurrentIndex;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        if (this.CurrentIndex < this.elements.Count - 1)
        {
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException(ExceptionMessage);
        }
        else
        {
             Console.WriteLine($"{this.elements[this.CurrentIndex]}");
        }
    }

    public void PrintAll()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException(ExceptionMessage);
        }
        else
        {
            Console.WriteLine($"{string.Join(" ", this.elements)}");
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.elements.Count - 1; i++)
            yield return this.elements[i];
    }
}