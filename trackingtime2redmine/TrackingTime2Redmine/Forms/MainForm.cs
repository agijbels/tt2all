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
        }

        private void RefreshUnmappedGrid()
        {
            var bindingList = new BindingList<Datum>(_entryMapper._unmappedTtEntries);
            var source = new BindingSource(bindingList, null);
            gridUnmapped.DataSource = source;
        }

        private void RefreshDestinationEntriesGrid()
        {
            var jrBindingList = new BindingList<JrVisualTimeEntry>(_entryMapper._jrEntries.Select(entry => new JrVisualTimeEntry(entry)).ToList() );
            var jrSource = new BindingSource(jrBindingList, null);
            gridJrEntries.DataSource = jrSource;
        }

        private void RefreshGrids()
        {
            RefreshUnmappedGrid();
            RefreshDestinationEntriesGrid();
        }

        private void btGetTtEntries_Click(object sender, EventArgs e)
        {
            try
            {
                _entryMapper = new EntryMapper(dtFrom.Value, dtUntil.Value);

                RefreshGrids();
                btnStartMapping.Enabled = true;
                btnSendToRm.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartMapping_Click(object sender, EventArgs e)
        {
            _entryMapper.StartMapping(false, true);
            _entryMapper.MapToJrEntries();

            RefreshGrids();
            btnStartMapping.Enabled = false;
            btnSendToRm.Enabled = true;
        }

        private void btnSendToRm_Click_1(object sender, EventArgs e)
        {
            _entryMapper.SendToJr();

            btnStartMapping.Enabled = false;
            btnSendToRm.Enabled = false;
        }
    }
}
