#pragma once
#include<iostream>
#include<string>
#include<vector>

using namespace std;

namespace A1
{
    class Member
    {
        public:
            Member(int price,string name)
            :m_name(name),m_price(price)
            {}

            Member(){}

            Member(const Member& other)
            {
                this->m_price = other.m_price;
            }

            int GetSavingMoney()
            {
                return m_price;
            }

            string GetName() const
            {
                return m_name;
            }

            bool IsBorrowed()
            {
                return IsBorrowedd;
            }

            

        // private:
            bool IsBorrowedd = false;
            string m_name;
            int m_price;
    };

}