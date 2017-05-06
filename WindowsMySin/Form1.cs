using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMySin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txt_x.Text);
            int n = int.Parse(txt_n.Text);
            //викликметодаобчислення sin(x) ізбіблиотеки
            double my_sinus = MyLib.MySin.Sin(x, n); 
            double sinus = Math.Sin(x);
            
            txt_y1.Text = my_sinus.ToString();
            txt_y2.Text = sinus.ToString();

            double me = MyLab.MyCos.rer(x);
            txt_y3.Text =me.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public double MyCosinus { get; set; }
    }
}
