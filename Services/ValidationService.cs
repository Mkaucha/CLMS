using CampusLife.Models;

namespace CampusLife.Services;

/// <summary>
/// Centralised validation logic for all model types.
/// </summary>
public static class ValidationService
{
    // ── CampusEvent ─────────────────────────────────────────────────────────

    public static (bool ok, string error) ValidateEvent(
        string name, string dateTimeText, string location,
        IEnumerable<CampusEvent> existing, Guid? excludeId = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            return (false, "Event name is required.");

        if (string.IsNullOrWhiteSpace(location))
            return (false, "Location is required.");

        if (!DateTime.TryParse(dateTimeText, out DateTime dt))
            return (false, "Date/time is not in a valid format (e.g. 25/05/2026 09:00).");

        // Duplicate check (same name + same date, ignoring the record being edited)
        bool duplicate = existing.Any(e =>
            (excludeId == null || e.Id != excludeId) &&
            string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase) &&
            e.DateTime.Date == dt.Date);

        if (duplicate)
            return (false, "An event with this name already exists on the same date.");

        return (true, string.Empty);
    }

    // ── Club ────────────────────────────────────────────────────────────────

    public static (bool ok, string error) ValidateClub(
        string name, string category,
        IEnumerable<Club> existing, Guid? excludeId = null)
    {
        if (string.IsNullOrWhiteSpace(name))
            return (false, "Club name is required.");

        if (string.IsNullOrWhiteSpace(category))
            return (false, "Category is required.");

        bool duplicate = existing.Any(c =>
            (excludeId == null || c.Id != excludeId) &&
            string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase));

        if (duplicate)
            return (false, "A club with this name already exists.");

        return (true, string.Empty);
    }

    // ── ScheduleEntry ───────────────────────────────────────────────────────

    public static (bool ok, string error) ValidateSchedule(
        string title, string startText, string endText,
        IEnumerable<ScheduleEntry> existing, Guid? excludeId = null)
    {
        if (string.IsNullOrWhiteSpace(title))
            return (false, "Title is required.");

        if (!DateTime.TryParse(startText, out DateTime start))
            return (false, "Start time is not in a valid format.");

        if (!DateTime.TryParse(endText, out DateTime end))
            return (false, "End time is not in a valid format.");

        if (end <= start)
            return (false, "End time must be after start time.");

        // Basic conflict detection
        var candidate = new ScheduleEntry { StartTime = start, EndTime = end };
        var conflict = existing.FirstOrDefault(e =>
            (excludeId == null || e.Id != excludeId) &&
            candidate.ConflictsWith(e));

        if (conflict != null)
            return (false, $"Time conflict with existing entry: \"{conflict.Title}\" ({conflict.StartTime:g} – {conflict.EndTime:t}).");

        return (true, string.Empty);
    }
}
