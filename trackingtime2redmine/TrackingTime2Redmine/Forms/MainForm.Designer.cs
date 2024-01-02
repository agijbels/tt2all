
namespace TrackingTime2Redmine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSendToRM_old = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbActivities = new System.Windows.Forms.ComboBox();
            this.edtComments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSpentOn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.edtIssueID = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.gridUnmapped = new System.Windows.Forms.DataGridView();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtUntil = new System.Windows.Forms.DateTimePicker();
            this.btGetTtEntries = new System.Windows.Forms.Button();
            this.btnStartMapping = new System.Windows.Forms.Button();
            this.gridMapped = new System.Windows.Forms.DataGridView();
            this.gridRmEntries = new System.Windows.Forms.DataGridView();
            this.btnSendToRm = new System.Windows.Forms.Button();
            this.btnGetRmEntries = new System.Windows.Forms.Button();
            this.boxEditEntry = new System.Windows.Forms.GroupBox();
            this.SpentOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RmTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activity_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT_entries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locdurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formateddurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectisfavoriteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskvisibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasklistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isarchivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userhourlyrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userhourlycostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timezoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endrepeatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeateveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbillableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isbilledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usergroupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jsonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnmapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRmEntries)).BeginInit();
            this.boxEditEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendToRM_old
            // 
            this.btnSendToRM_old.Location = new System.Drawing.Point(805, 54);
            this.btnSendToRM_old.Name = "btnSendToRM_old";
            this.btnSendToRM_old.Size = new System.Drawing.Size(373, 191);
            this.btnSendToRM_old.TabIndex = 6;
            this.btnSendToRM_old.Text = "Send To RM";
            this.btnSendToRM_old.UseVisualStyleBackColor = true;
            this.btnSendToRM_old.Click += new System.EventHandler(this.btnSendToRM_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbActivities);
            this.groupBox2.Controls.Add(this.edtComments);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.edtHours);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtSpentOn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.edtIssueID);
            this.groupBox2.Controls.Add(this.btnSendToRM_old);
            this.groupBox2.Location = new System.Drawing.Point(1936, 1658);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1286, 838);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RedMine Single";
            // 
            // cbActivities
            // 
            this.cbActivities.FormattingEnabled = true;
            this.cbActivities.Location = new System.Drawing.Point(200, 301);
            this.cbActivities.Name = "cbActivities";
            this.cbActivities.Size = new System.Drawing.Size(507, 37);
            this.cbActivities.TabIndex = 17;
            // 
            // edtComments
            // 
            this.edtComments.Location = new System.Drawing.Point(200, 364);
            this.edtComments.MaxLength = 255;
            this.edtComments.Multiline = true;
            this.edtComments.Name = "edtComments";
            this.edtComments.Size = new System.Drawing.Size(978, 114);
            this.edtComments.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Activity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hours";
            // 
            // edtHours
            // 
            this.edtHours.Location = new System.Drawing.Point(200, 210);
            this.edtHours.Name = "edtHours";
            this.edtHours.Size = new System.Drawing.Size(507, 35);
            this.edtHours.TabIndex = 11;
            this.edtHours.Text = "1.6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Spent On";
            // 
            // dtSpentOn
            // 
            this.dtSpentOn.Location = new System.Drawing.Point(200, 125);
            this.dtSpentOn.Name = "dtSpentOn";
            this.dtSpentOn.Size = new System.Drawing.Size(507, 35);
            this.dtSpentOn.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "issue ID";
            // 
            // edtIssueID
            // 
            this.edtIssueID.Location = new System.Drawing.Point(200, 68);
            this.edtIssueID.Name = "edtIssueID";
            this.edtIssueID.Size = new System.Drawing.Size(507, 35);
            this.edtIssueID.TabIndex = 7;
            this.edtIssueID.Text = "1817";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // gridUnmapped
            // 
            this.gridUnmapped.AutoGenerateColumns = false;
            this.gridUnmapped.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridUnmapped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnmapped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventtypeDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.locstartDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.locendDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.locdurationDataGridViewTextBoxColumn,
            this.formateddurationDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.serviceidDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.projectidDataGridViewTextBoxColumn,
            this.projectnotesDataGridViewTextBoxColumn,
            this.projectcolorDataGridViewTextBoxColumn,
            this.projectisfavoriteDataGridViewTextBoxColumn,
            this.skillDataGridViewTextBoxColumn,
            this.skillidDataGridViewTextBoxColumn,
            this.taskDataGridViewTextBoxColumn,
            this.taskidDataGridViewTextBoxColumn,
            this.tasktypeDataGridViewTextBoxColumn,
            this.taskvisibilityDataGridViewTextBoxColumn,
            this.tasklistDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.estimatedtimeDataGridViewTextBoxColumn,
            this.isarchivedDataGridViewCheckBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.userhourlyrateDataGridViewTextBoxColumn,
            this.userhourlycostDataGridViewTextBoxColumn,
            this.timezoneDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.repeatDataGridViewTextBoxColumn,
            this.endrepeatDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.repeateveryDataGridViewTextBoxColumn,
            this.hourlyrateDataGridViewTextBoxColumn,
            this.isbillableDataGridViewCheckBoxColumn,
            this.isbilledDataGridViewCheckBoxColumn,
            this.usergroupsDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.updatedatDataGridViewTextBoxColumn,
            this.jsonDataGridViewTextBoxColumn});
            this.gridUnmapped.DataSource = this.datumBindingSource;
            this.gridUnmapped.Location = new System.Drawing.Point(38, 150);
            this.gridUnmapped.Name = "gridUnmapped";
            this.gridUnmapped.RowHeadersWidth = 92;
            this.gridUnmapped.RowTemplate.Height = 37;
            this.gridUnmapped.Size = new System.Drawing.Size(1160, 1405);
            this.gridUnmapped.TabIndex = 9;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(38, 34);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(414, 35);
            this.dtFrom.TabIndex = 10;
            // 
            // dtUntil
            // 
            this.dtUntil.Location = new System.Drawing.Point(38, 88);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(414, 35);
            this.dtUntil.TabIndex = 11;
            // 
            // btGetTtEntries
            // 
            this.btGetTtEntries.Location = new System.Drawing.Point(469, 34);
            this.btGetTtEntries.Name = "btGetTtEntries";
            this.btGetTtEntries.Size = new System.Drawing.Size(308, 91);
            this.btGetTtEntries.TabIndex = 12;
            this.btGetTtEntries.Text = "Fetch TT Entries";
            this.btGetTtEntries.UseVisualStyleBackColor = true;
            this.btGetTtEntries.Click += new System.EventHandler(this.btGetTtEntries_Click);
            // 
            // btnStartMapping
            // 
            this.btnStartMapping.Enabled = false;
            this.btnStartMapping.Location = new System.Drawing.Point(801, 34);
            this.btnStartMapping.Name = "btnStartMapping";
            this.btnStartMapping.Size = new System.Drawing.Size(397, 89);
            this.btnStartMapping.TabIndex = 13;
            this.btnStartMapping.Text = "Start Mapping";
            this.btnStartMapping.UseVisualStyleBackColor = true;
            this.btnStartMapping.Click += new System.EventHandler(this.btnStartMapping_Click);
            // 
            // gridMapped
            // 
            this.gridMapped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMapped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpentOn,
            this.RmTask,
            this.TotalHours,
            this.RMText,
            this.activity_id,
            this.TT_entries});
            this.gridMapped.Location = new System.Drawing.Point(1220, 360);
            this.gridMapped.MultiSelect = false;
            this.gridMapped.Name = "gridMapped";
            this.gridMapped.ReadOnly = true;
            this.gridMapped.RowHeadersWidth = 92;
            this.gridMapped.RowTemplate.Height = 37;
            this.gridMapped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMapped.Size = new System.Drawing.Size(1230, 1195);
            this.gridMapped.TabIndex = 18;
            this.gridMapped.SelectionChanged += new System.EventHandler(this.gridMapped_SelectionChanged);
            // 
            // gridRmEntries
            // 
            this.gridRmEntries.AutoGenerateColumns = false;
            this.gridRmEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRmEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueidDataGridViewTextBoxColumn,
            this.spentonDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.activityidDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn1});
            this.gridRmEntries.DataSource = this.timeEntryBindingSource;
            this.gridRmEntries.Location = new System.Drawing.Point(2477, 150);
            this.gridRmEntries.Name = "gridRmEntries";
            this.gridRmEntries.RowHeadersWidth = 92;
            this.gridRmEntries.RowTemplate.Height = 37;
            this.gridRmEntries.Size = new System.Drawing.Size(1450, 1405);
            this.gridRmEntries.TabIndex = 19;
            // 
            // btnSendToRm
            // 
            this.btnSendToRm.Location = new System.Drawing.Point(3392, 34);
            this.btnSendToRm.Name = "btnSendToRm";
            this.btnSendToRm.Size = new System.Drawing.Size(535, 89);
            this.btnSendToRm.TabIndex = 20;
            this.btnSendToRm.Text = "Ok, Send!";
            this.btnSendToRm.UseVisualStyleBackColor = true;
            this.btnSendToRm.Click += new System.EventHandler(this.btnSendToRm_Click_1);
            // 
            // btnGetRmEntries
            // 
            this.btnGetRmEntries.Location = new System.Drawing.Point(2477, 34);
            this.btnGetRmEntries.Name = "btnGetRmEntries";
            this.btnGetRmEntries.Size = new System.Drawing.Size(539, 89);
            this.btnGetRmEntries.TabIndex = 21;
            this.btnGetRmEntries.Text = "Get RM Entries";
            this.btnGetRmEntries.UseVisualStyleBackColor = true;
            this.btnGetRmEntries.Click += new System.EventHandler(this.btnGetRmEntries_Click);
            // 
            // boxEditEntry
            // 
            this.boxEditEntry.Controls.Add(this.button1);
            this.boxEditEntry.Controls.Add(this.textBox3);
            this.boxEditEntry.Controls.Add(this.label11);
            this.boxEditEntry.Controls.Add(this.comboBox1);
            this.boxEditEntry.Controls.Add(this.label10);
            this.boxEditEntry.Controls.Add(this.richTextBox1);
            this.boxEditEntry.Controls.Add(this.label9);
            this.boxEditEntry.Controls.Add(this.textBox2);
            this.boxEditEntry.Controls.Add(this.textBox1);
            this.boxEditEntry.Controls.Add(this.dateTimePicker1);
            this.boxEditEntry.Controls.Add(this.label8);
            this.boxEditEntry.Controls.Add(this.label7);
            this.boxEditEntry.Controls.Add(this.label6);
            this.boxEditEntry.Location = new System.Drawing.Point(1220, 34);
            this.boxEditEntry.Name = "boxEditEntry";
            this.boxEditEntry.Size = new System.Drawing.Size(1230, 320);
            this.boxEditEntry.TabIndex = 22;
            this.boxEditEntry.TabStop = false;
            this.boxEditEntry.Text = "Edit Entry";
            // 
            // SpentOn
            // 
            this.SpentOn.DataPropertyName = "SpentOn";
            this.SpentOn.HeaderText = "Spent On";
            this.SpentOn.MinimumWidth = 11;
            this.SpentOn.Name = "SpentOn";
            this.SpentOn.ReadOnly = true;
            this.SpentOn.Width = 225;
            // 
            // RmTask
            // 
            this.RmTask.DataPropertyName = "RmTask";
            this.RmTask.HeaderText = "RM Task";
            this.RmTask.MinimumWidth = 11;
            this.RmTask.Name = "RmTask";
            this.RmTask.ReadOnly = true;
            this.RmTask.Width = 225;
            // 
            // TotalHours
            // 
            this.TotalHours.DataPropertyName = "TotalHours";
            this.TotalHours.HeaderText = "Total Hours";
            this.TotalHours.MinimumWidth = 11;
            this.TotalHours.Name = "TotalHours";
            this.TotalHours.ReadOnly = true;
            this.TotalHours.Width = 225;
            // 
            // RMText
            // 
            this.RMText.DataPropertyName = "Text";
            this.RMText.HeaderText = "Notes";
            this.RMText.MinimumWidth = 11;
            this.RMText.Name = "RMText";
            this.RMText.ReadOnly = true;
            this.RMText.Width = 225;
            // 
            // activity_id
            // 
            this.activity_id.DataPropertyName = "activity_id";
            this.activity_id.HeaderText = "Activity";
            this.activity_id.MinimumWidth = 11;
            this.activity_id.Name = "activity_id";
            this.activity_id.ReadOnly = true;
            this.activity_id.Width = 225;
            // 
            // TT_entries
            // 
            this.TT_entries.DataPropertyName = "TT_entries";
            this.TT_entries.HeaderText = "TT Entries";
            this.TT_entries.MinimumWidth = 11;
            this.TT_entries.Name = "TT_entries";
            this.TT_entries.ReadOnly = true;
            this.TT_entries.Width = 225;
            // 
            // issueidDataGridViewTextBoxColumn
            // 
            this.issueidDataGridViewTextBoxColumn.DataPropertyName = "issue_id";
            this.issueidDataGridViewTextBoxColumn.HeaderText = "issue_id";
            this.issueidDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.issueidDataGridViewTextBoxColumn.Name = "issueidDataGridViewTextBoxColumn";
            this.issueidDataGridViewTextBoxColumn.Width = 225;
            // 
            // spentonDataGridViewTextBoxColumn
            // 
            this.spentonDataGridViewTextBoxColumn.DataPropertyName = "spent_on";
            this.spentonDataGridViewTextBoxColumn.HeaderText = "spent_on";
            this.spentonDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.spentonDataGridViewTextBoxColumn.Name = "spentonDataGridViewTextBoxColumn";
            this.spentonDataGridViewTextBoxColumn.Width = 225;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.Width = 225;
            // 
            // activityidDataGridViewTextBoxColumn
            // 
            this.activityidDataGridViewTextBoxColumn.DataPropertyName = "activity_id";
            this.activityidDataGridViewTextBoxColumn.HeaderText = "activity_id";
            this.activityidDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.activityidDataGridViewTextBoxColumn.Name = "activityidDataGridViewTextBoxColumn";
            this.activityidDataGridViewTextBoxColumn.Width = 225;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 225;
            // 
            // useridDataGridViewTextBoxColumn1
            // 
            this.useridDataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn1.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn1.MinimumWidth = 11;
            this.useridDataGridViewTextBoxColumn1.Name = "useridDataGridViewTextBoxColumn1";
            this.useridDataGridViewTextBoxColumn1.Width = 225;
            // 
            // timeEntryBindingSource
            // 
            this.timeEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.TimeEntry);
            // 
            // eventtypeDataGridViewTextBoxColumn
            // 
            this.eventtypeDataGridViewTextBoxColumn.DataPropertyName = "event_type";
            this.eventtypeDataGridViewTextBoxColumn.HeaderText = "event_type";
            this.eventtypeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.eventtypeDataGridViewTextBoxColumn.Name = "eventtypeDataGridViewTextBoxColumn";
            this.eventtypeDataGridViewTextBoxColumn.Width = 225;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "Start";
            this.startDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.Width = 225;
            // 
            // locstartDataGridViewTextBoxColumn
            // 
            this.locstartDataGridViewTextBoxColumn.DataPropertyName = "loc_start";
            this.locstartDataGridViewTextBoxColumn.HeaderText = "loc_start";
            this.locstartDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.locstartDataGridViewTextBoxColumn.Name = "locstartDataGridViewTextBoxColumn";
            this.locstartDataGridViewTextBoxColumn.Visible = false;
            this.locstartDataGridViewTextBoxColumn.Width = 225;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "End";
            this.endDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.Width = 225;
            // 
            // locendDataGridViewTextBoxColumn
            // 
            this.locendDataGridViewTextBoxColumn.DataPropertyName = "loc_end";
            this.locendDataGridViewTextBoxColumn.HeaderText = "loc_end";
            this.locendDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.locendDataGridViewTextBoxColumn.Name = "locendDataGridViewTextBoxColumn";
            this.locendDataGridViewTextBoxColumn.Visible = false;
            this.locendDataGridViewTextBoxColumn.Width = 225;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 225;
            // 
            // locdurationDataGridViewTextBoxColumn
            // 
            this.locdurationDataGridViewTextBoxColumn.DataPropertyName = "loc_duration";
            this.locdurationDataGridViewTextBoxColumn.HeaderText = "loc_duration";
            this.locdurationDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.locdurationDataGridViewTextBoxColumn.Name = "locdurationDataGridViewTextBoxColumn";
            this.locdurationDataGridViewTextBoxColumn.Visible = false;
            this.locdurationDataGridViewTextBoxColumn.Width = 225;
            // 
            // formateddurationDataGridViewTextBoxColumn
            // 
            this.formateddurationDataGridViewTextBoxColumn.DataPropertyName = "formated_duration";
            this.formateddurationDataGridViewTextBoxColumn.HeaderText = "formated_duration";
            this.formateddurationDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.formateddurationDataGridViewTextBoxColumn.Name = "formateddurationDataGridViewTextBoxColumn";
            this.formateddurationDataGridViewTextBoxColumn.Width = 225;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Width = 225;
            // 
            // serviceidDataGridViewTextBoxColumn
            // 
            this.serviceidDataGridViewTextBoxColumn.DataPropertyName = "service_id";
            this.serviceidDataGridViewTextBoxColumn.HeaderText = "service_id";
            this.serviceidDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.serviceidDataGridViewTextBoxColumn.Name = "serviceidDataGridViewTextBoxColumn";
            this.serviceidDataGridViewTextBoxColumn.Width = 225;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 225;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Width = 225;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "project";
            this.projectDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 225;
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "project_id";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "project_id";
            this.projectidDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            this.projectidDataGridViewTextBoxColumn.Width = 225;
            // 
            // projectnotesDataGridViewTextBoxColumn
            // 
            this.projectnotesDataGridViewTextBoxColumn.DataPropertyName = "project_notes";
            this.projectnotesDataGridViewTextBoxColumn.HeaderText = "project_notes";
            this.projectnotesDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.projectnotesDataGridViewTextBoxColumn.Name = "projectnotesDataGridViewTextBoxColumn";
            this.projectnotesDataGridViewTextBoxColumn.Visible = false;
            this.projectnotesDataGridViewTextBoxColumn.Width = 225;
            // 
            // projectcolorDataGridViewTextBoxColumn
            // 
            this.projectcolorDataGridViewTextBoxColumn.DataPropertyName = "project_color";
            this.projectcolorDataGridViewTextBoxColumn.HeaderText = "project_color";
            this.projectcolorDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.projectcolorDataGridViewTextBoxColumn.Name = "projectcolorDataGridViewTextBoxColumn";
            this.projectcolorDataGridViewTextBoxColumn.Width = 225;
            // 
            // projectisfavoriteDataGridViewTextBoxColumn
            // 
            this.projectisfavoriteDataGridViewTextBoxColumn.DataPropertyName = "project_is_favorite";
            this.projectisfavoriteDataGridViewTextBoxColumn.HeaderText = "project_is_favorite";
            this.projectisfavoriteDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.projectisfavoriteDataGridViewTextBoxColumn.Name = "projectisfavoriteDataGridViewTextBoxColumn";
            this.projectisfavoriteDataGridViewTextBoxColumn.Visible = false;
            this.projectisfavoriteDataGridViewTextBoxColumn.Width = 225;
            // 
            // skillDataGridViewTextBoxColumn
            // 
            this.skillDataGridViewTextBoxColumn.DataPropertyName = "skill";
            this.skillDataGridViewTextBoxColumn.HeaderText = "skill";
            this.skillDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.skillDataGridViewTextBoxColumn.Name = "skillDataGridViewTextBoxColumn";
            this.skillDataGridViewTextBoxColumn.Width = 225;
            // 
            // skillidDataGridViewTextBoxColumn
            // 
            this.skillidDataGridViewTextBoxColumn.DataPropertyName = "skill_id";
            this.skillidDataGridViewTextBoxColumn.HeaderText = "skill_id";
            this.skillidDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.skillidDataGridViewTextBoxColumn.Name = "skillidDataGridViewTextBoxColumn";
            this.skillidDataGridViewTextBoxColumn.Width = 225;
            // 
            // taskDataGridViewTextBoxColumn
            // 
            this.taskDataGridViewTextBoxColumn.DataPropertyName = "task";
            this.taskDataGridViewTextBoxColumn.HeaderText = "task";
            this.taskDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.taskDataGridViewTextBoxColumn.Name = "taskDataGridViewTextBoxColumn";
            this.taskDataGridViewTextBoxColumn.Width = 225;
            // 
            // taskidDataGridViewTextBoxColumn
            // 
            this.taskidDataGridViewTextBoxColumn.DataPropertyName = "task_id";
            this.taskidDataGridViewTextBoxColumn.HeaderText = "task_id";
            this.taskidDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.taskidDataGridViewTextBoxColumn.Name = "taskidDataGridViewTextBoxColumn";
            this.taskidDataGridViewTextBoxColumn.Width = 225;
            // 
            // tasktypeDataGridViewTextBoxColumn
            // 
            this.tasktypeDataGridViewTextBoxColumn.DataPropertyName = "task_type";
            this.tasktypeDataGridViewTextBoxColumn.HeaderText = "task_type";
            this.tasktypeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.tasktypeDataGridViewTextBoxColumn.Name = "tasktypeDataGridViewTextBoxColumn";
            this.tasktypeDataGridViewTextBoxColumn.Width = 225;
            // 
            // taskvisibilityDataGridViewTextBoxColumn
            // 
            this.taskvisibilityDataGridViewTextBoxColumn.DataPropertyName = "task_visibility";
            this.taskvisibilityDataGridViewTextBoxColumn.HeaderText = "task_visibility";
            this.taskvisibilityDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.taskvisibilityDataGridViewTextBoxColumn.Name = "taskvisibilityDataGridViewTextBoxColumn";
            this.taskvisibilityDataGridViewTextBoxColumn.Width = 225;
            // 
            // tasklistDataGridViewTextBoxColumn
            // 
            this.tasklistDataGridViewTextBoxColumn.DataPropertyName = "task_list";
            this.tasklistDataGridViewTextBoxColumn.HeaderText = "task_list";
            this.tasklistDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.tasklistDataGridViewTextBoxColumn.Name = "tasklistDataGridViewTextBoxColumn";
            this.tasklistDataGridViewTextBoxColumn.Width = 225;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "due_date";
            this.duedateDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.Width = 225;
            // 
            // estimatedtimeDataGridViewTextBoxColumn
            // 
            this.estimatedtimeDataGridViewTextBoxColumn.DataPropertyName = "estimated_time";
            this.estimatedtimeDataGridViewTextBoxColumn.HeaderText = "estimated_time";
            this.estimatedtimeDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.estimatedtimeDataGridViewTextBoxColumn.Name = "estimatedtimeDataGridViewTextBoxColumn";
            this.estimatedtimeDataGridViewTextBoxColumn.Width = 225;
            // 
            // isarchivedDataGridViewCheckBoxColumn
            // 
            this.isarchivedDataGridViewCheckBoxColumn.DataPropertyName = "is_archived";
            this.isarchivedDataGridViewCheckBoxColumn.HeaderText = "is_archived";
            this.isarchivedDataGridViewCheckBoxColumn.MinimumWidth = 11;
            this.isarchivedDataGridViewCheckBoxColumn.Name = "isarchivedDataGridViewCheckBoxColumn";
            this.isarchivedDataGridViewCheckBoxColumn.Width = 225;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 225;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 225;
            // 
            // userhourlyrateDataGridViewTextBoxColumn
            // 
            this.userhourlyrateDataGridViewTextBoxColumn.DataPropertyName = "user_hourly_rate";
            this.userhourlyrateDataGridViewTextBoxColumn.HeaderText = "user_hourly_rate";
            this.userhourlyrateDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.userhourlyrateDataGridViewTextBoxColumn.Name = "userhourlyrateDataGridViewTextBoxColumn";
            this.userhourlyrateDataGridViewTextBoxColumn.Width = 225;
            // 
            // userhourlycostDataGridViewTextBoxColumn
            // 
            this.userhourlycostDataGridViewTextBoxColumn.DataPropertyName = "user_hourly_cost";
            this.userhourlycostDataGridViewTextBoxColumn.HeaderText = "user_hourly_cost";
            this.userhourlycostDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.userhourlycostDataGridViewTextBoxColumn.Name = "userhourlycostDataGridViewTextBoxColumn";
            this.userhourlycostDataGridViewTextBoxColumn.Width = 225;
            // 
            // timezoneDataGridViewTextBoxColumn
            // 
            this.timezoneDataGridViewTextBoxColumn.DataPropertyName = "timezone";
            this.timezoneDataGridViewTextBoxColumn.HeaderText = "timezone";
            this.timezoneDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.timezoneDataGridViewTextBoxColumn.Name = "timezoneDataGridViewTextBoxColumn";
            this.timezoneDataGridViewTextBoxColumn.Width = 225;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 225;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 225;
            // 
            // repeatDataGridViewTextBoxColumn
            // 
            this.repeatDataGridViewTextBoxColumn.DataPropertyName = "repeat";
            this.repeatDataGridViewTextBoxColumn.HeaderText = "repeat";
            this.repeatDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.repeatDataGridViewTextBoxColumn.Name = "repeatDataGridViewTextBoxColumn";
            this.repeatDataGridViewTextBoxColumn.Visible = false;
            this.repeatDataGridViewTextBoxColumn.Width = 225;
            // 
            // endrepeatDataGridViewTextBoxColumn
            // 
            this.endrepeatDataGridViewTextBoxColumn.DataPropertyName = "end_repeat";
            this.endrepeatDataGridViewTextBoxColumn.HeaderText = "end_repeat";
            this.endrepeatDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.endrepeatDataGridViewTextBoxColumn.Name = "endrepeatDataGridViewTextBoxColumn";
            this.endrepeatDataGridViewTextBoxColumn.Visible = false;
            this.endrepeatDataGridViewTextBoxColumn.Width = 225;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "frequency";
            this.frequencyDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            this.frequencyDataGridViewTextBoxColumn.Visible = false;
            this.frequencyDataGridViewTextBoxColumn.Width = 225;
            // 
            // repeateveryDataGridViewTextBoxColumn
            // 
            this.repeateveryDataGridViewTextBoxColumn.DataPropertyName = "repeat_every";
            this.repeateveryDataGridViewTextBoxColumn.HeaderText = "repeat_every";
            this.repeateveryDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.repeateveryDataGridViewTextBoxColumn.Name = "repeateveryDataGridViewTextBoxColumn";
            this.repeateveryDataGridViewTextBoxColumn.Width = 225;
            // 
            // hourlyrateDataGridViewTextBoxColumn
            // 
            this.hourlyrateDataGridViewTextBoxColumn.DataPropertyName = "hourly_rate";
            this.hourlyrateDataGridViewTextBoxColumn.HeaderText = "hourly_rate";
            this.hourlyrateDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.hourlyrateDataGridViewTextBoxColumn.Name = "hourlyrateDataGridViewTextBoxColumn";
            this.hourlyrateDataGridViewTextBoxColumn.Visible = false;
            this.hourlyrateDataGridViewTextBoxColumn.Width = 225;
            // 
            // isbillableDataGridViewCheckBoxColumn
            // 
            this.isbillableDataGridViewCheckBoxColumn.DataPropertyName = "is_billable";
            this.isbillableDataGridViewCheckBoxColumn.HeaderText = "is_billable";
            this.isbillableDataGridViewCheckBoxColumn.MinimumWidth = 11;
            this.isbillableDataGridViewCheckBoxColumn.Name = "isbillableDataGridViewCheckBoxColumn";
            this.isbillableDataGridViewCheckBoxColumn.Width = 225;
            // 
            // isbilledDataGridViewCheckBoxColumn
            // 
            this.isbilledDataGridViewCheckBoxColumn.DataPropertyName = "is_billed";
            this.isbilledDataGridViewCheckBoxColumn.HeaderText = "is_billed";
            this.isbilledDataGridViewCheckBoxColumn.MinimumWidth = 11;
            this.isbilledDataGridViewCheckBoxColumn.Name = "isbilledDataGridViewCheckBoxColumn";
            this.isbilledDataGridViewCheckBoxColumn.Width = 225;
            // 
            // usergroupsDataGridViewTextBoxColumn
            // 
            this.usergroupsDataGridViewTextBoxColumn.DataPropertyName = "user_groups";
            this.usergroupsDataGridViewTextBoxColumn.HeaderText = "user_groups";
            this.usergroupsDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.usergroupsDataGridViewTextBoxColumn.Name = "usergroupsDataGridViewTextBoxColumn";
            this.usergroupsDataGridViewTextBoxColumn.Visible = false;
            this.usergroupsDataGridViewTextBoxColumn.Width = 225;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 225;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            this.createdatDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            this.createdatDataGridViewTextBoxColumn.Visible = false;
            this.createdatDataGridViewTextBoxColumn.Width = 225;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            this.updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            this.updatedatDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            this.updatedatDataGridViewTextBoxColumn.Visible = false;
            this.updatedatDataGridViewTextBoxColumn.Width = 225;
            // 
            // jsonDataGridViewTextBoxColumn
            // 
            this.jsonDataGridViewTextBoxColumn.DataPropertyName = "json";
            this.jsonDataGridViewTextBoxColumn.HeaderText = "json";
            this.jsonDataGridViewTextBoxColumn.MinimumWidth = 11;
            this.jsonDataGridViewTextBoxColumn.Name = "jsonDataGridViewTextBoxColumn";
            this.jsonDataGridViewTextBoxColumn.Visible = false;
            this.jsonDataGridViewTextBoxColumn.Width = 225;
            // 
            // datumBindingSource
            // 
            this.datumBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.Datum);
            // 
            // mapEntryBindingSource
            // 
            this.mapEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.MapEntry);
            // 
            // rMEntryBindingSource
            // 
            this.rMEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.RMEntry);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Spent On:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "RM Task:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Hours:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(394, 35);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 35);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 35);
            this.textBox2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Text:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(581, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(643, 165);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Activity";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 37);
            this.comboBox1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "TT Entries:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(419, 35);
            this.textBox3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(643, 71);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(4376, 2230);
            this.Controls.Add(this.boxEditEntry);
            this.Controls.Add(this.btnGetRmEntries);
            this.Controls.Add(this.btnSendToRm);
            this.Controls.Add(this.gridRmEntries);
            this.Controls.Add(this.gridMapped);
            this.Controls.Add(this.btnStartMapping);
            this.Controls.Add(this.btGetTtEntries);
            this.Controls.Add(this.dtUntil);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.gridUnmapped);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "TrackingTime2RedMine";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnmapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRmEntries)).EndInit();
            this.boxEditEntry.ResumeLayout(false);
            this.boxEditEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSendToRM_old;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSpentOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtIssueID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtComments;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView gridUnmapped;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtUntil;
        private System.Windows.Forms.Button btGetTtEntries;
        private System.Windows.Forms.BindingSource datumBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locdurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formateddurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectisfavoriteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskvisibilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasklistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isarchivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userhourlyrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userhourlycostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endrepeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeateveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isbillableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isbilledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usergroupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jsonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnStartMapping;
        private System.Windows.Forms.DataGridView gridMapped;
        private System.Windows.Forms.BindingSource mapEntryBindingSource;
        private System.Windows.Forms.DataGridView gridRmEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spentonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource timeEntryBindingSource;
        private System.Windows.Forms.BindingSource rMEntryBindingSource;
        private System.Windows.Forms.Button btnSendToRm;
        private System.Windows.Forms.Button btnGetRmEntries;
        private System.Windows.Forms.GroupBox boxEditEntry;
        private System.Windows.Forms.ComboBox cbActivities;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpentOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RmTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMText;
        private System.Windows.Forms.DataGridViewTextBoxColumn activity_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT_entries;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

