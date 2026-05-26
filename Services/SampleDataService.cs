using CampusLife.Data;
using CampusLife.Models;

namespace CampusLife.Services;

/// <summary>
/// Seeds realistic sample data so the app is demonstrable on first launch.
/// </summary>
public static class SampleDataService
{
    public static AppData CreateSampleData()
    {
        var data = new AppData();

        // ── Events ──────────────────────────────────────────────────────────
        data.Events.AddRange(
        [
            new CampusEvent
            {
                Name        = "Orientation Week Opening",
                DateTime    = DateTime.Today.AddDays(1).AddHours(9),
                Location    = "Main Auditorium",
                Category    = "Academic",
                Description = "Welcome ceremony for all new students."
            },
            new CampusEvent
            {
                Name        = "Tech Hackathon 2026",
                DateTime    = DateTime.Today.AddDays(3).AddHours(10),
                Location    = "IT Building, Lab 3",
                Category    = "Technology",
                Description = "24-hour coding competition. Teams of up to 4."
            },
            new CampusEvent
            {
                Name        = "Art Exhibition Opening",
                DateTime    = DateTime.Today.AddDays(5).AddHours(14),
                Location    = "Gallery Wing B",
                Category    = "Arts",
                Description = "Student art showcase – semester highlights."
            },
            new CampusEvent
            {
                Name        = "Career Fair",
                DateTime    = DateTime.Today.AddDays(7).AddHours(9),
                Location    = "Sports Hall",
                Category    = "Career",
                Description = "Meet 50+ employers. Bring your résumé."
            }
        ]);

        // ── Clubs ───────────────────────────────────────────────────────────
        data.Clubs.AddRange(
        [
            new Club
            {
                Name            = "Coding Society",
                Category        = "Technology",
                MeetingSchedule = "Every Wednesday 5:00 PM – Room CS-204",
                Description     = "Weekly coding challenges and project collaboration.",
                IsJoined        = true
            },
            new Club
            {
                Name            = "Photography Club",
                Category        = "Arts",
                MeetingSchedule = "Every Friday 4:00 PM – Media Centre",
                Description     = "Learn photography techniques and go on shoots.",
                IsJoined        = false
            },
            new Club
            {
                Name            = "Debate Society",
                Category        = "Academic",
                MeetingSchedule = "Every Tuesday 6:00 PM – Seminar Room 1",
                Description     = "Competitive debating and public speaking skills.",
                IsJoined        = true
            },
            new Club
            {
                Name            = "Environmental Club",
                Category        = "Community",
                MeetingSchedule = "Every Thursday 5:30 PM – Green Campus Hub",
                Description     = "Sustainability initiatives and campus clean-ups.",
                IsJoined        = false
            }
        ]);

        // ── Schedule ────────────────────────────────────────────────────────
        data.ScheduleEntries.AddRange(
        [
            new ScheduleEntry
            {
                Title      = "Advanced Programming Lecture",
                StartTime  = DateTime.Today.AddHours(9),
                EndTime    = DateTime.Today.AddHours(11),
                Location   = "Lecture Theatre 2",
                DayOfWeek  = "Monday",
                Notes      = "Bring laptop and assessment notes."
            },
            new ScheduleEntry
            {
                Title      = "Database Systems Tutorial",
                StartTime  = DateTime.Today.AddHours(13),
                EndTime    = DateTime.Today.AddHours(14),
                Location   = "Lab B-112",
                DayOfWeek  = "Monday",
                Notes      = "Complete pre-work exercises beforehand."
            },
            new ScheduleEntry
            {
                Title      = "Study Group – MIT 211",
                StartTime  = DateTime.Today.AddDays(1).AddHours(15),
                EndTime    = DateTime.Today.AddDays(1).AddHours(17),
                Location   = "Library Level 2",
                DayOfWeek  = "Tuesday",
                Notes      = "Review assessment 2 requirements."
            }
        ]);

        return data;
    }
}
