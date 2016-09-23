﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daw.Client.WebServices.Clients;

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

        }

        private void btnOpenEngineClient_Click(object sender, EventArgs e)
        {
            try
            {
                EngineClient sc = new EngineClient();
                var client = sc.Open();
                var feeds = client.GetFeeds();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
