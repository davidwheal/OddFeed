using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daw.Client.WebServices.Clients;
using Daw.Clients.Admin.DataGridHelpers;
using Daw.Common.Interfaces;
using Daw.Clients.Admin.Managers;
using Daw.Clients.Admin.DataManagers;

namespace Daw.Clients.Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenSecretClient_Click(object sender, EventArgs e)
        {
            try
            {
                SecretClient sc = new SecretClient();
                var client = sc.Open();
                var xml = client.LoadXmlFromUrl(@"http://xml.betfred.com/horse-racing-antepost.xml");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGoToEvents.Enabled = false;
            var feeds = (FeedDataManager.Engine()).GetFeeds();
            DataGridViewDataHelper.DisplayFeeds(feeds, dgvFeeds);
        }

        private void btnOpenEngineClient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabEvents;
        }

        private void dgvFeeds_SelectionChanged(object sender, EventArgs e)
        {
            string eventKey;
            btnGoToEvents.Enabled = DisplayFeedManager.CanWeShowEventButton(dgvFeeds, out eventKey);
        }

        private void btnGoToEvents_Click(object sender, EventArgs e)
        {
            string eventKey;
            btnGoToEvents.Enabled = DisplayFeedManager.CanWeShowEventButton(dgvFeeds, out eventKey);
            txtFeedKey.Text = eventKey;
            tabControl1.SelectedTab = tabEvents;
        }

        private void tabFeeds_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshFeeds_Click(object sender, EventArgs e)
        {
            var feeds = (FeedDataManager.Engine()).GetFeeds();
            DataGridViewDataHelper.DisplayFeeds(feeds, dgvFeeds);
        }

        private void tabEvents_Enter(object sender, EventArgs e)
        {
            var events = (FeedDataManager.Engine()).GetEvents(txtFeedKey.Text);
            DataGridViewDataHelper.DisplayEvents(events, dgvEvents);
        }

        private void dgvMarkets_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvEvents_SelectionChanged(object sender, EventArgs e)
        {
            string EventKey;
            btnMarkets.Enabled = DisplayFeedManager.CanWeShowEventButton(dgvEvents, out EventKey);
        }

        private void btnMarkets_Click(object sender, EventArgs e)
        {
            string eventKey;
            btnMarkets.Enabled = DisplayFeedManager.CanWeShowEventButton(dgvEvents, out eventKey);
            txtEventKey.Text = eventKey;
            txtFeedKey1.Text = txtFeedKey.Text;
            tabControl1.SelectedTab = tabMarkets;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
        }

        private void tabMarkets_Enter(object sender, EventArgs e)
        {
            var markets = (FeedDataManager.Engine()).GetMarkets(txtFeedKey1.Text, txtEventKey.Text);
            DataGridViewDataHelper.DisplayMarkets(markets, dgvMarkets);

        }
    }
}
