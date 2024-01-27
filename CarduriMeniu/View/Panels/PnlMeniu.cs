using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using CarduriMeniu.Arbore;
using CarduriMeniu.Models;
using CarduriMeniu.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarduriMeniu.View.Panels
{
    public class PnlMeniu : Panel
    {
        Form1 form;

        Button btn1;
        Button btn2;
        Button btn3;
        Button btn4;
        Button btn5;
        Button btn6;
        Button btn7;
        Button btn8;

        string path;

        List<Arbore<Button>> listArbori;
        List<Button> buttonList;

        string tag;

        ServiceQuery serviceQuery;

        public PnlMeniu(Form1 form1)
        {

            this.form = form1;

            listArbori = new List<Arbore<Button>>();

            serviceQuery = new ServiceQuery();

            this.Name = "PnlMeniu";
            this.Size = new System.Drawing.Size(321, 971);
            this.BackColor = System.Drawing.Color.FromArgb(1, 79, 134);
            this.Font = new System.Drawing.Font("Century Gothic", 14);
            this.Location = new Point(0, 49);

            tag = "close";

            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);

            path = Application.StartupPath + @"/data/img/";  

            //btn1
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = FlatStyle.Flat;
            this.btn1.Size = new System.Drawing.Size(240, 80);
            this.btn1.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn1.ForeColor = Color.White;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Name = "btn1";

            //btn2
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = FlatStyle.Flat;
            this.btn2.Size = new System.Drawing.Size(240, 80);
            this.btn2.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.Name = "btn2";

            //btn3
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = FlatStyle.Flat;
            this.btn3.Size = new System.Drawing.Size(240, 80);
            this.btn3.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn3.Name = "btn3";

            //btn4
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = FlatStyle.Flat;
            this.btn4.Size = new System.Drawing.Size(240, 80);
            this.btn4.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn4.Name = "btn4";

            //btn5
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = FlatStyle.Flat;
            this.btn5.Size = new System.Drawing.Size(240, 80);
            this.btn5.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn5.Name = "btn5";

            //btn6
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = FlatStyle.Flat;
            this.btn6.Size = new System.Drawing.Size(240, 80);
            this.btn6.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn6.Name = "btn6";

            //btn7
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = FlatStyle.Flat;
            this.btn7.Size = new System.Drawing.Size(240, 80);
            this.btn7.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn7.Name = "btn7";

            //btn8
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = FlatStyle.Flat;
            this.btn8.Size = new System.Drawing.Size(240, 80);
            this.btn8.BackColor = System.Drawing.Color.FromArgb(44, 125, 160);
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn8.Name = "btn8";

            this.btn1.Text = "Telefoane, Tablete";
                this.btn2.Text = "Telefoane";
            this.btn3.Text = "Accesorii";
                this.btn4.Text = "Huse Telefoane";
                this.btn5.Text = "Tablete";
                this.btn6.Text = "Jocuri";
            this.btn7.Text = "Laptopuri";
                this.btn8.Text = "Laptopuri Gaming";

            //MessageBox.Show(btn1.Tag.ToString());

            Arbore<Button> arbor1 = new Arbore<Button>();
            arbor1.Add(null, btn1);
            arbor1.Add(btn1, btn2);
            arbor1.Add(btn1, btn3);
            arbor1.Add(btn1, btn5);
            arbor1.Add(btn3, btn4);

            Arbore<Button> arbor2 = new Arbore<Button>();
            arbor2.Add(null, btn6);

            Arbore<Button> arbor3 = new Arbore<Button>();
            arbor3.Add(null, btn7);
            arbor3.Add(btn7, btn8);


            listArbori.Add(arbor1);
            listArbori.Add(arbor2);
            listArbori.Add(arbor3);

            buttonList = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 };


            for (int i = 0; i < buttonList.Count; i++)
            {
                BunifuElipse bunifuElipse = new BunifuElipse();
                bunifuElipse.TargetControl = buttonList[i];
                bunifuElipse.ElipseRadius = 25;

                buttonList[i].ForeColor = Color.White;
                buttonList[i].Click += new EventHandler(btn_Click);

                Button button = new Button();
                button.BackColor = System.Drawing.Color.Transparent;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.Image = Image.FromFile(path + "right.png");
                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.Location = new System.Drawing.Point(200, 26);
                button.Size = new System.Drawing.Size(31, 27);
                button.Name = "btnImg"+(i+1).ToString();
                button.Click += new EventHandler(btnsImg_Click);
                button.Tag = buttonList[i];
                this.buttonList[i].Controls.Add(button);
                buttonList[i].Tag = tag;
                buttonList[i].Visible = false;
            }


            //  MessageBox.Show(arbor1.getNode().Children[3].Value.Name.ToString());
            createMenu();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

                List<Product> products = new List<Product>();

            if(btn.Text == "Telefoane")
            {
                products = serviceQuery.getProductWithCateg("tel");
            }
            else if (btn.Text == "Tablete")
            {
                products = serviceQuery.getProductWithCateg("tab");
            }
            else if (btn.Text == "Huse Telefoane")
            {
                products = serviceQuery.getProductWithCateg("hus");
            }
            else if (btn.Text == "Jocuri")
            {
                products = serviceQuery.getProductWithCateg("joc");
            }
            else if (btn.Text == "Laptopuri Gaming")
            {
                products = serviceQuery.getProductWithCateg("gam");
            }

            if(products.Count != 0)
            {
                this.form.removePnl("PnlCarduri");
                this.form.Controls.Add(new PnlCarduri(form,products));
            }
        }

        public void invisibleAll()
        {

            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Visible = false;
            }

        }

        public Button findBtn(string text)
        {
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Text.Equals(text))
                {
                    return buttonList[i];
                }
            }
            return null;
        }

        Button findByChild(Button button)
        {

            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Controls[0] == button)
                {
                    return buttonList[i];
                }
            }

            return null;
        }

        public void btnsImg_Click(object sender, EventArgs e)
        {

            Button btn = (Button)((Button)sender).Tag;

            //MessageBox.Show(btn.Name);

            if (btn.Tag.ToString().Equals("close"))
            {
                Button btnImg = (Button)btn.Controls[0];
                btnImg.Image = Image.FromFile(Application.StartupPath + @"/data/img/down.png");
                for (int i = 0; i < listArbori.Count; i++)
                {
                    TreeNode<Button> node = new TreeNode<Button>();
                    node = listArbori[i].findByValue(listArbori[i].getNode(), btn);
                    if (node != null)
                    {
                        List<Button> list = new List<Button>();
                        list = listArbori[i].getTsByChildren(node);

                        list[0].Location = new Point(btn.Location.X + 40, btn.Location.Y + 85);
                        list[0].Visible = true;
                        for (int k = 1; k < list.Count; k++)
                        {
                            list[k].Location = new Point(btn.Location.X + 40, list[k - 1].Location.Y + 85);
                            list[k].Visible = true;
                        }
                    }
                }

                btn.Tag = "open";
                /*
                                buttonList[5].Visible = false;
                                buttonList[6].Visible = false;*/


            }
            else if (btn.Tag.ToString().Equals("open"))
            {

                Button btnImg = (Button)btn.Controls[0];
                btnImg.Image = Image.FromFile(Application.StartupPath + @"/data/img/right.png");
                for (int i = 0; i < listArbori.Count; i++)
                {

                    TreeNode<Button> node = new TreeNode<Button>();
                    node = listArbori[i].findByValue(listArbori[i].getNode(), btn);
                    if (node != null)
                    {
                        List<Button> list = new List<Button>();
                        list = listArbori[i].getTsByAllChildren(node);
                        int s = btn.Location.Y;
                        for (int k = 0; k < list.Count; k++)
                        {
                            /* s += 67;
                             list[k].Location = new Point(btn.Location.X + 40, s);*/
                            list[k].Visible = false;
                        }
                    }
                }


                btn.Tag = "close";
            }

            int ct = 9999;
            Button button = btn;
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (btn == buttonList[i]) ct = i;

                if (buttonList[i].Visible == true && i > ct)
                {
                    buttonList[i].Location = new Point(buttonList[i].Location.X, button.Location.Y + 85);
                    button = buttonList[i];
                }
            }
            // MessageBox.Show(parent.Name);
        }

        public void createMenu()
        {
            int s = 33;
            for (int i = 0; i < listArbori.Count; i++)
            {
                s += 85;
                listArbori[i].getNode().Value.Location = new Point(0, s);
                listArbori[i].getNode().Value.Visible = true;
                if (listArbori[i].getNode().Children.Count == 0)
                {
                    listArbori[i].getNode().Value.Controls[0].Visible = false;
                }


            }

            for (int i = 1; i < buttonList.Count; i++)
            {
                // i = 3;
                for (int k = 0; k < listArbori.Count; k++)
                {

                    TreeNode<Button> node = listArbori[k].findNode(listArbori[k].getNode(), buttonList[i]);
                    if (node != null)
                    {
                        if (node.Children.Count == 0)
                            node.Value.Controls[0].Visible = false;
                    }
                }
            }

        }




    }
}
