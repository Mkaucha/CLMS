using CampusLife.Data;
using Newtonsoft.Json;
using System.Text;

namespace CampusLife.Services;

/// <summary>
/// Handles all file I/O: JSON save/load and CSV export.
/// </summary>
public static class FileService
{
    // ── JSON ────────────────────────────────────────────────────────────────

    /// <summary>Serialise application data to a JSON file.</summary>
    public static void SaveJson(AppData data, string filePath)
    {
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, json, Encoding.UTF8);
    }

    /// <summary>Deserialise application data from a JSON file.</summary>
    public static AppData LoadJson(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"Data file not found: {filePath}");

        string json = File.ReadAllText(filePath, Encoding.UTF8);
        return JsonConvert.DeserializeObject<AppData>(json)
               ?? throw new InvalidDataException("Failed to parse data file.");
    }

    // ── CSV export ──────────────────────────────────────────────────────────

    /// <summary>Export all events to a CSV file.</summary>
    public static void ExportEventsCsv(AppData data, string filePath)
    {
        var sb = new StringBuilder();
        sb.AppendLine("Id,Name,DateTime,Location,Category,Description");
        foreach (var e in data.Events)
        {
            sb.AppendLine(
                $"\"{e.Id}\",\"{Escape(e.Name)}\",\"{e.DateTime:o}\"," +
                $"\"{Escape(e.Location)}\",\"{Escape(e.Category)}\",\"{Escape(e.Description)}\"");
        }
        File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
    }

    /// <summary>Export the personal schedule to a CSV file.</summary>
    public static void ExportScheduleCsv(AppData data, string filePath)
    {
        var sb = new StringBuilder();
        sb.AppendLine("Id,Title,StartTime,EndTime,Location,DayOfWeek,Notes");
        foreach (var s in data.ScheduleEntries)
        {
            sb.AppendLine(
                $"\"{s.Id}\",\"{Escape(s.Title)}\",\"{s.StartTime:o}\"," +
                $"\"{s.EndTime:o}\",\"{Escape(s.Location)}\",\"{s.DayOfWeek}\",\"{Escape(s.Notes)}\"");
        }
        File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
    }

    // ── helpers ─────────────────────────────────────────────────────────────

    private static string Escape(string value) => value.Replace("\"", "\"\"");
}
