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

namespace Daw.Clients.Admin
{
    public partial class Form1 : Form
    {
        static IEngineWebService engineService = null;
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
            while (1 == 1)
            {
                EngineClient sc = new EngineClient();
                try
                {
                    engineService = sc.Open();
                    break;
                }
                catch (Exception ex)
                {

                }
            }

            var feeds = engineService.GetFeeds();
            DataGridViewDataHelper.DisplayFeed(feeds, dgvFeeds);
        }

        private void btnOpenEngineClient_Click(object sender, EventArgs e)
        {
            try
            {
                var feeds = engineService.GetFeeds();
                DataGridViewDataHelper.DisplayFeed(feeds, dgvFeeds);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dgvFeeds_SelectionChanged(object sender, EventArgs e)
        {
            List<string> list;
            if (DataGridViewHelper.GetSelectedDetail(1, dgvFeeds, 0, out list))
            {

            }

        }
    }
}
