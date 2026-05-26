namespace CampusLife.Models;

/// <summary>
/// Represents a personal schedule entry (class, study session, etc.).
/// </summary>
public class ScheduleEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public DateTime StartTime { get; set; } = DateTime.Now;
    public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);
    public string Location { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public string DayOfWeek { get; set; } = System.DateTime.Now.DayOfWeek.ToString();

    public bool ConflictsWith(ScheduleEntry other)
    {
        // Two entries conflict when their time ranges overlap
        return StartTime < other.EndTime && EndTime > other.StartTime;
    }

    public override string ToString() => $"{Title} | {StartTime:g} – {EndTime:t}";
}
