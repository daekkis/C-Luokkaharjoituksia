using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuokkaHarjoitus
{
    
 
        class Hooman
        {
            // Define properties of Hooman ie. fields
            public string name = "Essi Esimerkki";
            public int age = 30;
            public string gender = "Emäntä";

            // Default constructor w/o agruments
            // No need to define, will be created automatically
            public Hooman()
            {
                
            }

            // Constructor with one argument

            public Hooman(string name)
            {
                this.name = name;
            }

            // Constructor wiht 2 agruments
            public Hooman(string name, int age) 
            {
                this.name = name;
                this.age = age;
            }

            // Constructor with 3 agruments
            public Hooman(string name, int age, string gender) 
            {
                this.name = name;
                this.age = age;
                this.gender = gender;

            }

            // A method to say something 
            public void SayOpinion()
            {
            Console.WriteLine("Voi lemmikit ne on elämän suola");
            }
        }

        class CatOwner : Hooman
        {

            public void SayOpinion()
            {
                Console.WriteLine("Kissat ovat itsenäisiä ja pitivät hiiret loitolla"); 
            }

        }



        internal class Program
        { 
    
            static void Main(string[] args)
            {
               // Create (instantiate) a hooman object from Hooman class
                Hooman owner = new Hooman("Ossi Omistaja", 35, "isäntä");

                // Call the SayOpinion method
                owner.SayOpinion();

                // Save owners name property to a variable
                string who = owner.name;

                // Test it by echoing it to a console
                Console.WriteLine("totesi " + who);

                // Create a new catowner object
                CatOwner catOwner = new CatOwner();

                // Use catowners SayOpinion method
                catOwner.SayOpinion();

                // Keep the window open until enter pressed
                Console.ReadLine(); 

                

            
            }
        } 
}
