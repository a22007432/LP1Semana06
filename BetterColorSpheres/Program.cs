using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color();
            color1.Red = 1;
            color1.Green = 1;
            color1.Blue = 1;
            
            Color color2 = new Color();
            color2.Red = 100;
            color2.Green = 11;
            color2.Blue = 3;

            Color color3 = new Color();
            color3.Red = 3;
            color3.Green = 3;
            color3.Blue = 3;


            //Sphere sphere1 = new Sphere(color1, 4);
            Sphere sphere1 = new Sphere();
            sphere1.Radius = 0;

            Sphere sphere2 = new Sphere();
            sphere2.Radius = 2;

            Sphere sphere3 = new Sphere();
            sphere3.Radius = 4;
            


            sphere1.Throw();
            sphere1.Throw();
            sphere1.Pop();
            sphere1.Throw();


            sphere2.Pop();
            sphere2.Throw();

            sphere3.Throw();
            sphere3.Throw();
            sphere3.Throw();


            Console.WriteLine($"Times sphere number 1 was thrown: {sphere1.Nthrown}");

            Console.WriteLine($"Times sphere number 2 was thrown: {sphere2.Nthrown}");

            Console.WriteLine($"Times sphere number 3 was thrown: {sphere3.Nthrown}");
        
        }
    }
}
