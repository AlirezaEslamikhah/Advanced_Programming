#include<vector>
#include<string>
#include<iostream>

using namespace std;

class University
{
public:
    University(const string& name, const string& address)
    {
        uni_name = name;
        uni_add = address;
    }
    void PrintInfo(){}
    string uni_name;
    string uni_add;
    University()
    {}
};

class Instructor
{
public:
    Instructor(const University& univ, string name, int id, string department)
    {
        ins_name = name;
        ins_id = id;
        ins_dep = department;
        s = univ;
    }

    void PrintInfo(){
        cout<< "The university's name is:"<<esm<<"\n"<<"Uni's address is:"<<addr<<"\n"<<"Ins's name is:"<<ins_name<<" \n"<<"Ins's id is:"<<ins_id<<"Ins's departure is:"<<ins_dep<<endl;
    }
    string ins_name;
    string ins_id;
    string ins_dep;
    string esm;
    string addr;
    University s;
};

class Course
{
public:
    Course(const University& univ, const Instructor& instructor, const string& name, double grade, int unit)
    {
        esm = name;
        nom = grade;
        vahed = unit;
    }
    

    void PrintInfo(const University& univ, const Instructor& instructor)
    {
        cout << "The course name is:"<<esm<< "\n" <<"Course grade and unit is:"<< nom<<" , "<< vahed<<endl; 
    }

    string esm;
    double nom;
    int vahed;

};

class Student
{
public:    
    Student(const University& univ, const string& name, int id, const string& major)
    {
        std_id = id;
        std_major = major;
        std_name = name;
        // s = univ;
    }

    void PrintInfo(){
        cout << "The student's name is:"<<std_name<<"\n" <<"The student's id is:"<<"\n" <<std_id<<"The student's major is:"<<std_major<<endl;
    }

    void RegisterCourse(const Course& course)
    {
        Course s = course;
        m_Courses.push_back(course);
    }

    void RegisterGrade( const string& c , double grade)
    {
        for (int i = 0; i < m_Courses.size(); i++)
        {
            if (m_Courses[i].esm == c)
            {
                m_Courses[i].nom = grade;
            }
        }
    }
    void PrintTranscript()
    {
        cout<<std_name<<"\n"<<std_id<<"\n"<<std_major<<"\n";
        for (int i = 0; i < m_Courses.size(); i++)
        {
            cout <<m_Courses[i].esm<<" "<<m_Courses[i].nom<<endl;
        }
    }
    int std_id;
    string std_name;
    string std_major;
private:
    int i = 0;
    vector<Course> m_Courses;
    // University s;
    // Course v;
};


int main(int argc, char const *argv[])
{
    University iust("Iran University of Science and Technology", "Median resalat....");
    Instructor ostad_hoseini(iust, "hosseini", 923423, "Math");
    Course math101(iust, ostad_hoseini, "Math 101", 0, 3);
    Student sara(iust, "sara pejmani", 98342342, "EE");
    sara.RegisterCourse(math101);
    sara.RegisterGrade("Math 101", 19.8);
    sara.PrintTranscript();

    return 0;
}
