#include<iostream>
#include<vector>

using namespace std;

int main(int argc, char const *argv[])
{
    int n = 5;
    cout << "Hello World " << n << endl;
    cin >> n;
    string s = "salam chetory ";
    cout << s.size() << endl;
    string s2 = s + " khaste hastam !";
    cout << s2 << endl;
    cin >> s2 ;
    cout << "I got this string: " << s2 << s2 << s2 << s2 << "\r\n";

    vector<int> mynums;
    mynums.push_back(5);
    mynums.push_back(3);

    for(int i=mynums.size()-1; i>=0; i--)
        cout << mynums[i] << endl;

    for(int n: mynums)
    {
        cout << n << endl;
    }
}
