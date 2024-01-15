
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
            this.dataSet1 = new System.Data.DataSet();
            this.gridUnmapped = new System.Windows.Forms.DataGridView();
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
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtUntil = new System.Windows.Forms.DateTimePicker();
            this.btGetTtEntries = new System.Windows.Forms.Button();
            this.btnStartMapping = new System.Windows.Forms.Button();
            this.btnSendToRm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridJrEntries = new System.Windows.Forms.DataGridView();
            this.RmTimeEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTEntriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JrTimeEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mapEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rMEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jrTimeEntryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnmapped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJrEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RmTimeEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTEntriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JrTimeEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jrTimeEntryBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.gridUnmapped.Location = new System.Drawing.Point(24, 99);
            this.gridUnmapped.Margin = new System.Windows.Forms.Padding(2);
            this.gridUnmapped.Name = "gridUnmapped";
            this.gridUnmapped.RowHeadersWidth = 92;
            this.gridUnmapped.RowTemplate.Height = 37;
            this.gridUnmapped.Size = new System.Drawing.Size(759, 969);
            this.gridUnmapped.TabIndex = 9;
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
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(24, 23);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(268, 26);
            this.dtFrom.TabIndex = 10;
            // 
            // dtUntil
            // 
            this.dtUntil.Location = new System.Drawing.Point(24, 61);
            this.dtUntil.Margin = new System.Windows.Forms.Padding(2);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(268, 26);
            this.dtUntil.TabIndex = 11;
            // 
            // btGetTtEntries
            // 
            this.btGetTtEntries.Location = new System.Drawing.Point(301, 23);
            this.btGetTtEntries.Margin = new System.Windows.Forms.Padding(2);
            this.btGetTtEntries.Name = "btGetTtEntries";
            this.btGetTtEntries.Size = new System.Drawing.Size(198, 63);
            this.btGetTtEntries.TabIndex = 12;
            this.btGetTtEntries.Text = "Fetch TT Entries";
            this.btGetTtEntries.UseVisualStyleBackColor = true;
            this.btGetTtEntries.Click += new System.EventHandler(this.btGetTtEntries_Click);
            // 
            // btnStartMapping
            // 
            this.btnStartMapping.Enabled = false;
            this.btnStartMapping.Location = new System.Drawing.Point(528, 23);
            this.btnStartMapping.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartMapping.Name = "btnStartMapping";
            this.btnStartMapping.Size = new System.Drawing.Size(255, 61);
            this.btnStartMapping.TabIndex = 13;
            this.btnStartMapping.Text = "Start Mapping";
            this.btnStartMapping.UseVisualStyleBackColor = true;
            this.btnStartMapping.Click += new System.EventHandler(this.btnStartMapping_Click);
            // 
            // btnSendToRm
            // 
            this.btnSendToRm.Location = new System.Drawing.Point(1464, 24);
            this.btnSendToRm.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToRm.Name = "btnSendToRm";
            this.btnSendToRm.Size = new System.Drawing.Size(344, 61);
            this.btnSendToRm.TabIndex = 20;
            this.btnSendToRm.Text = "Ok, Send!";
            this.btnSendToRm.UseVisualStyleBackColor = true;
            this.btnSendToRm.Click += new System.EventHandler(this.btnSendToRm_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridJrEntries);
            this.panel1.Location = new System.Drawing.Point(788, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 969);
            this.panel1.TabIndex = 26;
            // 
            // gridJrEntries
            // 
            this.gridJrEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJrEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridJrEntries.Location = new System.Drawing.Point(0, 0);
            this.gridJrEntries.Margin = new System.Windows.Forms.Padding(2);
            this.gridJrEntries.Name = "gridJrEntries";
            this.gridJrEntries.RowHeadersWidth = 92;
            this.gridJrEntries.RowTemplate.Height = 37;
            this.gridJrEntries.Size = new System.Drawing.Size(1020, 969);
            this.gridJrEntries.TabIndex = 20;
            // 
            // RmTimeEntryBindingSource
            // 
            this.RmTimeEntryBindingSource.AllowNew = false;
            this.RmTimeEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.RmTimeEntry);
            // 
            // tTEntriesBindingSource
            // 
            this.tTEntriesBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.TTEntries);
            // 
            // JrTimeEntryBindingSource
            // 
            this.JrTimeEntryBindingSource.AllowNew = false;
            this.JrTimeEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.JrTimeEntry);
            // 
            // mapEntryBindingSource
            // 
            this.mapEntryBindingSource.AllowNew = false;
            this.mapEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.MapEntry);
            // 
            // rMEntryBindingSource
            // 
            this.rMEntryBindingSource.AllowNew = false;
            this.rMEntryBindingSource.DataSource = typeof(TrackingTime2Redmine.Models.RMEntry);
            // 
            // jrTimeEntryBindingSource1
            // 
            this.jrTimeEntryBindingSource1.DataSource = typeof(TrackingTime2Redmine.Models.JrTimeEntry);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1827, 1122);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendToRm);
            this.Controls.Add(this.btnStartMapping);
            this.Controls.Add(this.btGetTtEntries);
            this.Controls.Add(this.dtUntil);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.gridUnmapped);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "TrackingTime2RedMine";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnmapped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datumBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJrEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RmTimeEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTEntriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JrTimeEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jrTimeEntryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.BindingSource mapEntryBindingSource;
        private System.Windows.Forms.BindingSource RmTimeEntryBindingSource;
        private System.Windows.Forms.BindingSource rMEntryBindingSource;
        private System.Windows.Forms.Button btnSendToRm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridJrEntries;
        private System.Windows.Forms.BindingSource JrTimeEntryBindingSource;
        private System.Windows.Forms.BindingSource tTEntriesBindingSource;
        private System.Windows.Forms.BindingSource jrTimeEntryBindingSource1;
    }
}

