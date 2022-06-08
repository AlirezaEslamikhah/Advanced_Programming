#include<vector>
#include<iostream>
#include<string>
#include<string.h>

using namespace std;

class myvector
{
public:
    myvector()
    :m_pData(nullptr),m_nSize(0),m_nCapacity(0)
    {}
    ~myvector()
    {
        if (m_pData)
        {
            free(m_pData);
        }
    }

    void resize()
    {
        m_nCapacity = m_nCapacity * 2;
        m_nSize++;
        int* san = (int*) malloc((m_nSize * 2) * sizeof(int));
        for (int i = 0; i <m_nSize ; i++)
        {
            san[i]=m_pData[i];
        }
        free(m_pData);
        m_pData = san;
        
    }

    void push_back(int x)
    {
        if (m_nSize == 0)
        {
            m_pData = (int*) malloc(10 * sizeof(int));
            *m_pData = x;
            m_nSize++;
            m_nCapacity++;
        }
        else if (m_nSize == m_nCapacity)
        {
            *(m_pData+m_nSize) = x;
            resize();
        }
        else if (m_nSize < m_nCapacity)
        {
            *(m_pData+m_nSize) = x;
            m_nSize++;
        }
    }

    int get(int i)
    {
        return m_pData[i];
    }

    int size()
    {
        return m_nSize;
    }

private:
    int* m_pData;
    int m_nSize;
    int m_nCapacity;
};



// int main(int argc, char const *argv[])
// {
//     myvector a;
//     cout << a.size() << endl;
//     for (int i = 0; i < 20; i++)
//     {
//         a.push_back(i);
//     }
//     cout << a.size() << endl;
//     for(int i=0; i<a.size(); i++)
//         cout << a.get(i) << endl; 
//     return 0;

// }
int main(int argc, char const *argv[])
{
    myvector v;
    cout << v.size() << endl;
    v.push_back(5);
    v.push_back(3);
    cout << v.size() << endl;
    v.push_back(12);
    v.push_back(15);
    v.push_back(-1);
    v.push_back(0);
    v.push_back(1);
    cout << v.size() << endl;
    for(int i=0; i<v.size(); i++)
        cout << v.get(i) << endl;
    return 0;
}
