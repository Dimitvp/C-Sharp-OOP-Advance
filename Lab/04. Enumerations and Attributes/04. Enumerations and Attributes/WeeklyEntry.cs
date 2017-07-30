﻿using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    //private WeekDay weekDay;
    public WeeklyEntry(string weekDay, string notes)
    {
        this.WeekDay =(WeekDay) Enum.Parse(typeof(WeekDay), weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay { get; private set; }
    public string Notes { get; private set; }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var weekDayComparison = this.WeekDay.CompareTo(other.WeekDay);
        if (weekDayComparison != 0)
        {
            return weekDayComparison;
        }
        return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
    }
}