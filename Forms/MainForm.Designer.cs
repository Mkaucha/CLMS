using System.Security.Policy;
namespace CampusLife.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // ── Shell ────────────────────────────────────────────────────────────────
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportEventsCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportScheduleCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.TabControl tabControl1;

        // ── Events tab ───────────────────────────────────────────────────────────
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TableLayoutPanel tblEvents;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventDateTime;
        private System.Windows.Forms.Label lblEventCategory;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.Label lblEventDesc;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventDateTime;
        private System.Windows.Forms.ComboBox cmbEventCategory;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.TextBox txtEventDesc;
        private System.Windows.Forms.FlowLayoutPanel flpEventButtons;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnModifyEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnSearchEvent;
        private System.Windows.Forms.Button btnClearEventFilter;
        private System.Windows.Forms.Panel pnlEventSearch;
        private System.Windows.Forms.TextBox txtEventSearch;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventDesc;

        // ── Clubs tab ────────────────────────────────────────────────────────────
        private System.Windows.Forms.TabPage tabPageClubs;
        private System.Windows.Forms.TableLayoutPanel tblClubs;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClubCategory;
        private System.Windows.Forms.Label lblClubSchedule;
        private System.Windows.Forms.Label lblClubDesc;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.TextBox txtClubCategory;
        private System.Windows.Forms.TextBox txtClubSchedule;
        private System.Windows.Forms.TextBox txtClubDesc;
        private System.Windows.Forms.FlowLayoutPanel flpClubButtons;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Button btnJoinClub;
        private System.Windows.Forms.Button btnModifyClub;
        private System.Windows.Forms.Button btnDeleteClub;
        private System.Windows.Forms.Button btnSearchClub;
        private System.Windows.Forms.Button btnClearClubFilter;
        private System.Windows.Forms.Panel pnlClubSearch;
        private System.Windows.Forms.TextBox txtClubSearch;
        private System.Windows.Forms.DataGridView dgvClubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClubId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClubSchedule;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClubJoined;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClubDesc;

        // ── Schedule tab ─────────────────────────────────────────────────────────
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.TableLayoutPanel tblSchedule;
        private System.Windows.Forms.Label lblSchedTitle;
        private System.Windows.Forms.Label lblSchedStart;
        private System.Windows.Forms.Label lblSchedEnd;
        private System.Windows.Forms.Label lblSchedDay;
        private System.Windows.Forms.Label lblSchedLocation;
        private System.Windows.Forms.Label lblSchedNotes;
        private System.Windows.Forms.TextBox txtSchedTitle;
        private System.Windows.Forms.TextBox txtSchedStart;
        private System.Windows.Forms.TextBox txtSchedEnd;
        private System.Windows.Forms.ComboBox cmbSchedDay;
        private System.Windows.Forms.TextBox txtSchedLocation;
        private System.Windows.Forms.TextBox txtSchedNotes;
        private System.Windows.Forms.FlowLayoutPanel flpSchedButtons;
        private System.Windows.Forms.Button btnAddSched;
        private System.Windows.Forms.Button btnModifySched;
        private System.Windows.Forms.Button btnDeleteSched;
        private System.Windows.Forms.Button btnSearchSched;
        private System.Windows.Forms.Button btnClearSchedFilter;
        private System.Windows.Forms.Panel pnlSchedSearch;
        private System.Windows.Forms.TextBox txtSchedSearch;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedNotes;

        // ── Dashboard tab ─────────────────────────────────────────────────────────
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.FlowLayoutPanel flpDashButtons;
        private System.Windows.Forms.Button btnRefreshDash;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newSystemToolStripMenuItem = new ToolStripMenuItem();
            loadDataToolStripMenuItem = new ToolStripMenuItem();
            saveDataToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exportEventsCSVToolStripMenuItem = new ToolStripMenuItem();
            exportScheduleCSVToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPageEvents = new TabPage();
            dgvEvents = new DataGridView();
            colEventId = new DataGridViewTextBoxColumn();
            colEventName = new DataGridViewTextBoxColumn();
            colEventDateTime = new DataGridViewTextBoxColumn();
            colEventLocation = new DataGridViewTextBoxColumn();
            colEventCategory = new DataGridViewTextBoxColumn();
            colEventDesc = new DataGridViewTextBoxColumn();
            pnlEventSearch = new Panel();
            txtEventSearch = new TextBox();
            flpEventButtons = new FlowLayoutPanel();
            btnAddEvent = new Button();
            btnModifyEvent = new Button();
            btnDeleteEvent = new Button();
            btnSearchEvent = new Button();
            btnClearEventFilter = new Button();
            tblEvents = new TableLayoutPanel();
            lblEventName = new Label();
            lblEventDateTime = new Label();
            lblEventCategory = new Label();
            lblEventLocation = new Label();
            txtEventName = new TextBox();
            txtEventDateTime = new TextBox();
            cmbEventCategory = new ComboBox();
            txtEventLocation = new TextBox();
            lblEventDesc = new Label();
            txtEventDesc = new TextBox();
            tabPageClubs = new TabPage();
            dgvClubs = new DataGridView();
            colClubId = new DataGridViewTextBoxColumn();
            colClubName = new DataGridViewTextBoxColumn();
            colClubCategory = new DataGridViewTextBoxColumn();
            colClubSchedule = new DataGridViewTextBoxColumn();
            colClubJoined = new DataGridViewCheckBoxColumn();
            colClubDesc = new DataGridViewTextBoxColumn();
            pnlClubSearch = new Panel();
            txtClubSearch = new TextBox();
            flpClubButtons = new FlowLayoutPanel();
            btnAddClub = new Button();
            btnJoinClub = new Button();
            btnModifyClub = new Button();
            btnDeleteClub = new Button();
            btnSearchClub = new Button();
            btnClearClubFilter = new Button();
            tblClubs = new TableLayoutPanel();
            lblClubName = new Label();
            lblClubCategory = new Label();
            txtClubName = new TextBox();
            txtClubCategory = new TextBox();
            lblClubSchedule = new Label();
            lblClubDesc = new Label();
            txtClubSchedule = new TextBox();
            txtClubDesc = new TextBox();
            tabPageSchedule = new TabPage();
            dgvSchedule = new DataGridView();
            colSchedId = new DataGridViewTextBoxColumn();
            colSchedTitle = new DataGridViewTextBoxColumn();
            colSchedStart = new DataGridViewTextBoxColumn();
            colSchedEnd = new DataGridViewTextBoxColumn();
            colSchedDay = new DataGridViewTextBoxColumn();
            colSchedLocation = new DataGridViewTextBoxColumn();
            colSchedNotes = new DataGridViewTextBoxColumn();
            pnlSchedSearch = new Panel();
            txtSchedSearch = new TextBox();
            flpSchedButtons = new FlowLayoutPanel();
            btnAddSched = new Button();
            btnModifySched = new Button();
            btnDeleteSched = new Button();
            btnSearchSched = new Button();
            btnClearSchedFilter = new Button();
            tblSchedule = new TableLayoutPanel();
            lblSchedTitle = new Label();
            lblSchedStart = new Label();
            lblSchedEnd = new Label();
            lblSchedDay = new Label();
            txtSchedTitle = new TextBox();
            txtSchedStart = new TextBox();
            txtSchedEnd = new TextBox();
            cmbSchedDay = new ComboBox();
            lblSchedLocation = new Label();
            lblSchedNotes = new Label();
            txtSchedLocation = new TextBox();
            txtSchedNotes = new TextBox();
            tabPageDashboard = new TabPage();
            rtbSummary = new RichTextBox();
            flpDashButtons = new FlowLayoutPanel();
            btnRefreshDash = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            pnlEventSearch.SuspendLayout();
            flpEventButtons.SuspendLayout();
            tblEvents.SuspendLayout();
            tabPageClubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            pnlClubSearch.SuspendLayout();
            flpClubButtons.SuspendLayout();
            tblClubs.SuspendLayout();
            tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            pnlSchedSearch.SuspendLayout();
            flpSchedButtons.SuspendLayout();
            tblSchedule.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            flpDashButtons.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(30, 80, 162);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 28);
            menuStrip1.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newSystemToolStripMenuItem, loadDataToolStripMenuItem, saveDataToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exportEventsCSVToolStripMenuItem, exportScheduleCSVToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newSystemToolStripMenuItem
            // 
            newSystemToolStripMenuItem.Name = "newSystemToolStripMenuItem";
            newSystemToolStripMenuItem.Size = new Size(238, 26);
            newSystemToolStripMenuItem.Text = "&New System";
            newSystemToolStripMenuItem.Click += OnNew;
            // 
            // loadDataToolStripMenuItem
            // 
            loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            loadDataToolStripMenuItem.Size = new Size(238, 26);
            loadDataToolStripMenuItem.Text = "&Load Data...";
            loadDataToolStripMenuItem.Click += OnLoad;
            // 
            // saveDataToolStripMenuItem
            // 
            saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            saveDataToolStripMenuItem.Size = new Size(238, 26);
            saveDataToolStripMenuItem.Text = "&Save Data";
            saveDataToolStripMenuItem.Click += OnSave;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(238, 26);
            saveAsToolStripMenuItem.Text = "Save &As...";
            saveAsToolStripMenuItem.Click += OnSaveAs;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(235, 6);
            // 
            // exportEventsCSVToolStripMenuItem
            // 
            exportEventsCSVToolStripMenuItem.Name = "exportEventsCSVToolStripMenuItem";
            exportEventsCSVToolStripMenuItem.Size = new Size(238, 26);
            exportEventsCSVToolStripMenuItem.Text = "Export Events CSV...";
            exportEventsCSVToolStripMenuItem.Click += OnExportEventsCsv;
            // 
            // exportScheduleCSVToolStripMenuItem
            // 
            exportScheduleCSVToolStripMenuItem.Name = "exportScheduleCSVToolStripMenuItem";
            exportScheduleCSVToolStripMenuItem.Size = new Size(238, 26);
            exportScheduleCSVToolStripMenuItem.Text = "Export Schedule CSV...";
            exportScheduleCSVToolStripMenuItem.Click += OnExportScheduleCsv;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(235, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(238, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += OnAbout;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(30, 80, 162);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 674);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 26);
            statusStrip1.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.White;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(1085, 20);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "  Ready";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageEvents);
            tabControl1.Controls.Add(tabPageClubs);
            tabControl1.Controls.Add(tabPageSchedule);
            tabControl1.Controls.Add(tabPageDashboard);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(12, 6);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1100, 646);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabPageEvents
            // 
            tabPageEvents.Controls.Add(dgvEvents);
            tabPageEvents.Controls.Add(pnlEventSearch);
            tabPageEvents.Controls.Add(flpEventButtons);
            tabPageEvents.Controls.Add(tblEvents);
            tabPageEvents.Location = new Point(4, 38);
            tabPageEvents.Name = "tabPageEvents";
            tabPageEvents.Size = new Size(1092, 604);
            tabPageEvents.TabIndex = 0;
            tabPageEvents.Text = "Events";
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 255);
            dgvEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvents.BackgroundColor = Color.White;
            dgvEvents.ColumnHeadersHeight = 29;
            dgvEvents.Columns.AddRange(new DataGridViewColumn[] { colEventId, colEventName, colEventDateTime, colEventLocation, colEventCategory, colEventDesc });
            dgvEvents.Dock = DockStyle.Fill;
            dgvEvents.Location = new Point(0, 204);
            dgvEvents.MultiSelect = false;
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersVisible = false;
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvents.Size = new Size(1092, 400);
            dgvEvents.TabIndex = 0;
            dgvEvents.SelectionChanged += OnEventSelected;
            // 
            // colEventId
            // 
            colEventId.MinimumWidth = 6;
            colEventId.Name = "colEventId";
            colEventId.ReadOnly = true;
            colEventId.Visible = false;
            colEventId.Width = 125;
            // 
            // colEventName
            // 
            colEventName.HeaderText = "Event";
            colEventName.MinimumWidth = 6;
            colEventName.Name = "colEventName";
            colEventName.ReadOnly = true;
            colEventName.Width = 200;
            // 
            // colEventDateTime
            // 
            colEventDateTime.HeaderText = "Date / Time";
            colEventDateTime.MinimumWidth = 6;
            colEventDateTime.Name = "colEventDateTime";
            colEventDateTime.ReadOnly = true;
            colEventDateTime.Width = 150;
            // 
            // colEventLocation
            // 
            colEventLocation.HeaderText = "Location";
            colEventLocation.MinimumWidth = 6;
            colEventLocation.Name = "colEventLocation";
            colEventLocation.ReadOnly = true;
            colEventLocation.Width = 160;
            // 
            // colEventCategory
            // 
            colEventCategory.HeaderText = "Category";
            colEventCategory.MinimumWidth = 6;
            colEventCategory.Name = "colEventCategory";
            colEventCategory.ReadOnly = true;
            colEventCategory.Width = 110;
            // 
            // colEventDesc
            // 
            colEventDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEventDesc.HeaderText = "Description";
            colEventDesc.MinimumWidth = 6;
            colEventDesc.Name = "colEventDesc";
            colEventDesc.ReadOnly = true;
            // 
            // pnlEventSearch
            // 
            pnlEventSearch.BackColor = Color.FromArgb(245, 247, 250);
            pnlEventSearch.Controls.Add(txtEventSearch);
            pnlEventSearch.Dock = DockStyle.Top;
            pnlEventSearch.Location = new Point(0, 172);
            pnlEventSearch.Name = "pnlEventSearch";
            pnlEventSearch.Padding = new Padding(6, 3, 6, 3);
            pnlEventSearch.Size = new Size(1092, 32);
            pnlEventSearch.TabIndex = 1;
            // 
            // txtEventSearch
            // 
            txtEventSearch.Dock = DockStyle.Fill;
            txtEventSearch.Location = new Point(6, 3);
            txtEventSearch.Name = "txtEventSearch";
            txtEventSearch.PlaceholderText = "Search events by name, location or category...";
            txtEventSearch.Size = new Size(1080, 30);
            txtEventSearch.TabIndex = 0;
            txtEventSearch.KeyDown += TxtEventSearch_KeyDown;
            // 
            // flpEventButtons
            // 
            flpEventButtons.BackColor = Color.FromArgb(235, 240, 250);
            flpEventButtons.Controls.Add(btnAddEvent);
            flpEventButtons.Controls.Add(btnModifyEvent);
            flpEventButtons.Controls.Add(btnDeleteEvent);
            flpEventButtons.Controls.Add(btnSearchEvent);
            flpEventButtons.Controls.Add(btnClearEventFilter);
            flpEventButtons.Dock = DockStyle.Top;
            flpEventButtons.Location = new Point(0, 130);
            flpEventButtons.Name = "flpEventButtons";
            flpEventButtons.Padding = new Padding(6, 5, 6, 0);
            flpEventButtons.Size = new Size(1092, 42);
            flpEventButtons.TabIndex = 2;
            flpEventButtons.WrapContents = false;
            // 
            // btnAddEvent
            // 
            btnAddEvent.AutoSize = true;
            btnAddEvent.BackColor = Color.FromArgb(30, 140, 70);
            btnAddEvent.FlatAppearance.BorderSize = 0;
            btnAddEvent.FlatStyle = FlatStyle.Flat;
            btnAddEvent.ForeColor = Color.White;
            btnAddEvent.Location = new Point(9, 8);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(98, 33);
            btnAddEvent.TabIndex = 0;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += OnAddEvent;
            // 
            // btnModifyEvent
            // 
            btnModifyEvent.AutoSize = true;
            btnModifyEvent.BackColor = Color.FromArgb(30, 100, 180);
            btnModifyEvent.FlatAppearance.BorderSize = 0;
            btnModifyEvent.FlatStyle = FlatStyle.Flat;
            btnModifyEvent.ForeColor = Color.White;
            btnModifyEvent.Location = new Point(113, 8);
            btnModifyEvent.Name = "btnModifyEvent";
            btnModifyEvent.Size = new Size(75, 33);
            btnModifyEvent.TabIndex = 1;
            btnModifyEvent.Text = "Modify";
            btnModifyEvent.UseVisualStyleBackColor = false;
            btnModifyEvent.Click += OnModifyEvent;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.AutoSize = true;
            btnDeleteEvent.BackColor = Color.FromArgb(180, 40, 40);
            btnDeleteEvent.FlatAppearance.BorderSize = 0;
            btnDeleteEvent.FlatStyle = FlatStyle.Flat;
            btnDeleteEvent.ForeColor = Color.White;
            btnDeleteEvent.Location = new Point(194, 8);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(75, 33);
            btnDeleteEvent.TabIndex = 2;
            btnDeleteEvent.Text = "Delete";
            btnDeleteEvent.UseVisualStyleBackColor = false;
            btnDeleteEvent.Click += OnDeleteEvent;
            // 
            // btnSearchEvent
            // 
            btnSearchEvent.AutoSize = true;
            btnSearchEvent.BackColor = Color.FromArgb(100, 80, 160);
            btnSearchEvent.FlatAppearance.BorderSize = 0;
            btnSearchEvent.FlatStyle = FlatStyle.Flat;
            btnSearchEvent.ForeColor = Color.White;
            btnSearchEvent.Location = new Point(275, 8);
            btnSearchEvent.Name = "btnSearchEvent";
            btnSearchEvent.Size = new Size(75, 33);
            btnSearchEvent.TabIndex = 3;
            btnSearchEvent.Text = "Search";
            btnSearchEvent.UseVisualStyleBackColor = false;
            btnSearchEvent.Click += OnSearchEvents;
            // 
            // btnClearEventFilter
            // 
            btnClearEventFilter.AutoSize = true;
            btnClearEventFilter.BackColor = Color.FromArgb(90, 90, 90);
            btnClearEventFilter.FlatAppearance.BorderSize = 0;
            btnClearEventFilter.FlatStyle = FlatStyle.Flat;
            btnClearEventFilter.ForeColor = Color.White;
            btnClearEventFilter.Location = new Point(356, 8);
            btnClearEventFilter.Name = "btnClearEventFilter";
            btnClearEventFilter.Size = new Size(101, 33);
            btnClearEventFilter.TabIndex = 4;
            btnClearEventFilter.Text = "Clear Filter";
            btnClearEventFilter.UseVisualStyleBackColor = false;
            btnClearEventFilter.Click += BtnClearEventFilter_Click;
            // 
            // tblEvents
            // 
            tblEvents.BackColor = Color.White;
            tblEvents.ColumnCount = 4;
            tblEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tblEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tblEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblEvents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tblEvents.Controls.Add(lblEventName, 0, 0);
            tblEvents.Controls.Add(lblEventDateTime, 1, 0);
            tblEvents.Controls.Add(lblEventCategory, 2, 0);
            tblEvents.Controls.Add(lblEventLocation, 3, 0);
            tblEvents.Controls.Add(txtEventName, 0, 1);
            tblEvents.Controls.Add(txtEventDateTime, 1, 1);
            tblEvents.Controls.Add(cmbEventCategory, 2, 1);
            tblEvents.Controls.Add(txtEventLocation, 3, 1);
            tblEvents.Controls.Add(lblEventDesc, 0, 2);
            tblEvents.Controls.Add(txtEventDesc, 0, 3);
            tblEvents.Dock = DockStyle.Top;
            tblEvents.Location = new Point(0, 0);
            tblEvents.Name = "tblEvents";
            tblEvents.Padding = new Padding(6);
            tblEvents.RowCount = 4;
            tblEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblEvents.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblEvents.Size = new Size(1092, 130);
            tblEvents.TabIndex = 3;
            // 
            // lblEventName
            // 
            lblEventName.AutoSize = true;
            lblEventName.ForeColor = Color.FromArgb(70, 80, 100);
            lblEventName.Location = new Point(9, 6);
            lblEventName.Name = "lblEventName";
            lblEventName.Size = new Size(115, 20);
            lblEventName.TabIndex = 0;
            lblEventName.Text = "Event Name *";
            lblEventName.Click += lblEventName_Click;
            // 
            // lblEventDateTime
            // 
            lblEventDateTime.AutoSize = true;
            lblEventDateTime.ForeColor = Color.FromArgb(70, 80, 100);
            lblEventDateTime.Location = new Point(311, 6);
            lblEventDateTime.Name = "lblEventDateTime";
            lblEventDateTime.Size = new Size(105, 20);
            lblEventDateTime.TabIndex = 1;
            lblEventDateTime.Text = "Date & Time *";
            // 
            // lblEventCategory
            // 
            lblEventCategory.AutoSize = true;
            lblEventCategory.ForeColor = Color.FromArgb(70, 80, 100);
            lblEventCategory.Location = new Point(570, 6);
            lblEventCategory.Name = "lblEventCategory";
            lblEventCategory.Size = new Size(79, 20);
            lblEventCategory.TabIndex = 2;
            lblEventCategory.Text = "Category";
            // 
            // lblEventLocation
            // 
            lblEventLocation.AutoSize = true;
            lblEventLocation.ForeColor = Color.FromArgb(70, 80, 100);
            lblEventLocation.Location = new Point(786, 6);
            lblEventLocation.Name = "lblEventLocation";
            lblEventLocation.Size = new Size(87, 20);
            lblEventLocation.TabIndex = 3;
            lblEventLocation.Text = "Location *";
            // 
            // txtEventName
            // 
            txtEventName.Dock = DockStyle.Fill;
            txtEventName.Location = new Point(9, 29);
            txtEventName.Name = "txtEventName";
            txtEventName.PlaceholderText = "Event name *";
            txtEventName.Size = new Size(296, 30);
            txtEventName.TabIndex = 4;
            // 
            // txtEventDateTime
            // 
            txtEventDateTime.Dock = DockStyle.Fill;
            txtEventDateTime.Location = new Point(311, 29);
            txtEventDateTime.Name = "txtEventDateTime";
            txtEventDateTime.PlaceholderText = "e.g. 29/05/2026 14:00";
            txtEventDateTime.Size = new Size(253, 30);
            txtEventDateTime.TabIndex = 5;
            // 
            // cmbEventCategory
            // 
            cmbEventCategory.Dock = DockStyle.Fill;
            cmbEventCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEventCategory.Items.AddRange(new object[] { "General", "Academic", "Technology", "Arts", "Sports", "Career", "Community" });
            cmbEventCategory.Location = new Point(570, 29);
            cmbEventCategory.Name = "cmbEventCategory";
            cmbEventCategory.Size = new Size(210, 31);
            cmbEventCategory.TabIndex = 6;
            // 
            // txtEventLocation
            // 
            txtEventLocation.Dock = DockStyle.Fill;
            txtEventLocation.Location = new Point(786, 29);
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.PlaceholderText = "Location *";
            txtEventLocation.Size = new Size(297, 30);
            txtEventLocation.TabIndex = 7;
            // 
            // lblEventDesc
            // 
            lblEventDesc.AutoSize = true;
            tblEvents.SetColumnSpan(lblEventDesc, 4);
            lblEventDesc.ForeColor = Color.FromArgb(70, 80, 100);
            lblEventDesc.Location = new Point(9, 54);
            lblEventDesc.Name = "lblEventDesc";
            lblEventDesc.Size = new Size(96, 20);
            lblEventDesc.TabIndex = 8;
            lblEventDesc.Text = "Description";
            // 
            // txtEventDesc
            // 
            tblEvents.SetColumnSpan(txtEventDesc, 4);
            txtEventDesc.Dock = DockStyle.Fill;
            txtEventDesc.Location = new Point(9, 77);
            txtEventDesc.Name = "txtEventDesc";
            txtEventDesc.PlaceholderText = "Description (optional)";
            txtEventDesc.Size = new Size(1074, 30);
            txtEventDesc.TabIndex = 9;
            // 
            // tabPageClubs
            // 
            tabPageClubs.Controls.Add(dgvClubs);
            tabPageClubs.Controls.Add(pnlClubSearch);
            tabPageClubs.Controls.Add(flpClubButtons);
            tabPageClubs.Controls.Add(tblClubs);
            tabPageClubs.Location = new Point(4, 38);
            tabPageClubs.Name = "tabPageClubs";
            tabPageClubs.Size = new Size(1092, 604);
            tabPageClubs.TabIndex = 1;
            tabPageClubs.Text = "Clubs";
            // 
            // dgvClubs
            // 
            dgvClubs.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 255);
            dgvClubs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvClubs.BackgroundColor = Color.White;
            dgvClubs.ColumnHeadersHeight = 29;
            dgvClubs.Columns.AddRange(new DataGridViewColumn[] { colClubId, colClubName, colClubCategory, colClubSchedule, colClubJoined, colClubDesc });
            dgvClubs.Dock = DockStyle.Fill;
            dgvClubs.Location = new Point(0, 204);
            dgvClubs.MultiSelect = false;
            dgvClubs.Name = "dgvClubs";
            dgvClubs.ReadOnly = true;
            dgvClubs.RowHeadersVisible = false;
            dgvClubs.RowHeadersWidth = 51;
            dgvClubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClubs.Size = new Size(1092, 400);
            dgvClubs.TabIndex = 0;
            dgvClubs.SelectionChanged += OnClubSelected;
            // 
            // colClubId
            // 
            colClubId.MinimumWidth = 6;
            colClubId.Name = "colClubId";
            colClubId.ReadOnly = true;
            colClubId.Visible = false;
            colClubId.Width = 125;
            // 
            // colClubName
            // 
            colClubName.HeaderText = "Club";
            colClubName.MinimumWidth = 6;
            colClubName.Name = "colClubName";
            colClubName.ReadOnly = true;
            colClubName.Width = 200;
            // 
            // colClubCategory
            // 
            colClubCategory.HeaderText = "Category";
            colClubCategory.MinimumWidth = 6;
            colClubCategory.Name = "colClubCategory";
            colClubCategory.ReadOnly = true;
            colClubCategory.Width = 120;
            // 
            // colClubSchedule
            // 
            colClubSchedule.HeaderText = "Meeting Schedule";
            colClubSchedule.MinimumWidth = 6;
            colClubSchedule.Name = "colClubSchedule";
            colClubSchedule.ReadOnly = true;
            colClubSchedule.Width = 220;
            // 
            // colClubJoined
            // 
            colClubJoined.HeaderText = "Joined";
            colClubJoined.MinimumWidth = 6;
            colClubJoined.Name = "colClubJoined";
            colClubJoined.ReadOnly = true;
            colClubJoined.Width = 65;
            // 
            // colClubDesc
            // 
            colClubDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colClubDesc.HeaderText = "Description";
            colClubDesc.MinimumWidth = 6;
            colClubDesc.Name = "colClubDesc";
            colClubDesc.ReadOnly = true;
            // 
            // pnlClubSearch
            // 
            pnlClubSearch.BackColor = Color.FromArgb(245, 247, 250);
            pnlClubSearch.Controls.Add(txtClubSearch);
            pnlClubSearch.Dock = DockStyle.Top;
            pnlClubSearch.Location = new Point(0, 172);
            pnlClubSearch.Name = "pnlClubSearch";
            pnlClubSearch.Padding = new Padding(6, 3, 6, 3);
            pnlClubSearch.Size = new Size(1092, 32);
            pnlClubSearch.TabIndex = 1;
            // 
            // txtClubSearch
            // 
            txtClubSearch.Dock = DockStyle.Fill;
            txtClubSearch.Location = new Point(6, 3);
            txtClubSearch.Name = "txtClubSearch";
            txtClubSearch.PlaceholderText = "Search clubs by name or category...";
            txtClubSearch.Size = new Size(1080, 30);
            txtClubSearch.TabIndex = 0;
            txtClubSearch.KeyDown += TxtClubSearch_KeyDown;
            // 
            // flpClubButtons
            // 
            flpClubButtons.BackColor = Color.FromArgb(235, 240, 250);
            flpClubButtons.Controls.Add(btnAddClub);
            flpClubButtons.Controls.Add(btnJoinClub);
            flpClubButtons.Controls.Add(btnModifyClub);
            flpClubButtons.Controls.Add(btnDeleteClub);
            flpClubButtons.Controls.Add(btnSearchClub);
            flpClubButtons.Controls.Add(btnClearClubFilter);
            flpClubButtons.Dock = DockStyle.Top;
            flpClubButtons.Location = new Point(0, 130);
            flpClubButtons.Name = "flpClubButtons";
            flpClubButtons.Padding = new Padding(6, 5, 6, 0);
            flpClubButtons.Size = new Size(1092, 42);
            flpClubButtons.TabIndex = 2;
            flpClubButtons.WrapContents = false;
            // 
            // btnAddClub
            // 
            btnAddClub.AutoSize = true;
            btnAddClub.BackColor = Color.FromArgb(30, 140, 70);
            btnAddClub.FlatAppearance.BorderSize = 0;
            btnAddClub.FlatStyle = FlatStyle.Flat;
            btnAddClub.ForeColor = Color.White;
            btnAddClub.Location = new Point(9, 8);
            btnAddClub.Name = "btnAddClub";
            btnAddClub.Size = new Size(91, 33);
            btnAddClub.TabIndex = 0;
            btnAddClub.Text = "Add Club";
            btnAddClub.UseVisualStyleBackColor = false;
            btnAddClub.Click += OnAddClub;
            // 
            // btnJoinClub
            // 
            btnJoinClub.AutoSize = true;
            btnJoinClub.BackColor = Color.FromArgb(30, 130, 130);
            btnJoinClub.FlatAppearance.BorderSize = 0;
            btnJoinClub.FlatStyle = FlatStyle.Flat;
            btnJoinClub.ForeColor = Color.White;
            btnJoinClub.Location = new Point(106, 8);
            btnJoinClub.Name = "btnJoinClub";
            btnJoinClub.Size = new Size(100, 33);
            btnJoinClub.TabIndex = 1;
            btnJoinClub.Text = "Join/Leave";
            btnJoinClub.UseVisualStyleBackColor = false;
            btnJoinClub.Click += OnJoinClub;
            // 
            // btnModifyClub
            // 
            btnModifyClub.AutoSize = true;
            btnModifyClub.BackColor = Color.FromArgb(30, 100, 180);
            btnModifyClub.FlatAppearance.BorderSize = 0;
            btnModifyClub.FlatStyle = FlatStyle.Flat;
            btnModifyClub.ForeColor = Color.White;
            btnModifyClub.Location = new Point(212, 8);
            btnModifyClub.Name = "btnModifyClub";
            btnModifyClub.Size = new Size(75, 33);
            btnModifyClub.TabIndex = 2;
            btnModifyClub.Text = "Modify";
            btnModifyClub.UseVisualStyleBackColor = false;
            btnModifyClub.Click += OnModifyClub;
            // 
            // btnDeleteClub
            // 
            btnDeleteClub.AutoSize = true;
            btnDeleteClub.BackColor = Color.FromArgb(180, 40, 40);
            btnDeleteClub.FlatAppearance.BorderSize = 0;
            btnDeleteClub.FlatStyle = FlatStyle.Flat;
            btnDeleteClub.ForeColor = Color.White;
            btnDeleteClub.Location = new Point(293, 8);
            btnDeleteClub.Name = "btnDeleteClub";
            btnDeleteClub.Size = new Size(75, 33);
            btnDeleteClub.TabIndex = 3;
            btnDeleteClub.Text = "Delete";
            btnDeleteClub.UseVisualStyleBackColor = false;
            btnDeleteClub.Click += OnDeleteClub;
            // 
            // btnSearchClub
            // 
            btnSearchClub.AutoSize = true;
            btnSearchClub.BackColor = Color.FromArgb(100, 80, 160);
            btnSearchClub.FlatAppearance.BorderSize = 0;
            btnSearchClub.FlatStyle = FlatStyle.Flat;
            btnSearchClub.ForeColor = Color.White;
            btnSearchClub.Location = new Point(374, 8);
            btnSearchClub.Name = "btnSearchClub";
            btnSearchClub.Size = new Size(75, 33);
            btnSearchClub.TabIndex = 4;
            btnSearchClub.Text = "Search";
            btnSearchClub.UseVisualStyleBackColor = false;
            btnSearchClub.Click += OnSearchClubs;
            // 
            // btnClearClubFilter
            // 
            btnClearClubFilter.AutoSize = true;
            btnClearClubFilter.BackColor = Color.FromArgb(90, 90, 90);
            btnClearClubFilter.FlatAppearance.BorderSize = 0;
            btnClearClubFilter.FlatStyle = FlatStyle.Flat;
            btnClearClubFilter.ForeColor = Color.White;
            btnClearClubFilter.Location = new Point(455, 8);
            btnClearClubFilter.Name = "btnClearClubFilter";
            btnClearClubFilter.Size = new Size(101, 33);
            btnClearClubFilter.TabIndex = 5;
            btnClearClubFilter.Text = "Clear Filter";
            btnClearClubFilter.UseVisualStyleBackColor = false;
            btnClearClubFilter.Click += BtnClearClubFilter_Click;
            // 
            // tblClubs
            // 
            tblClubs.BackColor = Color.White;
            tblClubs.ColumnCount = 2;
            tblClubs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblClubs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblClubs.Controls.Add(lblClubName, 0, 0);
            tblClubs.Controls.Add(lblClubCategory, 1, 0);
            tblClubs.Controls.Add(txtClubName, 0, 1);
            tblClubs.Controls.Add(txtClubCategory, 1, 1);
            tblClubs.Controls.Add(lblClubSchedule, 0, 2);
            tblClubs.Controls.Add(lblClubDesc, 1, 2);
            tblClubs.Controls.Add(txtClubSchedule, 0, 3);
            tblClubs.Controls.Add(txtClubDesc, 1, 3);
            tblClubs.Dock = DockStyle.Top;
            tblClubs.Location = new Point(0, 0);
            tblClubs.Name = "tblClubs";
            tblClubs.Padding = new Padding(6);
            tblClubs.RowCount = 4;
            tblClubs.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblClubs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblClubs.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblClubs.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblClubs.Size = new Size(1092, 130);
            tblClubs.TabIndex = 3;
            // 
            // lblClubName
            // 
            lblClubName.AutoSize = true;
            lblClubName.ForeColor = Color.FromArgb(70, 80, 100);
            lblClubName.Location = new Point(9, 6);
            lblClubName.Name = "lblClubName";
            lblClubName.Size = new Size(108, 20);
            lblClubName.TabIndex = 0;
            lblClubName.Text = "Club Name *";
            // 
            // lblClubCategory
            // 
            lblClubCategory.AutoSize = true;
            lblClubCategory.ForeColor = Color.FromArgb(70, 80, 100);
            lblClubCategory.Location = new Point(549, 6);
            lblClubCategory.Name = "lblClubCategory";
            lblClubCategory.Size = new Size(91, 20);
            lblClubCategory.TabIndex = 1;
            lblClubCategory.Text = "Category *";
            // 
            // txtClubName
            // 
            txtClubName.Dock = DockStyle.Fill;
            txtClubName.Location = new Point(9, 29);
            txtClubName.Name = "txtClubName";
            txtClubName.PlaceholderText = "Club name *";
            txtClubName.Size = new Size(534, 30);
            txtClubName.TabIndex = 2;
            // 
            // txtClubCategory
            // 
            txtClubCategory.Dock = DockStyle.Fill;
            txtClubCategory.Location = new Point(549, 29);
            txtClubCategory.Name = "txtClubCategory";
            txtClubCategory.PlaceholderText = "e.g. Technology";
            txtClubCategory.Size = new Size(534, 30);
            txtClubCategory.TabIndex = 3;
            // 
            // lblClubSchedule
            // 
            lblClubSchedule.AutoSize = true;
            lblClubSchedule.ForeColor = Color.FromArgb(70, 80, 100);
            lblClubSchedule.Location = new Point(9, 54);
            lblClubSchedule.Name = "lblClubSchedule";
            lblClubSchedule.Size = new Size(147, 20);
            lblClubSchedule.TabIndex = 4;
            lblClubSchedule.Text = "Meeting Schedule";
            // 
            // lblClubDesc
            // 
            lblClubDesc.AutoSize = true;
            lblClubDesc.ForeColor = Color.FromArgb(70, 80, 100);
            lblClubDesc.Location = new Point(549, 54);
            lblClubDesc.Name = "lblClubDesc";
            lblClubDesc.Size = new Size(96, 20);
            lblClubDesc.TabIndex = 5;
            lblClubDesc.Text = "Description";
            // 
            // txtClubSchedule
            // 
            txtClubSchedule.Dock = DockStyle.Fill;
            txtClubSchedule.Location = new Point(9, 77);
            txtClubSchedule.Name = "txtClubSchedule";
            txtClubSchedule.PlaceholderText = "e.g. Every Wed 5 PM - Room CS-204";
            txtClubSchedule.Size = new Size(534, 30);
            txtClubSchedule.TabIndex = 6;
            // 
            // txtClubDesc
            // 
            txtClubDesc.Dock = DockStyle.Fill;
            txtClubDesc.Location = new Point(549, 77);
            txtClubDesc.Name = "txtClubDesc";
            txtClubDesc.PlaceholderText = "Description";
            txtClubDesc.Size = new Size(534, 30);
            txtClubDesc.TabIndex = 7;
            // 
            // tabPageSchedule
            // 
            tabPageSchedule.Controls.Add(dgvSchedule);
            tabPageSchedule.Controls.Add(pnlSchedSearch);
            tabPageSchedule.Controls.Add(flpSchedButtons);
            tabPageSchedule.Controls.Add(tblSchedule);
            tabPageSchedule.Location = new Point(4, 38);
            tabPageSchedule.Name = "tabPageSchedule";
            tabPageSchedule.Size = new Size(1092, 604);
            tabPageSchedule.TabIndex = 2;
            tabPageSchedule.Text = "Schedule";
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 255);
            dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSchedule.BackgroundColor = Color.White;
            dgvSchedule.ColumnHeadersHeight = 29;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { colSchedId, colSchedTitle, colSchedStart, colSchedEnd, colSchedDay, colSchedLocation, colSchedNotes });
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(0, 204);
            dgvSchedule.MultiSelect = false;
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Size = new Size(1092, 400);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.SelectionChanged += OnScheduleSelected;
            // 
            // colSchedId
            // 
            colSchedId.MinimumWidth = 6;
            colSchedId.Name = "colSchedId";
            colSchedId.ReadOnly = true;
            colSchedId.Visible = false;
            colSchedId.Width = 125;
            // 
            // colSchedTitle
            // 
            colSchedTitle.HeaderText = "Title";
            colSchedTitle.MinimumWidth = 6;
            colSchedTitle.Name = "colSchedTitle";
            colSchedTitle.ReadOnly = true;
            colSchedTitle.Width = 200;
            // 
            // colSchedStart
            // 
            colSchedStart.HeaderText = "Start";
            colSchedStart.MinimumWidth = 6;
            colSchedStart.Name = "colSchedStart";
            colSchedStart.ReadOnly = true;
            colSchedStart.Width = 140;
            // 
            // colSchedEnd
            // 
            colSchedEnd.HeaderText = "End";
            colSchedEnd.MinimumWidth = 6;
            colSchedEnd.Name = "colSchedEnd";
            colSchedEnd.ReadOnly = true;
            colSchedEnd.Width = 80;
            // 
            // colSchedDay
            // 
            colSchedDay.HeaderText = "Day";
            colSchedDay.MinimumWidth = 6;
            colSchedDay.Name = "colSchedDay";
            colSchedDay.ReadOnly = true;
            colSchedDay.Width = 90;
            // 
            // colSchedLocation
            // 
            colSchedLocation.HeaderText = "Location";
            colSchedLocation.MinimumWidth = 6;
            colSchedLocation.Name = "colSchedLocation";
            colSchedLocation.ReadOnly = true;
            colSchedLocation.Width = 150;
            // 
            // colSchedNotes
            // 
            colSchedNotes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSchedNotes.HeaderText = "Notes";
            colSchedNotes.MinimumWidth = 6;
            colSchedNotes.Name = "colSchedNotes";
            colSchedNotes.ReadOnly = true;
            // 
            // pnlSchedSearch
            // 
            pnlSchedSearch.BackColor = Color.FromArgb(245, 247, 250);
            pnlSchedSearch.Controls.Add(txtSchedSearch);
            pnlSchedSearch.Dock = DockStyle.Top;
            pnlSchedSearch.Location = new Point(0, 172);
            pnlSchedSearch.Name = "pnlSchedSearch";
            pnlSchedSearch.Padding = new Padding(6, 3, 6, 3);
            pnlSchedSearch.Size = new Size(1092, 32);
            pnlSchedSearch.TabIndex = 1;
            // 
            // txtSchedSearch
            // 
            txtSchedSearch.Dock = DockStyle.Fill;
            txtSchedSearch.Location = new Point(6, 3);
            txtSchedSearch.Name = "txtSchedSearch";
            txtSchedSearch.PlaceholderText = "Search schedule by title, location or day...";
            txtSchedSearch.Size = new Size(1080, 30);
            txtSchedSearch.TabIndex = 0;
            txtSchedSearch.KeyDown += TxtSchedSearch_KeyDown;
            // 
            // flpSchedButtons
            // 
            flpSchedButtons.BackColor = Color.FromArgb(235, 240, 250);
            flpSchedButtons.Controls.Add(btnAddSched);
            flpSchedButtons.Controls.Add(btnModifySched);
            flpSchedButtons.Controls.Add(btnDeleteSched);
            flpSchedButtons.Controls.Add(btnSearchSched);
            flpSchedButtons.Controls.Add(btnClearSchedFilter);
            flpSchedButtons.Dock = DockStyle.Top;
            flpSchedButtons.Location = new Point(0, 130);
            flpSchedButtons.Name = "flpSchedButtons";
            flpSchedButtons.Padding = new Padding(6, 5, 6, 0);
            flpSchedButtons.Size = new Size(1092, 42);
            flpSchedButtons.TabIndex = 2;
            flpSchedButtons.WrapContents = false;
            // 
            // btnAddSched
            // 
            btnAddSched.AutoSize = true;
            btnAddSched.BackColor = Color.FromArgb(30, 140, 70);
            btnAddSched.FlatAppearance.BorderSize = 0;
            btnAddSched.FlatStyle = FlatStyle.Flat;
            btnAddSched.ForeColor = Color.White;
            btnAddSched.Location = new Point(9, 8);
            btnAddSched.Name = "btnAddSched";
            btnAddSched.Size = new Size(95, 33);
            btnAddSched.TabIndex = 0;
            btnAddSched.Text = "Add Entry";
            btnAddSched.UseVisualStyleBackColor = false;
            btnAddSched.Click += OnAddSchedule;
            // 
            // btnModifySched
            // 
            btnModifySched.AutoSize = true;
            btnModifySched.BackColor = Color.FromArgb(30, 100, 180);
            btnModifySched.FlatAppearance.BorderSize = 0;
            btnModifySched.FlatStyle = FlatStyle.Flat;
            btnModifySched.ForeColor = Color.White;
            btnModifySched.Location = new Point(110, 8);
            btnModifySched.Name = "btnModifySched";
            btnModifySched.Size = new Size(75, 33);
            btnModifySched.TabIndex = 1;
            btnModifySched.Text = "Modify";
            btnModifySched.UseVisualStyleBackColor = false;
            btnModifySched.Click += OnModifySchedule;
            // 
            // btnDeleteSched
            // 
            btnDeleteSched.AutoSize = true;
            btnDeleteSched.BackColor = Color.FromArgb(180, 40, 40);
            btnDeleteSched.FlatAppearance.BorderSize = 0;
            btnDeleteSched.FlatStyle = FlatStyle.Flat;
            btnDeleteSched.ForeColor = Color.White;
            btnDeleteSched.Location = new Point(191, 8);
            btnDeleteSched.Name = "btnDeleteSched";
            btnDeleteSched.Size = new Size(75, 33);
            btnDeleteSched.TabIndex = 2;
            btnDeleteSched.Text = "Delete";
            btnDeleteSched.UseVisualStyleBackColor = false;
            btnDeleteSched.Click += OnDeleteSchedule;
            // 
            // btnSearchSched
            // 
            btnSearchSched.AutoSize = true;
            btnSearchSched.BackColor = Color.FromArgb(100, 80, 160);
            btnSearchSched.FlatAppearance.BorderSize = 0;
            btnSearchSched.FlatStyle = FlatStyle.Flat;
            btnSearchSched.ForeColor = Color.White;
            btnSearchSched.Location = new Point(272, 8);
            btnSearchSched.Name = "btnSearchSched";
            btnSearchSched.Size = new Size(75, 33);
            btnSearchSched.TabIndex = 3;
            btnSearchSched.Text = "Search";
            btnSearchSched.UseVisualStyleBackColor = false;
            btnSearchSched.Click += OnSearchSchedule;
            // 
            // btnClearSchedFilter
            // 
            btnClearSchedFilter.AutoSize = true;
            btnClearSchedFilter.BackColor = Color.FromArgb(90, 90, 90);
            btnClearSchedFilter.FlatAppearance.BorderSize = 0;
            btnClearSchedFilter.FlatStyle = FlatStyle.Flat;
            btnClearSchedFilter.ForeColor = Color.White;
            btnClearSchedFilter.Location = new Point(353, 8);
            btnClearSchedFilter.Name = "btnClearSchedFilter";
            btnClearSchedFilter.Size = new Size(101, 33);
            btnClearSchedFilter.TabIndex = 4;
            btnClearSchedFilter.Text = "Clear Filter";
            btnClearSchedFilter.UseVisualStyleBackColor = false;
            btnClearSchedFilter.Click += BtnClearSchedFilter_Click;
            // 
            // tblSchedule
            // 
            tblSchedule.BackColor = Color.White;
            tblSchedule.ColumnCount = 4;
            tblSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSchedule.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSchedule.Controls.Add(lblSchedTitle, 0, 0);
            tblSchedule.Controls.Add(lblSchedStart, 1, 0);
            tblSchedule.Controls.Add(lblSchedEnd, 2, 0);
            tblSchedule.Controls.Add(lblSchedDay, 3, 0);
            tblSchedule.Controls.Add(txtSchedTitle, 0, 1);
            tblSchedule.Controls.Add(txtSchedStart, 1, 1);
            tblSchedule.Controls.Add(txtSchedEnd, 2, 1);
            tblSchedule.Controls.Add(cmbSchedDay, 3, 1);
            tblSchedule.Controls.Add(lblSchedLocation, 0, 2);
            tblSchedule.Controls.Add(lblSchedNotes, 1, 2);
            tblSchedule.Controls.Add(txtSchedLocation, 0, 3);
            tblSchedule.Controls.Add(txtSchedNotes, 1, 3);
            tblSchedule.Dock = DockStyle.Top;
            tblSchedule.Location = new Point(0, 0);
            tblSchedule.Name = "tblSchedule";
            tblSchedule.Padding = new Padding(6);
            tblSchedule.RowCount = 4;
            tblSchedule.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSchedule.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblSchedule.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSchedule.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblSchedule.Size = new Size(1092, 130);
            tblSchedule.TabIndex = 3;
            // 
            // lblSchedTitle
            // 
            lblSchedTitle.AutoSize = true;
            lblSchedTitle.ForeColor = Color.FromArgb(70, 80, 100);
            lblSchedTitle.Location = new Point(9, 6);
            lblSchedTitle.Name = "lblSchedTitle";
            lblSchedTitle.Size = new Size(54, 20);
            lblSchedTitle.TabIndex = 0;
            lblSchedTitle.Text = "Title *";
            // 
            // lblSchedStart
            // 
            lblSchedStart.AutoSize = true;
            lblSchedStart.ForeColor = Color.FromArgb(70, 80, 100);
            lblSchedStart.Location = new Point(333, 6);
            lblSchedStart.Name = "lblSchedStart";
            lblSchedStart.Size = new Size(57, 20);
            lblSchedStart.TabIndex = 1;
            lblSchedStart.Text = "Start *";
            // 
            // lblSchedEnd
            // 
            lblSchedEnd.AutoSize = true;
            lblSchedEnd.ForeColor = Color.FromArgb(70, 80, 100);
            lblSchedEnd.Location = new Point(603, 6);
            lblSchedEnd.Name = "lblSchedEnd";
            lblSchedEnd.Size = new Size(51, 20);
            lblSchedEnd.TabIndex = 2;
            lblSchedEnd.Text = "End *";
            // 
            // lblSchedDay
            // 
            lblSchedDay.AutoSize = true;
            lblSchedDay.ForeColor = Color.FromArgb(70, 80, 100);
            lblSchedDay.Location = new Point(873, 6);
            lblSchedDay.Name = "lblSchedDay";
            lblSchedDay.Size = new Size(39, 20);
            lblSchedDay.TabIndex = 3;
            lblSchedDay.Text = "Day";
            // 
            // txtSchedTitle
            // 
            txtSchedTitle.Dock = DockStyle.Fill;
            txtSchedTitle.Location = new Point(9, 29);
            txtSchedTitle.Name = "txtSchedTitle";
            txtSchedTitle.PlaceholderText = "e.g. MIT 211 Lecture";
            txtSchedTitle.Size = new Size(318, 30);
            txtSchedTitle.TabIndex = 4;
            // 
            // txtSchedStart
            // 
            txtSchedStart.Dock = DockStyle.Fill;
            txtSchedStart.Location = new Point(333, 29);
            txtSchedStart.Name = "txtSchedStart";
            txtSchedStart.PlaceholderText = "e.g. 29/05/2026 09:00";
            txtSchedStart.Size = new Size(264, 30);
            txtSchedStart.TabIndex = 5;
            // 
            // txtSchedEnd
            // 
            txtSchedEnd.Dock = DockStyle.Fill;
            txtSchedEnd.Location = new Point(603, 29);
            txtSchedEnd.Name = "txtSchedEnd";
            txtSchedEnd.PlaceholderText = "e.g. 29/05/2026 11:00";
            txtSchedEnd.Size = new Size(264, 30);
            txtSchedEnd.TabIndex = 6;
            // 
            // cmbSchedDay
            // 
            cmbSchedDay.Dock = DockStyle.Fill;
            cmbSchedDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchedDay.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cmbSchedDay.Location = new Point(873, 29);
            cmbSchedDay.Name = "cmbSchedDay";
            cmbSchedDay.Size = new Size(210, 31);
            cmbSchedDay.TabIndex = 7;
            // 
            // lblSchedLocation
            // 
            lblSchedLocation.AutoSize = true;
            lblSchedLocation.ForeColor = Color.FromArgb(70, 80, 100);
            lblSchedLocation.Location = new Point(9, 54);
            lblSchedLocation.Name = "lblSchedLocation";
            lblSchedLocation.Size = new Size(75, 20);
            lblSchedLocation.TabIndex = 8;
            lblSchedLocation.Text = "Location";
            // 
            // lblSchedNotes
            // 
            lblSchedNotes.AutoSize = true;
            lblSchedNotes.ForeColor = Color.FromArgb(70, 80, 100);
            lblSchedNotes.Location = new Point(333, 54);
            lblSchedNotes.Name = "lblSchedNotes";
            lblSchedNotes.Size = new Size(55, 20);
            lblSchedNotes.TabIndex = 9;
            lblSchedNotes.Text = "Notes";
            // 
            // txtSchedLocation
            // 
            txtSchedLocation.Dock = DockStyle.Fill;
            txtSchedLocation.Location = new Point(9, 77);
            txtSchedLocation.Name = "txtSchedLocation";
            txtSchedLocation.PlaceholderText = "Location";
            txtSchedLocation.Size = new Size(318, 30);
            txtSchedLocation.TabIndex = 10;
            // 
            // txtSchedNotes
            // 
            tblSchedule.SetColumnSpan(txtSchedNotes, 3);
            txtSchedNotes.Dock = DockStyle.Fill;
            txtSchedNotes.Location = new Point(333, 77);
            txtSchedNotes.Name = "txtSchedNotes";
            txtSchedNotes.PlaceholderText = "Notes";
            txtSchedNotes.Size = new Size(750, 30);
            txtSchedNotes.TabIndex = 11;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(rtbSummary);
            tabPageDashboard.Controls.Add(flpDashButtons);
            tabPageDashboard.Location = new Point(4, 38);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Size = new Size(1092, 604);
            tabPageDashboard.TabIndex = 3;
            tabPageDashboard.Text = "Dashboard";
            // 
            // rtbSummary
            // 
            rtbSummary.BackColor = Color.FromArgb(20, 30, 48);
            rtbSummary.BorderStyle = BorderStyle.None;
            rtbSummary.Dock = DockStyle.Fill;
            rtbSummary.Font = new Font("Consolas", 11F);
            rtbSummary.ForeColor = Color.FromArgb(180, 220, 255);
            rtbSummary.Location = new Point(0, 0);
            rtbSummary.Name = "rtbSummary";
            rtbSummary.ReadOnly = true;
            rtbSummary.Size = new Size(1092, 562);
            rtbSummary.TabIndex = 0;
            rtbSummary.Text = "";
            // 
            // flpDashButtons
            // 
            flpDashButtons.BackColor = Color.FromArgb(235, 240, 250);
            flpDashButtons.Controls.Add(btnRefreshDash);
            flpDashButtons.Dock = DockStyle.Bottom;
            flpDashButtons.Location = new Point(0, 562);
            flpDashButtons.Name = "flpDashButtons";
            flpDashButtons.Padding = new Padding(6, 5, 6, 0);
            flpDashButtons.Size = new Size(1092, 42);
            flpDashButtons.TabIndex = 1;
            // 
            // btnRefreshDash
            // 
            btnRefreshDash.AutoSize = true;
            btnRefreshDash.BackColor = Color.FromArgb(30, 100, 180);
            btnRefreshDash.FlatAppearance.BorderSize = 0;
            btnRefreshDash.FlatStyle = FlatStyle.Flat;
            btnRefreshDash.ForeColor = Color.White;
            btnRefreshDash.Location = new Point(9, 8);
            btnRefreshDash.Name = "btnRefreshDash";
            btnRefreshDash.Size = new Size(164, 33);
            btnRefreshDash.TabIndex = 0;
            btnRefreshDash.Text = "Refresh Dashboard";
            btnRefreshDash.UseVisualStyleBackColor = false;
            btnRefreshDash.Click += BtnRefreshDash_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.5F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campus Life Management System – MIT 211";
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            pnlEventSearch.ResumeLayout(false);
            pnlEventSearch.PerformLayout();
            flpEventButtons.ResumeLayout(false);
            flpEventButtons.PerformLayout();
            tblEvents.ResumeLayout(false);
            tblEvents.PerformLayout();
            tabPageClubs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            pnlClubSearch.ResumeLayout(false);
            pnlClubSearch.PerformLayout();
            flpClubButtons.ResumeLayout(false);
            flpClubButtons.PerformLayout();
            tblClubs.ResumeLayout(false);
            tblClubs.PerformLayout();
            tabPageSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            pnlSchedSearch.ResumeLayout(false);
            pnlSchedSearch.PerformLayout();
            flpSchedButtons.ResumeLayout(false);
            flpSchedButtons.PerformLayout();
            tblSchedule.ResumeLayout(false);
            tblSchedule.PerformLayout();
            tabPageDashboard.ResumeLayout(false);
            flpDashButtons.ResumeLayout(false);
            flpDashButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Concrete proxy event handler method blocks mapped directly outside code block parsing space
        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e) => this.Close();
        private void BtnClearEventFilter_Click(object sender, System.EventArgs e) { this.txtEventSearch.Clear(); this.RefreshEventsGrid(); }
        private void TxtEventSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) { if (e.KeyCode == System.Windows.Forms.Keys.Enter) this.OnSearchEvents(null!, null!); }
        private void BtnClearClubFilter_Click(object sender, System.EventArgs e) { this.txtClubSearch.Clear(); this.RefreshClubsGrid(); }
        private void TxtClubSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) { if (e.KeyCode == System.Windows.Forms.Keys.Enter) this.OnSearchClubs(null!, null!); }
        private void BtnClearSchedFilter_Click(object sender, System.EventArgs e) { this.txtSchedSearch.Clear(); this.RefreshScheduleGrid(); }
        private void TxtSchedSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) { if (e.KeyCode == System.Windows.Forms.Keys.Enter) this.OnSearchSchedule(null!, null!); }
        private void BtnRefreshDash_Click(object sender, System.EventArgs e) => this.RefreshSummary();

        private void TabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 3) this.RefreshSummary();
        }
    }
}
