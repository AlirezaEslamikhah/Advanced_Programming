using System;

namespace C25
{
    class Test
    {
        public override string ToString()
        {
            return "this is my test class";
        }
    }

    class Program
    {
        static void PrintInfo(params Person[] persons)
        {
            foreach(var p in persons)
                p.PrintName();
        }
        
        static void Main(string[] args)
        {

            // Person p = new Person("ali", 234324, false);

            Student s = new Student("Zahra", 527123344, 99521123, true);
            s.PrintName();

            Person p = new Student("Ali", 342343432, 99521223, false);
            p.PrintName();

            Employee e = new Employee("hasan", 234324, false, 343243243);

            PrintInfo(s, p, e);
        }
    }
}
