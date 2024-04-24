using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    
    public class Sphere
    {
        private  readonly Color color;
        private int radius;
        private int nthrown;

        public int Radius
        {   
            get { return radius; }
            set { radius = value; }
        }

        public void Pop()
        {
            radius = 0;
    
        }

        public int Nthrown
        {
            get 
            {
                return nthrown;
            }

        }

        public void Throw()
        {   
          
            if (radius > 0)
            {
                nthrown +=1;
            }


        }
   

    }
}