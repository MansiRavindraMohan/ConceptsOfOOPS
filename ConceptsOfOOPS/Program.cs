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

            MethodTypes methodTypes= new MethodTypes();
            methodTypes.NonParameterMethod();
            methodTypes.ParameterMethod(25,"Komal");
            Console.ReadLine();
        }
    }
}
