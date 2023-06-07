// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System;
using Ex_ClassPoint2D_and_ClassPoint3D;

namespace Points
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point2D p2d = new Point2D(1.0f, 2.0f);
            Console.WriteLine(p2d.ToString());
            Point3D p3d = new Point3D(3.0f, 4.0f, 5.0f);
            Console.WriteLine(p3d.ToString());
            
            Test(p2d, p3d);
            
            p2d.SetX(11.0f);
            p2d.SetY(12.0f);
            p2d.SetXY(13.0f, 14.0f);
            Console.WriteLine(p2d.ToString());
            p3d.SetX(21.0f);
            p3d.SetY(22.0f);
            p3d.SetZ(23.0f);
            p3d.SetXY(24.0f, 25.0f);
            p3d.SetXYZ(26.0f, 27.0f, 28.0f);
            Console.WriteLine(p3d.ToString());
            
            Test(p2d, p3d);

        }

        public static void Test(Point2D p2d, Point3D p3d)
        {
            Console.WriteLine("p2d.GetX() = " + p2d.GetX());
            Console.WriteLine("p2d.GetY() = " + p2d.GetY());
            Console.WriteLine("p2d.GetXY() = " + p2d.GetXY()[0] + "," + p2d.GetXY()[1]);
            Console.WriteLine("p3d.GetX() = " + p3d.GetX());
            Console.WriteLine("p3d.GetY() = " + p3d.GetY());
            Console.WriteLine("p3d.GetZ() = " + p3d.GetZ());
            Console.WriteLine("p3d.GetXY() = " + p3d.GetXY()[0] + "," + p3d.GetXY()[1]);
            Console.WriteLine("p3d.GetXYZ() = " + p3d.GetXYZ()[0] + "," + p3d.GetXYZ()[1] + "," + p3d.GetXYZ()[2]);
        }
    }
}