abstract class Person
{
    public int NatId {get; private set;}
    public string Name {get; private set;}

    public bool IsFemale {get; private set;}
    public Person(string name, int natid, bool isFemale)
    {
        this.Name = name;
        this.NatId = natid;
        this.IsFemale = isFemale;
    }

    public abstract void PrintName();

    // public virtual void PrintName()
    // {
    //     if (IsFemale)
    //         System.Console.WriteLine($"Mrs. {this.Name}");
    //     else
    //         System.Console.WriteLine($"Mr. {this.Name}");
    // }    

}

class Student: Person
{
    public int StdId {get; private set;}
    public double GPA {get; set;}
    public Student(string name, int natid, int stdid, bool isFemale)
        :base(name, natid, isFemale)
    {
        this.StdId = stdid;
    }
    public override void PrintName()
    {
        if (IsFemale)
            System.Console.WriteLine($"Mrs. Engineer {this.Name}");
        else
            System.Console.WriteLine($"Mr. Engineer {this.Name}");
    }    
}

// class BachelorStudent: Student
// {
//     public BachelorStudent(string name, int natid, int stdid, bool isFemale)
//         :base(name, natid, stdid, isFemale)
//         {}
    
//     public override void PrintName()
//     {
//         base.PrintName();
//         System.Console.WriteLine("Printing from BachelorStudent");
//     }
// }


class Employee: Person
{
    public double Salary {get; private set;}
    public Employee(string name, int natid, bool isFemale, double salary)
        :base(name, natid, isFemale)
    {
        this.Salary = salary;
    }
    public override void PrintName()
    {
        if (IsFemale)
            System.Console.WriteLine($"Mrs. Employee {this.Name}");
        else
            System.Console.WriteLine($"Mr. Employee {this.Name}");
    }    
}
