using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class Form1 : Form
    {
        List<Panel> List = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ButPlus_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel()
            {
                Size = new Size(562,32)
            };
            TextBox text = new TextBox()
            {
                Parent = panel,
                Size = new Size(415,20),
                Location = new Point(3,3)
            };
            CheckBox check = new CheckBox()
            {
                Parent = panel,
                Size = new Size(15,14),
                Location = new Point(442, 3)
            };
            Button but = new Button()
            {
                Parent = panel,
                Size = new Size(75, 23),
                Location = new Point(484,3),  
                Text = "Smazat"
            };
            but.Click += new System.EventHandler(this.ButSmazat_Click);
            Controls.Add(panel);
            List.Add(panel);
            Serazeni();
        }

        private void ButSmazat_Click(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            Panel pan = (Panel)butt.Parent;
            Controls.Remove(pan);
            List.Remove(pan);
            Serazeni();
        }

        private void Serazeni()
        {
            foreach (Control x in this.Controls)
            {
                if(x.GetType().Name == "Panel")
                {
                    x.Location = new Point(56, 100 + List.IndexOf((Panel)x)*32);
                }
            }
        }
    }
}
