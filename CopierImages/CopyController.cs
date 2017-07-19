using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopierImages
{
    public class CopyController
    {
     
        private bool[,] _positions;
        private  int _cont;
        private int _pixels;
        
        public int Width { get; set; }
        public int Height { get; set; }


        public Bitmap Original
        {
            set 
            {
             
                Width = value.Width;
                Height = value.Height;
                _pixels = Width * Height;
                _positions = new bool[Width,Height];
            }
        }
       
        
        public static CopyController StartNewController(Bitmap bitmap){ return new CopyController(bitmap);}

        private CopyController(Bitmap bitmap) {StartController(bitmap);  }

        public void StartController(Bitmap bitmap) { _cont = 0; Original = bitmap; }

        public bool IsFinished(){ return (_cont >= _pixels);}

        public void SetPosition(Point point) 
        {
            //if (IsFinished() || ) { return false; ; }
            if (_positions[point.X, point.Y]) { return ; }
            _positions[point.X,point.Y] = true;
            _cont++; //return true;
            //return true;
        }

        public  Point GetNotUsedRandomPosition()
        {
            bool selected = false;
            Random r = new Random();
            int x = r.Next(0, Width);
            int y = r.Next(0, Height);
            while(!selected)
            {
                if (!_positions[x, y]) { return new Point(x,y); }
                if (x < Width-1) { x++; } else { x = 0; }
                if (!_positions[x, y]) { return  new Point(x,y);}
                if (y < Height-1) { y++; } else { y = 0; }
                
            }
            return new Point(0,0); 
        }
       
    }
}
