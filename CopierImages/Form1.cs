

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopierImages
{
    public partial class Form1 : Form
    {
        public int ThreadNumber { get; set; }
        public long Sleep { get; set; }
        public Bitmap Image { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            Image = new Bitmap(openFileDialog1.FileName);
            lbl_file.Text = openFileDialog1.FileName;
           // ImageConverter converter = new ImageConverter();
           // ByteArray = (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            ThreadNumber = (int)ipt_threadNumber.Value;
            Sleep = long.Parse(ipt_sleep.Text);
            if(ThreadNumber != 0 && Image != null)
            {
                ImagePanel ip = new ImagePanel(ThreadNumber, Sleep, Image);
                ip.ShowDialog();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
