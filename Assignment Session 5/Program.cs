using Assignment_Session_5.First_Project;
using Assignment_Session_5.Second_Project;

namespace Assignment_Session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project


            //Point_3D point_3D = new Point_3D(15, 4, 6);
            //Console.WriteLine($"{point_3D.ToString()}");

            //Point_3D PC = (Point_3D)PC.Clone();
            //Console.WriteLine(PC);

            //Point_3D[] P = new Point_3D[]
            //{
            //   new Point_3D(5, 6,10),
            //   new Point_3D(10,32,7),
            //   new Point_3D(1,1,1),
            //   new Point_3D(1,8,9)
            //};

            //Array.Sort(P);
            //foreach (var point in P)
            //{
            //    Console.WriteLine(point.ToString());
            //}

            #endregion
            #region Second Project

            int Addition = Maths.Add(20, 10);
            Console.WriteLine($"Addition = {Addition}");

            int Subtraction = Maths.Subtract(20, 10);
            Console.WriteLine($"Subtraction = {Subtraction}");

            int Multiplication = Maths.Multiply(20, 10);
            Console.WriteLine($"Multiplication = {Multiplication}");

            double Division = Maths.Divide(20, 10);
            Console.WriteLine($"Division = {Division}");
            #endregion
        }
    }
}
