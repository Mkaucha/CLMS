using CampusLife.Data;
using CampusLife.Models;
using CampusLife.Services;

namespace CampusLife.Forms;

/// <summary>
/// Logic half of MainForm.  All control declarations and layout live in
/// MainForm.Designer.cs.  This file contains only event handlers and
/// data-binding helpers.
/// </summary>
public partial class MainForm : Form
{
    private AppData _data = new();
    private string? _currentFilePath;
    private bool _isDirty;

    public MainForm()
    {
        InitializeComponent();          // defined in MainForm.Designer.cs
        _data = SampleDataService.CreateSampleData();
        RefreshAll();
        SetStatus("Ready – sample data loaded.");
    }

    // ════════════════════════════════════════════════════════════════════════
    #region Events – handlers

    private void OnEventSelected(object? s, EventArgs e)
    {
        if (dgvEvents.SelectedRows.Count == 0) return;
        var row = dgvEvents.SelectedRows[0];

        // FIXED: Using sequential indices mapping to PopulateEventsGrid order:
        // 0: Id, 1: Name, 2: DateTime, 3: Location, 4: Category, 5: Description
        txtEventName.Text = row.Cells[1].Value?.ToString() ?? "";
        txtEventDateTime.Text = row.Cells[2].Value?.ToString() ?? "";
        txtEventLocation.Text = row.Cells[3].Value?.ToString() ?? "";
        txtEventDesc.Text = row.Cells[5].Value?.ToString() ?? "";
        cmbEventCategory.Text = row.Cells[4].Value?.ToString() ?? "General";
    }

    private void OnAddEvent(object? s, EventArgs e)
    {
        var (ok, err) = ValidationService.ValidateEvent(
            txtEventName.Text, txtEventDateTime.Text, txtEventLocation.Text, _data.Events);
        if (!ok) { ShowError(err); return; }

        _data.Events.Add(new CampusEvent
        {
            Name = txtEventName.Text.Trim(),
            DateTime = DateTime.Parse(txtEventDateTime.Text),
            Location = txtEventLocation.Text.Trim(),
            Description = txtEventDesc.Text.Trim(),
            Category = cmbEventCategory.Text
        });
        MarkDirty(); RefreshEventsGrid(); ClearEventFields();
        SetStatus("Event added.");
    }

    private void OnModifyEvent(object? s, EventArgs e)
    {
        if (dgvEvents.SelectedRows.Count == 0) { ShowError("Select an event to modify."); return; }
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvEvents.SelectedRows[0].Cells[0].Value!.ToString()!);
        var ev = _data.Events.First(x => x.Id == id);
        var (ok, err) = ValidationService.ValidateEvent(
            txtEventName.Text, txtEventDateTime.Text, txtEventLocation.Text, _data.Events, id);
        if (!ok) { ShowError(err); return; }

