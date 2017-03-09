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
            //calls upon VolumeCalculator class, which contain mathematical equations
            //dummy values assigned to length, height etc values for purpose of demonstrating the maths

               Actions myWrite = new Actions();
            //calls the Actions class, which imitates 'writeline'
                
                myWrite.Write("Demonstrating Math in C Sharp");
            //introduction to program

                myWrite.Write("Please indicate which calculation you would like to see from the list: \r\n A) Cube \r\n B) Cuboid \r\n C) Sphere \r\n D) Cylinder \r\n E) Prism ");
            //presents a list of options to user

                string choice = Console.ReadLine();
                choice = choice.ToLower();
            //accepts user input and converts to lowercase

            if (choice == "a" || choice == "cube")
            {

                Console.WriteLine("Calculating the volume of a cube.");
                Console.WriteLine("When the cube's side measures: " + side + "cm");
                double volumeOfCube = 1;
                volumeOfCube = VolumeCalculator.VolumeOfCube(side);
                Console.WriteLine("The volume of the cube will be: " + volumeOfCube + "cm2");
                //output for cube calculation
            }

            else if (choice == "b" || choice == "cubiod")
            {
                Console.WriteLine("Calculating the volume of a cuboid.");
                Console.WriteLine("When the cubdoid's length is " + length + "cm, width is " + width + "cm and height is " + height + "cm");
                double volumeOfCuboid = 1;
                volumeOfCuboid = VolumeCalculator.VolumeOfCuboid(length, width, height);
                Console.WriteLine("Volume of cuboid: " + volumeOfCuboid);
                //output for cubiod calculation
            }

            else if (choice == "c" || choice == "sphere")
            {
                Console.WriteLine("Calculating the volume of a Sphere.");
                Console.WriteLine("When the sphere's radius is " + radius + "cm");
                double volumeOfSphere = 1;
                volumeOfSphere = VolumeCalculator.VolumeOfSphere(radius);
                Console.WriteLine("Volume of sphere: " + volumeOfSphere);
                //output for sphere calculation
            }

            else if (choice == "d" || choice == "cylinder")
            {
                Console.WriteLine("Calculating the volume of a Cylinder.");
                Console.WriteLine("When the cylinder's radius is " + length + "cm" + " and its height is " + height + "cm");
                double volumeOfCylinder = 1;
                volumeOfCylinder = VolumeCalculator.VolumeofCylinder(radius, height);
                Console.WriteLine("Volume of cylinder: " + volumeOfCylinder);
                //output for cylinder calculation
            }

            else if (choice == "e" || choice == "prism")
            {
                Console.WriteLine("Calculating the volume of a Prism.");
                Console.WriteLine("When the prisms base is " + baseA + "cm" + " and its height is " + height + "cm");
                double volumeOfPrism = 1;
                volumeOfPrism = VolumeCalculator.VolumeOfPrism(baseA, height, length);
                Console.WriteLine("Volume of Prism: " + volumeOfPrism);
                //output for prism calculation
            }

            else
            {
                Console.WriteLine("Sorry, I didnt understand your choice");
            }



                Console.ReadKey();
           //pauses close of application  
           
         }

      }
}
