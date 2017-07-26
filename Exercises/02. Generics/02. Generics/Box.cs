using System;
using System.Collections.Generic;
using System.Text;

public class Box<T> where T : IComparable<T>
{
    //private T elementToComp;
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

    public int Compar(T elementToComp)
    {
        int counter = 0;
        foreach (T item in data)
        {
            if (item.CompareTo(elementToComp) > 0)
            {
                counter++;
            }
        }
        return counter;
    }
    public void Swap(int firstIndex, int secondIndex)
    {
        var newData = this.data;
        var firstEle = this.data[firstIndex];
        var secondEle = this.data[secondIndex];

        data[firstIndex] = secondEle;
        data[secondIndex] = firstEle;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (T item in data)
        {
            sb.Append($"{item.GetType().FullName}: {item}");
            sb.AppendLine();
        }
        return sb.ToString().Trim();
    }
}