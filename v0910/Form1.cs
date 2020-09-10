using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0910
{
    public partial class Form1 : Form
    {
        int[] vx = new int[3];
        int[] vy = new int[3];
        Label[] labels = new Label[3];
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            for(int i =0;i<3;i++)
            {
                vx[i] = rand.Next(-15, 16);
                vy[i] = rand.Next(-15, 15);

                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "★";
                Controls.Add(labels[i]);

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
