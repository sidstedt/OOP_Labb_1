using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_1
{
    internal class Triangle
    {
        // instanciate new variables
        public int _CathethusA;
        public int _CathethusB;
        // Constructor to store values in the class
        public Triangle(int cathethusA, int cathethusB)
        {
            _CathethusA = cathethusA;
            _CathethusB = cathethusB;
        }
        // method to calculate are
        public float GetArea()
        {
            return (_CathethusA * _CathethusB) / 2;
        }
        // method to calculate the length of the hypotenuse
        public double GetHypoRight()
        {
            return Math.Sqrt(Math.Pow(_CathethusA, 2) + Math.Pow(_CathethusB, 2));
        }
    }
}
