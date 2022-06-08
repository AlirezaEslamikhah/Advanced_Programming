#pragma once
#include "Member.cpp"
#include <iostream>
namespace A1
{
    class Book
    {
    public:
        Book(string author, string title, int price, double rating, string isbn, string publish_date, string category)
            : b_author(author), b_title(title), b_price(price), b_rate(rating), b_is(isbn), b_pub(publish_date), b_cat(category)
        {
            SetPrice(this->b_price);
        }
        Book() {}

        Book(const Book &other)
        {
            SetPrice(other.b_price);
        }

        string GetAuthor()
        {
            return b_author;
        }

        string GetTitle()
        {
            return b_title;
        }

        int GetPrice()
        {
            return b_price;
        }
        double GetRating()
        {
            return b_rate;
        }
        void SetPrice(int price)
        {
            if (price >= 100 && price % 100 ==0)
            {
                this->b_price = price;
                return;
            }
            price += 100;
            int rem = price % 100;
            if (rem != 0)
            {
                price -= rem;
                this->b_price = price;
            }
            // int v = price % 100;
            // if (v>50)
            // {
            //     b_price = (price - v);
            // }
            // if(v<50 && v>0)
            // {
            //     b_price = (price + (100-v));
            // }
            // if (v ==0)
            // {
            //     b_price = price;
            // }
        }
        void SetRating(double rate)
        {
            if (1 <= rate && rate <= 5)
            {
                b_rate = rate;
            }
        }

        string GetCategory()
        {
            return b_cat;
        }

        bool IsBorrowed()
        {
            return gharz;
        }

        void put(Member *v)
        {
            s = v;
        }

        Member *bargasht()
        {
            return s;
        }

        bool gharz = false;
        int b_price;

    private:
        string b_author;
        string b_title;
        double b_rate;
        string b_is;
        string b_pub;
        string b_cat;
        Member *s;
    };
}