using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daw.Common.Entities.Comparer;

namespace Daw.Console.TestFuzzyCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var s1 = txtS1.Text;
            var s2 = txtS2.Text;
            var  m = ComparerHelper.FuzzyCompare(s1, s2);
            txtResult.Text = m.ToString();
        }
    }
}
