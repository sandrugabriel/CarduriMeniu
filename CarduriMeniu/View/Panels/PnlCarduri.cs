using CarduriMeniu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu.View.Panels
{
    public class PnlCarduri : Panel
    {

        Form1 form;
        List<Product> products;

        public PnlCarduri(Form1 form1, List<Product> products1)
        {
            this.form = form1;
            this.products = products1;

            this.Size = new System.Drawing.Size(1599, 971);
            this.Location = new System.Drawing.Point(321, 49);
            this.Name = "PnlCarduri";
            this.BackColor = System.Drawing.Color.FromArgb(169, 214, 229);

            createCard(4);

        }


        public void createCard(int nr)
        {
            this.Controls.Clear();
            int x = 53, y = 53, ct = 0;

            foreach (Product p in products)
            {

                ct++;
                PnlCard pnlCard = new PnlCard(form,p);
                pnlCard.Location = new System.Drawing.Point(x, y);

                this.Controls.Add(pnlCard);
                x += 200;

                if (ct % nr == 0)
                {
                    x = 53;
                    y += 250;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }
        }


    }
}
