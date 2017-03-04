using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
               VolumeCalculator VolumeCalculator = new VolumeCalculator();
               double side = 2;
               double length = 3;
               double height = 4;
               double width = 5;
               double baseA = 6;
               double radius = 7;

                Console.WriteLine("Demonstrating Math in C Sharp");
                Console.WriteLine("Calculating the volume of a cube.");
                Console.WriteLine("When the cube's side measures: " + side + "cm");

                double volumeOfCube = 1;
                volumeOfCube = VolumeCalculator.VolumeOfCube(side);
                Console.WriteLine("The volume of the cube will be: " + volumeOfCube + "cm2");

                Console.WriteLine("Calculating the volume of a cuboid.");
                Console.WriteLine("When the cubdoid's length is " + length + "cm, width is " + width + "cm and height is " + height + "cm");
            
                double volumeOfCuboid = 1;
                volumeOfCuboid = VolumeCalculator.VolumeOfCuboid(length, width, height);
                Console.WriteLine("Volume of cuboid: " + volumeOfCuboid);

                Console.WriteLine("Calculating the volume of a Sphere.");
                Console.WriteLine("When the sphere's radius is " + length + "cm");

                double volumeOfSphere = 1;
                volumeOfSphere = VolumeCalculator.VolumeOfSphere(radius);
                Console.WriteLine("Volume of sphere: " + volumeOfSphere);


            Console.ReadKey();
                
           
         }

      }
}
