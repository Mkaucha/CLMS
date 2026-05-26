namespace CampusLife.Models;

/// <summary>
/// Represents a campus club or society.
/// </summary>
public class Club
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string MeetingSchedule { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsJoined { get; set; } = false;

    public override string ToString() => $"{Name} [{Category}]";
}
