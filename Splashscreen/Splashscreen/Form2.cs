using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splashscreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, 16);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Location = new Point(1, 365);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(1, 104);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Location = new Point(1, 365);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(0, 192);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Location = new Point(1, 365);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Location = new Point(1, 279);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.Location = new Point(1, 365);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
