﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuokkaHarjoitus
{
    
    {
        class Hooman
        {
            // Define properties of Hooman ie. fields
            string name = "Essi Esimerkki";
            int age = 30;
            string gender = "Emäntä";

            Hooman()
            {
                
            }

            // Constructor with one argument

            Hooman(string name)
            {
                this.name = name;
            }

            // Constructor wiht 2 agruments
            Hooman(string name, int age) 
            {
                this.name = name;
                this.age = age;
            }

            // Constructor with 3 agruments
            Hooman(string name, int age, string gender) 
            {
            this.name = name;
            this.age = age;
            this.gender = gender;
            }
        }
        internal class Program
        { }
        static void Main(string[] args)
        {
        }
    }
}
