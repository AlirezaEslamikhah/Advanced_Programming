#include<iostream>
#include<string>
#include<vector>
using namespace std;

class Student
{
public:
    Student(string firstName, string lastName, int stdId, string major)
        :m_firstName(firstName)
        , m_lastName(lastName),
        m_stdId(stdId)
        ,m_major(major)
    {}

    Student(const Student& other)
    {
        m_firstName = other.m_firstName;
        m_lastName = other.m_lastName;
        m_major = other.m_major;
        m_stdId = other.m_stdId;
        
    }

    void PrintCompareTranscript(Student& other)
    {
        cout << "THE COMPARISON OF THE 2 STUDENTS IS :"<<endl;
        cout<<"\n";
        cout << m_firstName << " "<< m_lastName<< string(11,' ')<< other.m_firstName<< " "<<other.m_lastName<<endl;
        for (int i = 0; i < m_vCourses.size(); i++)
        {
            cout<<m_vCourses[i]<<": "<<m_vGrades[i]<<", "<<m_vCourseUnit[i]<<"\t\t\t\t\t"<<other.m_vCourses[i]<<": "<<other.m_vGrades[i]<<" , "<<other.m_vCourseUnit[i]<<endl;
        }
        

    } 

    void RegisterGrade(string course, int units, double grade)
    {
        m_vCourses.push_back(course);
        m_vCourseUnit.push_back(units);
        m_vGrades.push_back(grade);
    }

    void PrintTranscript()
    {
        cout << m_firstName << "  " << m_lastName << endl;
        for (int i = 0; i < m_vGrades.size(); i++)
        {
            cout << i << ": "<< m_vCourses[i] << ", " << m_vGrades[i] <<", "<< m_vCourseUnit [i] << endl;
        }
        cout << "\n\n";
    }

    string get_fullName()
    {
        cout << m_firstName;
        cout<< string(1,' ');
        cout << m_lastName;
        return nullptr;
    } 

    int get_stdId()
    {
        return m_stdId;
    }

    string get_major()
    {
        return m_major;
    } 

    void PrintFailedCourses()
    {
        cout << "failed courses are:"<<endl;
        for (int i = 0; i < m_vCourses.size(); i++)
        {
            if (m_vGrades[i] < 10)
            {
                cout << i << ": "<< m_vCourses[i] << ", " << m_vGrades[i] << ", " << m_vCourseUnit [i] << endl;
            }
        }
        cout<<"\n";
    } 

    double get_GPA()
    {
        double sum = 0;
        double num =0;
        for (int i = 0; i < m_vGrades.size(); i++)
        {
            sum = sum + m_vCourseUnit[i] * m_vGrades[i];
            num = num + m_vCourseUnit[i];
        }
        return (sum / num);
    } 

    void set_firstName(string firstName)
    {
        m_firstName = firstName;
    } 

    void set_lastName(string lastName)
    {
        m_lastName = lastName;
    } 

    void set_stdId(int stdId)
    {
        this->m_stdId = stdId;
    } 

    void set_major(string major)
    {
        m_major = major;
    }

private:
    string m_firstName;
    string m_lastName;
    int m_stdId;
    string m_major;
    vector<int> m_vCourseUnit;
    vector<double> m_vGrades;
    vector<string> m_vCourses;
};


int main(int argc, char const *argv[])
{
    Student mn("Aysa", "Mayahinia", 99521231, "Computer");
    mn.RegisterGrade("AP", 3, 18);
    mn.RegisterGrade("DS", 3, 18.5);
    mn.RegisterGrade("FC", 3, 18);
    mn.RegisterGrade("CL", 3, 8);
    mn.RegisterGrade("AL", 3, 9);
    cout<<  "THE GPA IS :" <<mn.get_GPA() <<endl;
    mn.PrintTranscript();
    mn.PrintFailedCourses();

    Student nz(mn);
    nz.set_firstName("Aylin");
    nz.set_lastName("Naebzadeh");
    nz.set_stdId(99521111);
    nz.RegisterGrade("AP", 3, 19);
    nz.RegisterGrade("DS", 3, 16);
    nz.RegisterGrade("FC", 3, 20);
    nz.RegisterGrade("CL", 3, 7);
    nz.RegisterGrade("AL", 3, 8);

    nz.PrintCompareTranscript(mn);


    /* code */
    return 0;
}
