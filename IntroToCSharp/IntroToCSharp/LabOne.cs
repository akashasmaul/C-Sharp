using System;

namespace IntroToCSharp
{
     class LabOne
    {
        static void Main(string[] args)
        { /*
            String name = "Peter Parker";
            int age = 24;

            Console.WriteLine("\nMy name is " + name);
            Console.WriteLine("I am " + age + " years old\n");  
            
            string studentName = "Avro";
            char studentGrade = 'A';
            int studentAge = 21;
            double studentCgpa = 5;
            bool isMale = true;

            Console.WriteLine(40); //constant - Not Secured    

            Console.WriteLine("I am Avro");
            Console.WriteLine("I am Alen");
            Console.Write("La La Laa");
            Console.Write(" I am a boy.");
            Console.WriteLine(" I am single since \t born");
            Console.WriteLine("They call me \"weird\"");     
            
            Console.WriteLine("What's up!");
            Console.Write("How you doin");
            Console.Write("!\n");

            Console.WriteLine("Name: Hulk \' Bruce Banner"); 

            string hero = "Moon Knight" + " is the newest Marvel Star.";
            Console.WriteLine(hero);  */

            string customertName = "Akash";
            char customercategory = 'A';
            int customerAge = 21;
            double customerDiscount = 500;
            bool isMale = true;

            Console.WriteLine("Customer Name: "+customertName);
            Console.WriteLine("Age: "+customerAge);
            Console.WriteLine("Category: "+customercategory);
            Console.WriteLine("Gender: "+isMale+" (true = Male \\ false = female)"); 
            Console.WriteLine("Discount: "+customerDiscount);

        }
    }
}
