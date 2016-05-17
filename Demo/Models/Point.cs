using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QCLM
{
    public class Point
    {

        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Value { get; set; }
        #endregion

        #region Format
        public override string ToString()
        {
            return String.Format("{0},{1},{2}", X, Y, Z);
        }
        public string ToXYString()
        {
            return String.Format("{0},{1}", X, Y);
        }
        #endregion

        #region Construction

        // Instance constructor
        public Point()
        {
        }

        // Instance constructor
        public Point(double _x, double _y, double _z)
        {
            X = Math.Round(_x, 2);
            Y = Math.Round(_y, 2);
            Z = Math.Round(_z, 3);
        }

        // Copy constructor.
        public Point(Point _p)
        {
            X = _p.X;
            Y = _p.Y;
            Z = _p.Z;
        }

        // Copy constructor.
        public Point(Point _p, double _v)
        {
            X = _p.X;
            Y = _p.Y;
            Z = _p.Z;
            Value = _v;
        }

        // Copy constructor.
        public Point(double _x, double _y, double _z, double _v)
        {
            X = Math.Round(_x, 2);
            Y = Math.Round(_y, 2);
            Z = Math.Round(_z, 3);
            Value = _v;
        }
        #endregion

    }
}
