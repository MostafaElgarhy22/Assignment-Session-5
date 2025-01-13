using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session_5.First_Project
{
    internal class Point_3D : IComparable<Point_3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point_3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point_3D()
        {
            this.Z = 0;
        }

        public override string ToString()
        {
            return $"Points is {X}, {Y}, {Z}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point_3D)
            {
                return X == ((Point_3D)obj).X && Y == ((Point_3D)obj).Y && Z == ((Point_3D)obj).Z ;
            }
            return false ;
        }
 
        public int CompareTo(Point_3D other)
        {
            if (X != other.X) return X.CompareTo(other.X);
            if (Y != other.Y) return X.CompareTo(other.Y);
            return Z.CompareTo(other.Z);
        }

        public object Clone()
        {
            return new Point_3D(X, Y, Z);
        }
    }


}
