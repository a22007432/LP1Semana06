using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        private int red;
        private int green;
        private  int blue;
        private  int alpha;
        
        public int Red
        {
            get { return red; }
            set { red = value; }
        }
        
        public int Green
        {   
            get { return green; }
            set { green = value; }
        }

        public int Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public int GetGrey(int red, int green, int blue)
        {
                int grey;

                grey = (red +green +blue)/ 3;

                return grey;
        }
    }
}