using CampusLife.Data;

namespace CampusLife.Services;

/// <summary>
/// Generates summary statistics and notifications for the dashboard.
/// </summary>
public static class SummaryService
{
    public static string BuildSummary(AppData data)
    {
        int totalEvents   = data.Events.Count;
        int upcomingEvents = data.Events.Count(e => e.IsUpcoming);
        int todayEvents   = data.Events.Count(e => e.IsToday);
        int joinedClubs   = data.Clubs.Count(c => c.IsJoined);
        int totalClubs    = data.Clubs.Count;
        int scheduleItems = data.ScheduleEntries.Count;

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("══════════════════════════════════");
        sb.AppendLine("       CAMPUS LIFE SUMMARY        ");
        sb.AppendLine("══════════════════════════════════");
        sb.AppendLine($"  Total Events     : {totalEvents}");
        sb.AppendLine($"  Upcoming Events  : {upcomingEvents}");
        sb.AppendLine($"  Clubs Available  : {totalClubs}");
        sb.AppendLine($"  Clubs Joined     : {joinedClubs}");
        sb.AppendLine($"  Schedule Entries : {scheduleItems}");
        sb.AppendLine("──────────────────────────────────");

        // Notifications
        if (todayEvents > 0)
        {
            sb.AppendLine($"  🔔 You have {todayEvents} event(s) today:");
            foreach (var e in data.Events.Where(e => e.IsToday))
                sb.AppendLine($"     • {e.Name} @ {e.DateTime:t} – {e.Location}");
            sb.AppendLine();
        }

        var next = data.Events
            .Where(e => e.IsUpcoming)
            .OrderBy(e => e.DateTime)
            .FirstOrDefault();

        if (next != null)
        {
            sb.AppendLine($"  ▶ Next event: {next.Name}");
            sb.AppendLine($"    {next.DateTime:dddd, d MMMM yyyy} at {next.DateTime:t}");
            sb.AppendLine($"    Location: {next.Location}");
        }

        sb.AppendLine("══════════════════════════════════");
        return sb.ToString();
    }
}
