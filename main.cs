// Created by: Jaejun Lee
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int angle1;
        int angle2;
        int angle3;

        Console.Write("Enter the angle of the triangle.");
        Console.WriteLine("");
        Console.WriteLine("Angle 1: ");
        angle1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Angle 2: ");
        angle2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Angle 3: ");
        angle3 = int.Parse(Console.ReadLine());

        if ((angle1 == angle2 && angle2 == angle3))
            Console.WriteLine("The triangle is an equilateral triangle.");
        else if(angle1 == angle2 || angle2 == angle3 || angle1 == angle3)
            Console.WriteLine("The triangle is an isosceles triangle.");
        else if(angle1 == 0 || angle2 == 0 || angle1 == 0)
            Console.WriteLine("This is not a triangle.");
        else
            Console.WriteLine("The triangle is a scalene triangle.");
    }
}