using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterClassLibrary
{
    public class Theater
    {
        /*
        Multi Theater complex, could potentially be an array of multi-dimensional arrays ie:
        public static Seat[][ , ] complex = new Seat[3][,];
        public void Setup()
        {
            complex[0] = new Seat[10, 10];
            complex[1] = new Seat[10, 10];
            complex[2] = new Seat[10, 10];
        }
        */
        public static Seat[,] theater1 = new Seat[10, 10];
        public static Seat[,] theater2 = new Seat[10, 10];
        public static Seat[,] theater3 = new Seat[10, 10];


        
    }
}
