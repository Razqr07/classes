using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Standaard = new Student();
            Console.WriteLine("The students name is " + Standaard.Name + " And the year of birth is " + Standaard.YearOfBirth + 
                " their hobbies are " + Standaard.Hobby + " and is he alive " + Standaard.Alive  );
            Student Archibald = new Student("Archibald", 2002, "Fappen", true);
            Console.WriteLine("The students name is " + Archibald.Name + " And the year of birth is " + Archibald.YearOfBirth +
                " their hobbies are " + Archibald.Hobby + " and is he alive " + Archibald.Alive);

        }
    }
}
