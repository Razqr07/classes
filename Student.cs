using System;

namespace Classes
{
    class Student
    {
        public string Name { get; }
        public int YearOfBirth { get; }
        public string Hobby {get; set; }
        public bool Alive {get; set;}

        public Student()
        {
            Name = "John";
            YearOfBirth = 2000;
            Hobby = "Nothing";
            Alive = true;
        }


        public Student(string name, int yearOfBirth, string hobby, bool alive)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            Hobby = hobby;
            Alive = alive;

        }

        string IsAlive()
        {
            if (Alive == true)
            {
                return "Alive";
            }
            else
            {
                return "not Alive";
            }
        }
    }
}
