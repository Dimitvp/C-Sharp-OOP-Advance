using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private const string ExceptionMessage = "No elements";
    private List<T> elements;

    public Stack()
    {
        this.elements = new List<T>();
    }
    public int CurrentIndex { get; protected set; }
    public void Push(T element)
    {
       this.elements.Add(element);
       this.CurrentIndex++;
    }

    public void Pop()
    {
        if (this.elements.Count == 0)
        {
            throw new InvalidOperationException(ExceptionMessage);
        }
        else
        {
            this.elements.Remove(this.elements[CurrentIndex - 1]);
            this.CurrentIndex--;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.elements.Count - 1; i >= 0; i--)
            yield return this.elements[i];
    }
}