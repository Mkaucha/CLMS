# Campus Life Management System
### MIT 211 – Advanced Programming Techniques | Assessment 2

---

## Prerequisites

| Tool | Version |
|------|---------|
| .NET SDK | **10.0** or later |
| Windows | 10 / 11 (Windows Forms required) |

Install .NET 10 from: https://dotnet.microsoft.com/download/dotnet/10.0

---

## Project Structure

```
CampusLife/
├── CampusLife.csproj          # Project file (.NET 10 WinForms)
├── Program.cs                 # Entry point
├── Models/
│   ├── CampusEvent.cs         # Event model
│   ├── Club.cs                # Club model
│   └── ScheduleEntry.cs       # Schedule entry model
├── Data/
│   └── AppData.cs             # Root serialisation container
├── Services/
│   ├── FileService.cs         # JSON load/save + CSV export
│   ├── ValidationService.cs   # All input validation rules
│   ├── SummaryService.cs      # Dashboard statistics
│   └── SampleDataService.cs   # Demo data seeder
└── Forms/
    └── MainForm.cs            # Full Windows Forms UI
```

---

## Run

```bash
cd CampusLife
dotnet restore
dotnet run
```

Or build a release executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

---

## Features

### Events Tab
- Add / Modify / Delete campus events
- Fields: name, date/time, location, category, description
- Today's events are highlighted in yellow
- Search by name, location, category, or date

### Clubs Tab
- Add clubs with category and meeting schedule
- Join / Leave toggle (joined clubs shown in green)
- Modify and delete clubs
- Search by name or category

### Schedule Tab
- Add personal schedule entries with start/end times
- **Conflict detection** – warns if a new entry overlaps an existing one
- Search by title, location, or day

### Dashboard Tab
- Total events, upcoming events, joined clubs, schedule count
- Notifications for today's events
- Next upcoming event highlighted

### File Menu
- **New System** – clears all data
- **Load Data** – open a `.json` file
- **Save / Save As** – save to `.json`
- **Export Events CSV** – events as `.csv`
- **Export Schedule CSV** – schedule as `.csv`
- Prompts to save unsaved changes on exit

---

## OOP Design

| Principle | Where Applied |
|-----------|---------------|
| Encapsulation | All models use properties with getters/setters |
| Separation of Concerns | Models / Services / Forms split |
| Single Responsibility | Each service class has one job |
| DRY | Shared helper factories (`MakeButton`, `MakeGrid`) |

---

## Data Storage

Data is stored as **JSON** using `Newtonsoft.Json`.  
CSV export is available for events and schedule via the File menu.

---

## Group Members

| Name | Student ID |
|------|------------|
|      |            |
|      |            |
|      |            |
|      |            |
