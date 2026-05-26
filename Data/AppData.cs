using CampusLife.Models;

namespace CampusLife.Data;

/// <summary>
/// Root data container serialised to / deserialised from JSON.
/// </summary>
public class AppData
{
    public List<CampusEvent> Events { get; set; } = [];
    public List<Club> Clubs { get; set; } = [];
    public List<ScheduleEntry> ScheduleEntries { get; set; } = [];
}