        ev.Name = txtEventName.Text.Trim();
        ev.DateTime = DateTime.Parse(txtEventDateTime.Text);
        ev.Location = txtEventLocation.Text.Trim();
        ev.Description = txtEventDesc.Text.Trim();
        ev.Category = cmbEventCategory.Text;
        MarkDirty(); RefreshEventsGrid();
        SetStatus("Event updated.");
    }

    private void OnDeleteEvent(object? s, EventArgs e)
    {
        if (dgvEvents.SelectedRows.Count == 0) { ShowError("Select an event to delete."); return; }
        if (Confirm("Delete selected event?") != DialogResult.Yes) return;
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvEvents.SelectedRows[0].Cells[0].Value!.ToString()!);
        _data.Events.RemoveAll(x => x.Id == id);
        MarkDirty(); RefreshEventsGrid(); ClearEventFields();
        SetStatus("Event deleted.");
    }

    private void OnSearchEvents(object? s, EventArgs e)
    {
        string q = txtEventSearch.Text.Trim();
        var result = string.IsNullOrEmpty(q)
            ? _data.Events
            : _data.Events.Where(ev =>
                ev.Name.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                ev.Location.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                ev.Category.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                ev.DateTime.ToString("d").Contains(q)).ToList();
        PopulateEventsGrid(result);
        SetStatus($"{result.Count()} result(s).");
    }

    private void RefreshEventsGrid() => PopulateEventsGrid(_data.Events);

    private void PopulateEventsGrid(IEnumerable<CampusEvent> src)
    {
        dgvEvents.Rows.Clear();
        foreach (var ev in src.OrderBy(e => e.DateTime))
        {
            // Mapped Index tracking: 0:Id, 1:Name, 2:DateTime, 3:Location, 4:Category, 5:Description
            int i = dgvEvents.Rows.Add(ev.Id, ev.Name, ev.DateTime.ToString("g"),
                                       ev.Location, ev.Category, ev.Description);
            if (ev.IsToday)
                dgvEvents.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 190);
        }
    }

    private void ClearEventFields()
    {
        txtEventName.Clear(); txtEventDateTime.Clear();
        txtEventLocation.Clear(); txtEventDesc.Clear();
        cmbEventCategory.SelectedIndex = 0;
    }

    #endregion

    // ════════════════════════════════════════════════════════════════════════
    #region Clubs – handlers

    private void OnClubSelected(object? s, EventArgs e)
    {
        if (dgvClubs.SelectedRows.Count == 0) return;
        var row = dgvClubs.SelectedRows[0];

        // FIXED: Using numerical indexes mapping to PopulateClubsGrid order:
        // 0: Id, 1: Name, 2: Category, 3: Schedule, 4: IsJoined, 5: Description
        txtClubName.Text = row.Cells[1].Value?.ToString() ?? "";
        txtClubCategory.Text = row.Cells[2].Value?.ToString() ?? "";
        txtClubSchedule.Text = row.Cells[3].Value?.ToString() ?? "";
        txtClubDesc.Text = row.Cells[5].Value?.ToString() ?? "";
    }

    private void OnAddClub(object? s, EventArgs e)
    {
        var (ok, err) = ValidationService.ValidateClub(txtClubName.Text, txtClubCategory.Text, _data.Clubs);
        if (!ok) { ShowError(err); return; }
        _data.Clubs.Add(new Club
        {
            Name = txtClubName.Text.Trim(),
            Category = txtClubCategory.Text.Trim(),
            MeetingSchedule = txtClubSchedule.Text.Trim(),
            Description = txtClubDesc.Text.Trim()
        });
        MarkDirty(); RefreshClubsGrid(); ClearClubFields();
        SetStatus("Club added.");
    }

    private void OnJoinClub(object? s, EventArgs e)
    {
        if (dgvClubs.SelectedRows.Count == 0) { ShowError("Select a club first."); return; }
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvClubs.SelectedRows[0].Cells[0].Value!.ToString()!);
        var club = _data.Clubs.First(c => c.Id == id);
        club.IsJoined = !club.IsJoined;
        MarkDirty(); RefreshClubsGrid();
        SetStatus(club.IsJoined ? $"Joined \"{club.Name}\"." : $"Left \"{club.Name}\".");
    }

    private void OnModifyClub(object? s, EventArgs e)
    {
        if (dgvClubs.SelectedRows.Count == 0) { ShowError("Select a club to modify."); return; }
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvClubs.SelectedRows[0].Cells[0].Value!.ToString()!);
        var club = _data.Clubs.First(c => c.Id == id);
        var (ok, err) = ValidationService.ValidateClub(txtClubName.Text, txtClubCategory.Text, _data.Clubs, id);
        if (!ok) { ShowError(err); return; }
        club.Name = txtClubName.Text.Trim();
        club.Category = txtClubCategory.Text.Trim();
        club.MeetingSchedule = txtClubSchedule.Text.Trim();
        club.Description = txtClubDesc.Text.Trim();
        MarkDirty(); RefreshClubsGrid();
        SetStatus("Club updated.");
    }

    private void OnDeleteClub(object? s, EventArgs e)
    {
        if (dgvClubs.SelectedRows.Count == 0) { ShowError("Select a club to delete."); return; }
        if (Confirm("Delete selected club?") != DialogResult.Yes) return;
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvClubs.SelectedRows[0].Cells[0].Value!.ToString()!);
        _data.Clubs.RemoveAll(c => c.Id == id);
        MarkDirty(); RefreshClubsGrid(); ClearClubFields();
        SetStatus("Club deleted.");
    }

    private void OnSearchClubs(object? s, EventArgs e)
    {
        string q = txtClubSearch.Text.Trim();
        var result = string.IsNullOrEmpty(q)
            ? _data.Clubs
            : _data.Clubs.Where(c =>
                c.Name.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                c.Category.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
        PopulateClubsGrid(result);
        SetStatus($"{result.Count()} result(s).");
    }

    private void RefreshClubsGrid() => PopulateClubsGrid(_data.Clubs);

    private void PopulateClubsGrid(IEnumerable<Club> src)
    {
        dgvClubs.Rows.Clear();
        foreach (var c in src.OrderBy(x => x.Name))
        {
            // Mapped Index tracking: 0:Id, 1:Name, 2:Category, 3:MeetingSchedule, 4:IsJoined, 5:Description
            int i = dgvClubs.Rows.Add(c.Id, c.Name, c.Category,
                                      c.MeetingSchedule, c.IsJoined, c.Description);
            if (c.IsJoined)
                dgvClubs.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(215, 255, 215);
        }
    }

    private void ClearClubFields()
    {
        txtClubName.Clear(); txtClubCategory.Clear();
        txtClubSchedule.Clear(); txtClubDesc.Clear();
    }

    #endregion

    // ════════════════════════════════════════════════════════════════════════
    #region Schedule – handlers

    private void OnScheduleSelected(object? s, EventArgs e)
    {
        if (dgvSchedule.SelectedRows.Count == 0) return;
        var row = dgvSchedule.SelectedRows[0];

        // FIXED: Using index parameters to match PopulateScheduleGrid configuration
        // 0:Id, 1:Title, 2:StartTime, 3:EndTime, 4:DayOfWeek, 5:Location, 6:Notes
        txtSchedTitle.Text = row.Cells[1].Value?.ToString() ?? "";
        txtSchedStart.Text = row.Cells[2].Value?.ToString() ?? "";
        txtSchedEnd.Text = row.Cells[3].Value?.ToString() ?? "";
        txtSchedLocation.Text = row.Cells[5].Value?.ToString() ?? "";
        txtSchedNotes.Text = row.Cells[6].Value?.ToString() ?? "";
        cmbSchedDay.Text = row.Cells[4].Value?.ToString() ?? "Monday";
    }

    private void OnAddSchedule(object? s, EventArgs e)
    {
        var (ok, err) = ValidationService.ValidateSchedule(
            txtSchedTitle.Text, txtSchedStart.Text, txtSchedEnd.Text, _data.ScheduleEntries);
        if (!ok) { ShowError(err); return; }
        _data.ScheduleEntries.Add(new ScheduleEntry
        {
            Title = txtSchedTitle.Text.Trim(),
            StartTime = DateTime.Parse(txtSchedStart.Text),
            EndTime = DateTime.Parse(txtSchedEnd.Text),
            Location = txtSchedLocation.Text.Trim(),
            Notes = txtSchedNotes.Text.Trim(),
            DayOfWeek = cmbSchedDay.Text
        });
        MarkDirty(); RefreshScheduleGrid(); ClearScheduleFields();
        SetStatus("Schedule entry added.");
    }

    private void OnModifySchedule(object? s, EventArgs e)
    {
        if (dgvSchedule.SelectedRows.Count == 0) { ShowError("Select an entry to modify."); return; }
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvSchedule.SelectedRows[0].Cells[0].Value!.ToString()!);
        var entry = _data.ScheduleEntries.First(x => x.Id == id);
        var (ok, err) = ValidationService.ValidateSchedule(
            txtSchedTitle.Text, txtSchedStart.Text, txtSchedEnd.Text, _data.ScheduleEntries, id);
        if (!ok) { ShowError(err); return; }
        entry.Title = txtSchedTitle.Text.Trim();
        entry.StartTime = DateTime.Parse(txtSchedStart.Text);
        entry.EndTime = DateTime.Parse(txtSchedEnd.Text);
        entry.Location = txtSchedLocation.Text.Trim();
        entry.Notes = txtSchedNotes.Text.Trim();
        entry.DayOfWeek = cmbSchedDay.Text;
        MarkDirty(); RefreshScheduleGrid();
        SetStatus("Schedule entry updated.");
    }

    private void OnDeleteSchedule(object? s, EventArgs e)
    {
        if (dgvSchedule.SelectedRows.Count == 0) { ShowError("Select an entry to delete."); return; }
        if (Confirm("Delete this schedule entry?") != DialogResult.Yes) return;
        // FIXED: Accessing column index 0 for ID
        var id = Guid.Parse(dgvSchedule.SelectedRows[0].Cells[0].Value!.ToString()!);
        _data.ScheduleEntries.RemoveAll(x => x.Id == id);
        MarkDirty(); RefreshScheduleGrid(); ClearScheduleFields();
        SetStatus("Schedule entry deleted.");
    }

    private void OnSearchSchedule(object? s, EventArgs e)
    {
        string q = txtSchedSearch.Text.Trim();
        var result = string.IsNullOrEmpty(q)
            ? _data.ScheduleEntries
            : _data.ScheduleEntries.Where(x =>
                x.Title.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                x.Location.Contains(q, StringComparison.OrdinalIgnoreCase) ||
                x.DayOfWeek.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
        PopulateScheduleGrid(result);
        SetStatus($"{result.Count()} result(s).");
    }

    private void RefreshScheduleGrid() => PopulateScheduleGrid(_data.ScheduleEntries);

    private void PopulateScheduleGrid(IEnumerable<ScheduleEntry> src)
    {
        dgvSchedule.Rows.Clear();
        foreach (var x in src.OrderBy(e => e.StartTime))
            // Mapped Index tracking: 0:Id, 1:Title, 2:StartTime, 3:EndTime, 4:DayOfWeek, 5:Location, 6:Notes
            dgvSchedule.Rows.Add(x.Id, x.Title, x.StartTime.ToString("g"),
                                 x.EndTime.ToString("t"), x.DayOfWeek, x.Location, x.Notes);
    }

    private void ClearScheduleFields()
    {
        txtSchedTitle.Clear(); txtSchedStart.Clear(); txtSchedEnd.Clear();
        txtSchedLocation.Clear(); txtSchedNotes.Clear();
    }

    #endregion

    // ════════════════════════════════════════════════════════════════════════
    #region Dashboard

    private void RefreshSummary() => rtbSummary.Text = SummaryService.BuildSummary(_data);

    #endregion

    // ════════════════════════════════════════════════════════════════════════
    #region File menu handlers

    private void OnNew(object? s, EventArgs e)
    {
        if (!PromptSaveIfDirty()) return;
        _data = new AppData(); _currentFilePath = null; _isDirty = false;
        RefreshAll(); SetStatus("New system created.");
    }

    private void OnLoad(object? s, EventArgs e)
    {
        if (!PromptSaveIfDirty()) return;
        using var dlg = new OpenFileDialog
        {
            Title = "Load Data File",
            Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*"
        };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try
        {
            _data = FileService.LoadJson(dlg.FileName);
            _currentFilePath = dlg.FileName; _isDirty = false;
            RefreshAll(); SetStatus($"Loaded: {Path.GetFileName(dlg.FileName)}");
        }
        catch (Exception ex) { ShowError($"Failed to load:\n{ex.Message}"); }
    }

    private void OnSave(object? s, EventArgs e)
    {
        if (_currentFilePath == null) { OnSaveAs(s, e); return; }
        SaveToPath(_currentFilePath);
    }

    private void OnSaveAs(object? s, EventArgs e)
    {
        using var dlg = new SaveFileDialog
        {
            Title = "Save Data File",
            Filter = "JSON Files (*.json)|*.json",
            FileName = "campus_data.json",
            DefaultExt = "json"
        };
        if (dlg.ShowDialog() == DialogResult.OK) SaveToPath(dlg.FileName);
    }

    private void OnExportEventsCsv(object? s, EventArgs e)
    {
        using var dlg = new SaveFileDialog
        { Title = "Export Events", Filter = "CSV Files (*.csv)|*.csv", FileName = "events.csv" };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try { FileService.ExportEventsCsv(_data, dlg.FileName); SetStatus("Events exported."); }
        catch (Exception ex) { ShowError($"Export failed:\n{ex.Message}"); }
    }

    private void OnExportScheduleCsv(object? s, EventArgs e)
    {
        using var dlg = new SaveFileDialog
        { Title = "Export Schedule", Filter = "CSV Files (*.csv)|*.csv", FileName = "schedule.csv" };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try { FileService.ExportScheduleCsv(_data, dlg.FileName); SetStatus("Schedule exported."); }
        catch (Exception ex) { ShowError($"Export failed:\n{ex.Message}"); }
    }

    private void SaveToPath(string path)
    {
        try
        {
            FileService.SaveJson(_data, path);
            _currentFilePath = path; _isDirty = false;
            SetStatus($"Saved: {Path.GetFileName(path)}");
        }
        catch (Exception ex) { ShowError($"Failed to save:\n{ex.Message}"); }
    }

    private void OnAbout(object? s, EventArgs e) =>
        MessageBox.Show(
            "Campus Life Management System\n" +
            "MIT 211 \u2013 Advanced Programming Techniques\n\n" +
            "C# 14 / .NET 10 Windows Forms\n" +
            "Assessment 2 \u2013 Group Project",
            "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

    #endregion

    // ════════════════════════════════════════════════════════════════════════
    #region Shared helpers

    private void RefreshAll()
    {
        RefreshEventsGrid(); RefreshClubsGrid(); RefreshScheduleGrid();
        if (tabControl1.SelectedIndex == 3) RefreshSummary();
        UpdateTitle();
    }

    private void MarkDirty() { _isDirty = true; UpdateTitle(); }

    private void UpdateTitle() =>
        Text = $"Campus Life Management System \u2013 MIT 211{(_isDirty ? " *" : "")}";

    private void SetStatus(string msg) => toolStripStatusLabel1.Text = $"  {msg}";

    private static void ShowError(string msg) =>
        MessageBox.Show(msg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    private static DialogResult Confirm(string msg) =>
        MessageBox.Show(msg, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

    private bool PromptSaveIfDirty()
    {
        if (!_isDirty) return true;
        var r = MessageBox.Show("Unsaved changes. Save now?", "Unsaved Changes",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (r == DialogResult.Cancel) return false;
        if (r == DialogResult.Yes) OnSave(null, EventArgs.Empty);
        return true;
    }

    private void MainForm_FormClosing(object? s, FormClosingEventArgs e)
    {
        if (!PromptSaveIfDirty()) e.Cancel = true;
    }

    #endregion

    private void lblEventName_Click(object sender, EventArgs e)
    {

    }
}