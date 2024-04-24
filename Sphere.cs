using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Sphere
    {
        public int red;
        public int green;
        public int blue;
        public int alpha;

        public Color(int red, int green, int blue, int alpha) 
        {
            this.red = SetRed();
            this.green = SetGreen();
            this.blue = SetBlue();
            this.alpha = SetAlpha();

        }

        public int SetRed(int red)
        {

            return red;
        }

        public int SetGreen(int green)
        {
            return green;
        }

        public int SetBlue(int blue)
        {
            return blue;
        }

        public int SetAlpha(int alpha)
        {
            return alpha;
        }

        public int GetGrey(int red, int green, int blue)
        {
            int grey;

            grey = (red +green +blue)/ 3;

            return grey;
        }
    }
}