﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfOOPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ClassAndObject classAndObject = new ClassAndObject();
            //classAndObject.MethodClass();

            //VariableTypes variableTypes = new VariableTypes();
            //variableTypes.VariableMethod();

            //MethodTypes methodTypes= new MethodTypes();
            //methodTypes.NonParameterMethod();
            //methodTypes.ParameterMethod(25,"Komal");

            //Car car = new Car();
            //car.Start();
            //car.Stop();
            //Console.WriteLine(car.carName = "XUV");
            //Console.WriteLine(car.year = 2022);
            //car.Drive();

            //1)Method Overloading
            Rectangle rectangle = new Rectangle();
            rectangle.PrintArea(3, 5);
            rectangle.PrintArea(5);
            rectangle.PrintArea(6, 2.5);
            rectangle.PrintArea(5.5);
            //2)Method Overriding
            Dog dog = new Dog();
            dog.Sound();
            Console.ReadLine();
        }
    }
}
