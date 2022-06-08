#include<iostream>
#include<vector>

using namespace std;

int main(int argc, char const *argv[])
{
    int s;
    vector<int> mynums;
    while (s != -1 )
    {
        cin >> s;
        mynums.push_back(s);
    }
    for (int i =mynums.size()-1; i >=0; i--)
        cout<<mynums[i]<<endl;
    return 0;
}
