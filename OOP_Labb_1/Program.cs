﻿using static OOP_Labb_1.Circle;

namespace OOP_Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates two reference objects of the Class Circle.
            // One with value 5 and other with value 6
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            // New object instanication of class triangle
            // passing along the value 5 and 7
            Triangle triangle = new Triangle(5, 7);
            // Call the methods through object and store to float variables
            float area1 = circle1.GetArea();
            float area2 = circle2.GetArea();
            float circum1 = circle1.GetCircum();
            float circum2 = circle2.GetCircum();
            float volume1 = circle1.GetVolumeSpehere();
            float volume2 = circle2.GetVolumeSpehere();
            float areaSphere1 = circle1.GetAreaSphere();
            float areaSphere2 = circle2.GetAreaSphere();
            float triangleArea = triangle.GetArea();
            // Except this one is double
            double triangleHypo = triangle.GetHypoRight();
            // print out the results
            Console.WriteLine("Olika beräkningar av en cirkel med radie 5.");
            Console.WriteLine($"Arean: {area1}");
            Console.WriteLine($"Omkretsen: {circum1}");
            Console.WriteLine("Olika beräkningar om det var en boll");
            Console.WriteLine($"Volym: {volume1}");
            Console.WriteLine($"Arean: {areaSphere1}");
            Console.WriteLine("\nOlika beräkningar av en cirkel med radie 6.");
            Console.WriteLine($"Arean: {area2}");
            Console.WriteLine($"Omkretsen: {circum2}");
            Console.WriteLine("Olika beräkningar om det var en boll");
            Console.WriteLine($"Volym: {volume2}");
            Console.WriteLine($"Arean: {areaSphere2}");
            Console.WriteLine("\nBeräkningar av triangel med närliggande (5) och motstående (7).");
            Console.WriteLine($"Arean: {triangleArea}");
            Console.WriteLine($"Hypotenusan: {triangleHypo}");
            Console.ReadKey();
        }
    }
}
