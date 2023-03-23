using System;

namespace _15_Feb
{
    internal class if_else
    {
        private static void Main(string[] args)
        {
            bool isStudent = true;
            bool hasJob = true;
            bool isFemale = true;

            if (isStudent && hasJob && isFemale)
                Console.WriteLine("User is a female student and has a job");
            else if (isStudent && !hasJob && isFemale)
                Console.WriteLine("User is a female student and does not have a job");
            else if (!isStudent && !hasJob && isFemale)
                Console.WriteLine("User is a female, who is not a student and does not have a job");
            else if (!isStudent && hasJob && isFemale)
                Console.WriteLine("User is a female, who is not a student but has a job");
                        
            else if (!isStudent && !hasJob && !isFemale)
                Console.WriteLine("User is a male, who is not a student and does not have a job");
            else if (isStudent && !hasJob && !isFemale)
                Console.WriteLine("User is a male student and does not have a job");
            else if (!isStudent && hasJob && !isFemale)
                Console.WriteLine("User is a male, who is not a student but has a job");
            else if (isStudent && hasJob && !isFemale)
                Console.WriteLine("User is a male student and has a job");
                   
            else if (isStudent || hasJob || isFemale)
                Console.WriteLine("User is a female student but has a job");
            else if (isStudent || !hasJob || isFemale)
                Console.WriteLine("User is a female student but does not have a job");
            else if (!isStudent || !hasJob || isFemale)
                Console.WriteLine("User is a female, who is not a student but does not have a job");
            else if (!isStudent || hasJob || isFemale)
                Console.WriteLine("User is a female, who is not a student but has a job");

            else if (!isStudent || !hasJob || !isFemale)
                Console.WriteLine("User is a male, who is not a student but does not have a job");
            else if (isStudent || !hasJob || !isFemale)
                Console.WriteLine("User is a male student but does not have a job");
            else if (!isStudent || hasJob || !isFemale)
                Console.WriteLine("User is a male, who is not a student but has a job");
            else if (isStudent || hasJob || !isFemale)
                Console.WriteLine("User is a male student but has a job");

            else if (isStudent && hasJob || isFemale)
                Console.WriteLine("User is a female student and has a job");
            else if (isStudent && !hasJob || isFemale)
                Console.WriteLine("User is a female student and does not have a job");
            else if (!isStudent && !hasJob || isFemale)
                Console.WriteLine("User is a female, who is not a student and does not have a job");
            else if (!isStudent && hasJob || isFemale)
                Console.WriteLine("User is a female, who is not a student but has a job");

            else if (!isStudent && !hasJob || !isFemale)
                Console.WriteLine("User is a male, who is not a student and does not have a job");
            else if (isStudent && !hasJob || !isFemale)
                Console.WriteLine("User is a male student and does not have a job");
            else if (!isStudent && hasJob || !isFemale)
                Console.WriteLine("User is a male, who is not a student but has a job");
            else if (isStudent && hasJob || !isFemale)
                Console.WriteLine("User is a male student and has a job");

           else if (isStudent || hasJob || isFemale)
                Console.WriteLine("User is a female student and has a job");
            else if (isStudent || !hasJob && isFemale)
                Console.WriteLine("User is a female student and does not have a job");
            else if (!isStudent || !hasJob && isFemale)
                Console.WriteLine("User is a female, who is not a student and does not have a job");
            else if (!isStudent || hasJob && isFemale)
                Console.WriteLine("User is a female, who is not a student but has a job");

            else if (!isStudent || !hasJob && !isFemale)
                Console.WriteLine("User is a male, who is not a student and does not have a job");
            else if (isStudent || !hasJob && !isFemale)
                Console.WriteLine("User is a male student and does not have a job");
            else if (!isStudent || !hasJob && !isFemale)
                Console.WriteLine("User is a male, who is not a student but has a job");
            else if (isStudent || hasJob && !isFemale)
                Console.WriteLine("User is a male student and has a job");
            
            else
                Console.WriteLine("User not found");
        }

    }
}