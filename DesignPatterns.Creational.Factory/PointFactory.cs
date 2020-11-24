using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factory
{
    /// <summary>
    /// Creates instance of Point based on cartesian or polar system
    /// </summary>
    public static class PointFactory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rhoe, double theta)
        {
            return new Point(rhoe * Math.Cos(theta), rhoe * Math.Sin(theta));
        }
    }
}
