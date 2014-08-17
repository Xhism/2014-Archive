using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    /* AUTHOR NOTES: I wrote a Test method for these exercises, 
     * however I could not be bothered writing one for the next few.
     */

    /* 01
     * Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
     * Implement the ToString() to enable printing a 3D point.
     */

    /* 02
     * Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
     * Add a static property to return the point O.
     */

    /* 03
     * Write a static class with a static method to calculate the distance between two points in the 3D space.
     */

    /* 04
     * Create a class Path to hold a sequence of points in the 3D space. 
     * Create a static class PathStorage with static methods to save and load paths from a text file. 
     * Use a file format of your choice.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Point3D.Point3DTest();
        }
    }
}
