using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_1
{
    internal class Circle
    {
        // creating variables for the class and set value to _Pi
        public int _Radius;
        public float _Pi = 3.141f;
        // constructor
        public Circle(int radius)
        {
            // copy the input value to the class variable
            _Radius = radius;
        }
        // Method to calculate the area
        public float GetArea()
        {
            // return the calculated variable
            return _Pi * _Radius * _Radius;
        }
        // Method to calculate circumference
        public float GetCircum()
        {
            return 2 * _Pi * _Radius;
        }
        // Method to calculate volume of spehere
        public float GetVolumeSpehere()
        {
            return 4f / 3f * _Pi * (_Radius * _Radius * _Radius);
        }
        // method to calculate area of sphere
        public float GetAreaSphere()
        {
            return 4 * _Pi * (_Radius * _Radius);
        }
    }
}
