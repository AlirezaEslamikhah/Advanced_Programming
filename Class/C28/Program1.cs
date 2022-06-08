using System;
using System.Text.RegularExpressions;

namespace C28
{
    abstract class Person
    {
        string Name;
        public abstract void PrintName();
    }
    class Student: Person
    {
        double GPA;
        public sealed override void PrintName() {}
    }

    sealed class GraduateStudent: Student
    {}

    class Program1
    {
        static void Main(string[] args)
        {
            string w = "ali's email is ali@en.yahoo.com and he lives in Tehran and his mother's email is maryam@gmail.com";
            Regex regex = new Regex(@"[A-Za-z_]+@([a-z]+\.)+[a-z]+");
            foreach(Match match in regex.Matches(w))
            {
                System.Console.WriteLine(match.Value);
            }


        }
    }
}
