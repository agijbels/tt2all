using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingTime2Redmine.Models;

namespace TrackingTime2Redmine
{
    public partial class MainForm : Form
    {
        private EntryMapper _entryMapper;
        public MainForm()
        {
            InitializeComponent();
            cbActivities.DataSource = Enum.GetValues(typeof(RMActivity));
        }

        private void RefreshUnmappedGrid()
        {
            var bindingList = new BindingList<Datum>(_entryMapper._unmappedTtEntries);
            var source = new BindingSource(bindingList, null);
            gridUnmapped.DataSource = source;
        }

        private void RefreshMappedGrid()
        {
            var templist = _entryMapper._mappedEntries.Select(entry => new { entry.SpentOn, entry.RmTask, entry.TotalHours, entry.Text, activity_id = (int)entry.Activity, TT_entries = $"[{string.Join(", ", entry.TtEntries.Select(ttEntry => ttEntry.id)) }]" }).ToList();

           // var bindingList = new BindingList<TimeEntry>(templist);
           // var source = new BindingSource(bindingList, null);
            gridMapped.DataSource = templist;
        }

        private void RefreshRmEntriesGrid()
        {
            var bindingList = new BindingList<TimeEntry>(_entryMapper.GetRMTimeEntries());
            var source = new BindingSource(bindingList, null);
            gridRmEntries.DataSource = source;
        }

        private void RefreshGrids()
        {
            RefreshUnmappedGrid();
            RefreshMappedGrid();
            RefreshRmEntriesGrid();
        }

        private void btnSendToRM_Click(object sender, EventArgs e)
        {
            RMEntry entry = new RMEntry();
            entry.time_entry = new TimeEntry();
            entry.time_entry.issue_id = Int32.Parse(edtIssueID.Text);
            entry.time_entry.spent_on = dtSpentOn.Value.ToString("yyyy-MM-dd");
            entry.time_entry.hours = Convert.ToDouble(edtHours.Text.Replace('.', ','));
            entry.time_entry.activity_id = (int)(RMActivity)cbActivities.SelectedItem;
            entry.time_entry.comments = edtComments.Text;
            entry.time_entry.user_id = Int32.Parse(ConfigurationManager.AppSettings["RMUserId"]);


            var rmService = new RmApiService();
            rmService.InitialSetup();
            var result = rmService.SendEntry(entry);

            MessageBox.Show($"Sending to RedMine returned {result}");
        }

        private void btGetTtEntries_Click(object sender, EventArgs e)
        {
            try
            {
                _entryMapper = new EntryMapper(dtFrom.Value, dtUntil.Value);

                RefreshGrids();
                btnStartMapping.Enabled = true;
                btnGetRmEntries.Enabled = false;
                btnSendToRm.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartMapping_Click(object sender, EventArgs e)
        {
            _entryMapper.StartMapping();

            RefreshGrids();
            btnStartMapping.Enabled = false;
            btnGetRmEntries.Enabled = true;
            btnSendToRm.Enabled = false;
        }

        private void btnGetRmEntries_Click(object sender, EventArgs e)
        {
            _entryMapper.MapToRmEntries();

            RefreshGrids();
            btnStartMapping.Enabled = false;
            btnGetRmEntries.Enabled = false;
            btnSendToRm.Enabled = true;
        }

        private void btnSendToRm_Click_1(object sender, EventArgs e)
        {
            _entryMapper.SendToRm();
            btnStartMapping.Enabled = false;
            btnGetRmEntries.Enabled = false;
            btnSendToRm.Enabled = false;
        }

        private void gridMapped_SelectionChanged(object sender, EventArgs e)
        {
            if ((dynamic)gridMapped.SelectedRows.Count > 0)
            {
                var item = (dynamic)gridMapped.SelectedRows[0].DataBoundItem;
                if (item != null)
                {
                    MessageBox.Show($"selection: {item.activity_id}");
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
