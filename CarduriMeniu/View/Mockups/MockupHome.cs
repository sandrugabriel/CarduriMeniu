using Bunifu.UI.WinForms.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu.View.Mockups
{
    public partial class MockupHome : Form
    {
        public MockupHome()
        {
            InitializeComponent();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFormCaptionButton2_Click(object sender, EventArgs e)
        {
            this.Minimize();
        }
    }
}
