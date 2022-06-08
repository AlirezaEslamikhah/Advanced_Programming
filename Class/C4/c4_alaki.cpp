#include<vector>
#include<string>
#include<iostream>

using namespace std;

class University
{
public:
    University(const string& name, const string& address)
    :uni_name(name),uni_addr(address)
    {}
    void PrintInfo()
    {
        cout<<"The university's name is: "<<uni_name<<"\n"<<"The univerity's address is: "<<uni_addr<<endl;
    }
    University()
    {}
    string uni_name;
    string uni_addr;
};

class Instructor
{
public:
    Instructor(const University& univ, string name, int id, string department)
    :ins_name(name),ins_id(id),ins_dep(department)
    {}
    void PrintInfo()
    {
        cout<<"The instructor's name is: "<<ins_name<<"in this univerity: "<<s.uni_name<<"      His/Her department is: "<<ins_dep<<endl;
    }

    Instructor(){}

    string ins_name;
    int ins_id;
    string ins_dep;
    University s;
};

class Course
{
public:
    Course(const University& univ, const Instructor& instructor, const string& name, double grade, int unit)
    :c_grade(grade),c_name(name),c_unit(unit)
    {}
    void PrintInfo()
    {
        cout<<"The course which is registered is: "<<c_name<<"and its unit is: "<<c_unit<<"At last the student has gotten"<<c_grade<<"in this course"<<endl;
    }
    double c_grade;
    int c_unit;
    string c_name;
    University s;
    Instructor c;

};

class Student
{
public:    
    Student(const University& univ, const string& name, int id, const string& major)
    :s_name(name),s_id(id),s_major(major)
    {}

    void PrintInfo()
    {
        cout<<"The student's name is: "<<s_name<<"\n"<<"His / Her id is: "<<s_id<<"\n"<<"And the major is : "<<s_major<<"\n"<<endl;
    }

    void RegisterCourse(const Course& course)
    {
        // Course s = course;
        m_Courses.push_back(course);
    }

    void RegisterGrade(const string& C,double g)
    {
        for (int i = 0; i < m_Courses.size(); i++)
        {
            if (m_Courses[i].c_name==C)
            {
                m_Courses[i].c_grade = g;
            }
        }
    }
    void PrintTranscript()
    {
        PrintInfo();
        for (int i = 0; i < m_Courses.size(); i++)
        {
            cout<<i<<"  "<<m_Courses[i].c_name<<":"<<"\t"<<m_Courses[i].c_unit<<"\t"<<m_Courses[i].c_grade<<endl;
            
        }
        
    }

private:
    vector<Course> m_Courses;
    string s_name;
    int s_id;
    string s_major;
};


int main(int argc, char const *argv[])
{
    University iust("Iran University of Science and Technology", "Narmak,Daneshgah street");
    Instructor ostad_fattahi(iust, "elham",99892, "Math");
    Instructor ostad_hakami(iust,"vesal",99839,"Gosaste");
    Course math(iust,ostad_fattahi, "Math", 0, 3);
    Course gos(iust,ostad_hakami,"Gosaste",0,3);
    Student ali(iust, "Ali Vahidi", 983423420, "EE");
    Student reza(iust,"Reza Shamsaei",99521064,"CE");
    reza.RegisterCourse(math);
    reza.RegisterCourse(gos);
    reza.RegisterGrade("Gosaste", 19);
    reza.RegisterGrade("Math",18);
    reza.PrintTranscript();
    cout<<"\n"<< "**************************************"<<endl;
    ali.RegisterCourse(math);
    ali.RegisterCourse(gos);
    ali.RegisterGrade("Gosaste", 15);
    ali.RegisterGrade("Math",11);
    ali.PrintTranscript();



    return 0;
}