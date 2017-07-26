using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class Box<T>
{
    List<T> data = new List<T>();
    
    public Box()
    {
        this.data = new List<T>();
    }
    public int Count => this.data.Count;
    public void Add(T item)
    {
        this.data.Add(item);
    }

    public T Remove()
    {
        var rem = this.data.Last();
        this.data.RemoveAt(this.data.Count - 1);
        return rem;
    }
}