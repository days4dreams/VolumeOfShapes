using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    public class VolumeCalculator
    {
        public VolumeCalculator()
        {   }

        public double VolumeOfCube(double s)
        {
            double cube = 1;
            cube = Math.Pow(s, 3);
            return cube;
        }

        public double VolumeOfCuboid(double length, double width, double height)
        {
            double cuboid = 1;
            cuboid = length * width * height;
            return cuboid;
        }

        public double VolumeOfSphere(double radius)
        {
            double sphere = 1;
            sphere = (4 / 3) * Math.PI * Math.Pow(radius, 3);
            return sphere;
        }

        public double VolumeofCylinder(double radius, double height)
        {
            double cylinder = 0;
            cylinder = Math.PI * Math.Pow(radius, 2) * height;
            return cylinder;
        }

        public double VolumeOfPrism(double baseA, double height, double length)
        {
            double prism = 0;
            prism = (0.5 * baseA * height) * length;
            return prism;
        }
    }
}
