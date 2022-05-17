using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace Camer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


            DialogResult dr1 = MessageBox.Show("Do you Want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr1 == DialogResult.Yes)
            {
                Application.Exit();
                Application.ExitThread();
            }
        }
        FilterInfoCollection filterInfoCollection;

        VideoCaptureDevice videoCaptureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                comboBox1.Items.Add(filterInfo.Name);
           // comboBox1.SelectedIndex = 1;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrameX;
            videoCaptureDevice.Start();
        }
        private void VideoCaptureDevice_NewFrameX(object sender, NewFrameEventArgs eventArgs)
        {



            Blur filter = new Blur();
            // apply the filter
            filter.ApplyInPlace((Bitmap)eventArgs.Frame.Clone());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            do
            {
               

            } while (timer1.Interval < 15);
        }
    }

}
