﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DZ2DZ3.Program;
using static DZ2DZ3.MyEnum;
using System.Runtime.Intrinsics.X86;
using System.Net.Cache;
using System.Runtime.CompilerServices;

namespace DZ2DZ3
{
    public class User
    {
        private string firstName;
        private string lastName;
        private Gender gender;
        private string a;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age { get; }


        public MyEnum.Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public User()
        {
            Console.WriteLine(" Please input your gender. If male enter to F1, if female enter to F2, if undefined enter to F3");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey gend = keyInfo.Key;
            if (gend == ConsoleKey.F1)
            {
                Gender = Gender.male;
            }
            else if (gend == ConsoleKey.F2)
            {
                Gender = Gender.female;
            }
            else if (gend == ConsoleKey.F3)
            {
                Gender = Gender.undefined;
            }
            Console.WriteLine("Please enter your year of born.");
            try
            {
                int yearOfBirth = int.Parse(Console.ReadLine());
                Age = 2024 - yearOfBirth;
                if (Age <= 10)
                {
                    a = "a baby!";
                }
                else
                {
                    a = Age.ToString();
                }
                Console.WriteLine($"User: Name={Name}, Age={a}");
            }
            catch (FormatException)
            {
                Console.WriteLine( "You entered an incorrect input. Please enter only numbers.");
            }
            ToString();
        }
        public override string ToString()
        {
            return $"User: Name={Name}, Age={a}";

        }
        public void Name()
        {
            Console.WriteLine($"Hi, my name is {FirstName}  and lastname  {LastName} . I am {a} years old. . I am a {Gender} ");
        }
    }
}
