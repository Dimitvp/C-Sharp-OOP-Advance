using System.Collections.Generic;

public class WeeklyCalendar
{
    private IList<WeeklyEntry> data;
    public WeeklyCalendar()
    {
        this.WeeklySchedule = new List<WeeklyEntry>();
    }
    public IEnumerable<WeeklyEntry> WeeklySchedule { get; }
    public void AddEntry(string weekday, string notes)
    {
        this.data.Add(new WeeklyEntry(weekday, notes));
    }
}