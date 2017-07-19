using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopierImages
{
    public partial class ImagePanel : Form
    {
        private delegate void CallMessageDelegate();
        private delegate void MethodDelegate(Point p);
        private static Bitmap _original;
        //private static int _cont = 0;
        public Bitmap Original
        {
            get {return _original; }
            set {
                _original = value; 
                img_original.Image = value;
            }
        }
        
        private static Bitmap _copy;
        public Bitmap Copy 
        {
            get { return _copy;  }
            set { _copy = value; img_new.Image = value; }
        }

        private Task[] Tasks;
        public static bool _called = false;

        public int ThreadNumber{get;set;}
        public long Sleep { get; set; }

        public static CopyController Controller;
        
        public ImagePanel(int threadNumber, long sleep, Bitmap image)
        {
            
            InitializeComponent();
            ThreadNumber = threadNumber;
            Sleep = sleep;
            Original = image;
            Controller = CopyController.StartNewController(image);
            Copy = new Bitmap(Original.Width, Original.Height);
            Copy.MakeTransparent();
                
            
        }



        public void StartCopyThreads()
        {
            Tasks = new Task[ThreadNumber];
            
            for(int i = 0; i < ThreadNumber; i++)
            {
                Tasks[i] = new TaskFactory().StartNew(() =>
                {
                    Run();
                    Thread.Sleep((int)Sleep);
                });
            }
            /*try
            {
                Task.WaitAll(Tasks);
            }
            catch (AggregateException ex)
            {
                CallMessage();
            }*/
        }
       
        public void Run()
        {
            while(!Controller.IsFinished())
            {
             
                if (InvokeRequired) {Invoke(new MethodDelegate(UpdateImage), Controller.GetNotUsedRandomPosition());}
            }
            
        }

        public void CallMessage()
        {
            MessageBox.Show("Fim");
        }
        public void UpdateImage(Point p)
        {
           
            Copy.SetPixel(p.X, p.Y, Original.GetPixel(p.X, p.Y));
            Controller.SetPosition(p);
           
            //if (_cont <400) {_cont++; return; }
            //else
            //{
               
                img_new.Image = Copy;
              //  _cont = 0;
            //}
        }
        public void UpdateImage() { img_new.Image = Copy; }
 

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartCopyThreads(); 
        }
    }
}
