using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private  readonly Color color;
        private int radius;

        private int nthrown;

        public Sphere(Color color, int radius)
        {
            this.color = color;
            this.radius = radius;
        }

        public void Pop()
        {
            radius = 0;
    
        }

        public void Throw()
        {   
          
            if (radius > 0)
            {
                nthrown +=1;
            }


        }

        public int GetTimesThrown()
        {
            return nthrown;
        }

    }
}