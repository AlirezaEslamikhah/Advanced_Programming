namespace cwork
{
    public class Person //name, natid, ToString()
    { }

    public class Employee : Person // empid, salary, ToString()
    { }

    public class Student : Person // stdid, gpa, ToString()
    { }

    public class GradudateStudent : Student // thesis_title, ToString()
    { }

    public class Instructor: Employee // teacher_rating
    {}

}