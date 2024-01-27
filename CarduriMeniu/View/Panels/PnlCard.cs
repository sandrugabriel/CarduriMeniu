using CarduriMeniu.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu.View.Panels
{
    public class PnlCard : Panel
    {

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pct;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

        Form1 form;
        Product product;
        public PnlCard(Form1 form1,Product product1) {

            this.product = product1;

            //PnlCard
            this.Size = new System.Drawing.Size(228, 163);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PnlCard";

            this.lbl = new System.Windows.Forms.Label();
            this.pct = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse();

            this.Controls.Add(this.pct);
            this.Controls.Add(this.lbl);

            // lbl
            this.lbl.AutoEllipsis = true;
            this.lbl.Location = new System.Drawing.Point(12, 119);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(204, 35);
            this.lbl.TabIndex = 0;
            this.lbl.Text = product.Name;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            // pct
            this.pct.Location = new System.Drawing.Point(12, 8);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(204, 105);
            this.pct.Image = Image.FromFile(Application.StartupPath + "/data/img/"+product.ImgPath);
            this.pct.SizeMode = PictureBoxSizeMode.Zoom;
             
            // bunifuElipse1
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;


        }

    }
}
