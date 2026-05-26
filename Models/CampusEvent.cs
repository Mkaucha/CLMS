namespace CampusLife.Models;

/// <summary>
/// Represents a campus event with all relevant details.
/// </summary>
public class CampusEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public DateTime DateTime { get; set; } = DateTime.Now;
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = "General";

    public bool IsToday  => DateTime.Date == System.DateTime.Today;
    public bool IsUpcoming => DateTime >= System.DateTime.Now;

    public override string ToString() => $"{Name} – {DateTime:g} @ {Location}";
}
