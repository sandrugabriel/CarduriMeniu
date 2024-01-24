using Bunifu.UI.WinForms.Extensions;
using CarduriMeniu.View.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(new PnlMeniu(this));    
        }

        private void bunifuFormCaptionButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFormCaptionButton2_Click(object sender, EventArgs e)
        {
            this.Minimize();
        }
    }
}
