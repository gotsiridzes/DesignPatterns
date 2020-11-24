using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory
{
    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point() { }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        #region Factory Method
        
        //private Point(double x, double y)
        //{
        //    X = x;
        //    Y = y;
        //}

        //// Factory Method for point class
        //public static Point NewCartesianPoint(double x, double y)
        //{
        //    return new Point(x, y);
        //}

        //public static Point NewPolarPoint(double rhoe, double theta)
        //{
        //    return new Point(rhoe * Math.Cos(theta), rhoe * Math.Sin(theta));
        //}
        
        #endregion
    }
}
