using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> : IEnumerable<T>
    where T : IComparable<T>
{
    public IEnumerator<T> GetEnumerator()
    {
        return this.data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    //private T elementToComp;
    List<T> data = new List<T>();

    public CustomList()
    {
        this.data = new List<T>();
    }
    public CustomList(IList<T> collection)
    {
        this.data = new List<T>(collection);
    }
    public int Count => this.data.Count;
    public void Add(T item)
    {
        this.data.Add(item);
    }
    public T Remove(int index)
    {
        var elementToRemove = this.data[index];
        this.data.RemoveAt(index);
        return elementToRemove;
    }
    public bool Contains(T item)
    {
        return data.Contains(item);
        //for (int i = 0; i < data.Count; i++)
        //{
        //    if (data[i].Equals(item))
        //    {
        //        return true;
        //    }
        //}
        //return false;
    }
    public int CountGreaterThan(T elementToComp)
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
    public T Max()
    {
        return data.Max();
    }
    public T Min()
    {
        return data.Min();
    }
    public string Print()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < this.data.Count; i++)
        {
            sb.AppendLine(this.data[i].ToString());
        }

        return sb.ToString().Trim();
    }
    public IList<T> GetList()
    {
        return this.data;
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