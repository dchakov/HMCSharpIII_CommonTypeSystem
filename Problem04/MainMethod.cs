﻿//Problem 4. Person class• Create a class  Person  with two fields – name and age. Age can be left unspecified (may contain  null  value. Override  ToString()  to display the information of a person and if age is not specified – to say so.
//• Write a program to test this functionality.

using System;

namespace Problem04
{
    class MainMethod
    {
        static void Main()
        {
            Person ivan = new Person("Ivan Ivanov", 25);
            Person niki = new Person("Niki Kostov");
            Person iva = new Person("Iva Doneva", null);
            Console.WriteLine(ivan);
            Console.WriteLine(niki);
            Console.WriteLine(iva);
        }
    }
}