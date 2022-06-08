#pragma once
#include "Book.cpp"
#include <vector>
#include <iostream>

using namespace std;

namespace A1

{
    class Library
    {
        const int InitialBorrowDays = 120;

    public:
        Library(string name)
            : l_name(name)
        {
        }
        Library() {}

        Library(Library &other)
        {
            // this->l_name != other->l_name;
            vector<Book *> books = *(other.l_book);
            for (int i = 0; i < other.l_book->size(); i++)
            {
                // this->l_book.push_back(other.(*l_book[i]));
                Book *book = (books[i]);
                l_book->push_back(book);
            }
        }

        void AddBook(Book *v)
        {
            (*l_book).push_back(v);
        }

        void SortMembersByName()
        {
            vector<Member *> *s = all;
            Member *tmp;
            for (int i = 0; i < all->size(); i++)
            {
                for (int j = 0; j < all->size(); j++)
                {
                    if (((*s)[j])->m_name > ((*s)[i])->m_name)
                    {
                        tmp = (*s)[i];
                        (*s)[i] = (*s)[j];
                        (*s)[j] = tmp;
                    }
                }
            }
        }

        void BorrowBook(Book *b, Member *m)
        {
            auto b1 = !b->gharz;
            auto b2 = !m->IsBorrowed();
            auto price = b->GetPrice() / 4;
            auto b3 = m->m_price >= price;
            if (b1 && b2 && b3)
            {
                m->m_price -= price;
                b->gharz = true;
                m->IsBorrowedd = true;
                b->put(m);
                // (*a).put(b);
                // (*a).bargasht();
            }
        }

        void DaysPassed(int n)
        {
            for (int i = 0; i < l_book->size(); i++)
            {
                // int n = (*l_book)[i]->b_price;
                if(!(*l_book)[i]->IsBorrowed())
                    continue;
                if ((*l_book)[i]->bargasht()->m_price >= (*l_book)[i]->b_price/10 * n)
                {
                    (*l_book)[i]->bargasht()->m_price -=   ((*l_book)[i]->b_price /10)* n;
                    // (*l_book)[i]->gharz = false;
                }
                else
                {
                    (*l_book)[i]->gharz = false;
                    (*l_book)[i]->bargasht()->IsBorrowedd = false;

                }
            }
        }

        vector<Book*>* FindBooks(string f , int n)
        {
            vector<Book*>* s = new vector<Book*>();
            for (int j = 0; j < f.length(); j++)
            {
                f[j] = tolower(f[j]);
            }
            for (int i = 0; i < l_book->size();i++)
            {
                int u=1;
                auto q  = (*l_book)[i]->GetCategory();
                for (int  p = 0; p <(*l_book)[i]->GetCategory().length() ; p++)
                    q[p] = tolower(q[p]);
                for (int z = 0; z <f.length() ; z++)
                {
                    if (f[z]!=q[z])
                    {
                        u=2;
                        break;
                    }
                }
                // cout<<float((*l_book)[i]->GetRating());  
                if (u !=2 && n < (*l_book)[i]->GetRating())   
                    (*s).push_back((*l_book)[i]);
            }
                return s;
        }             

        string GetName()
        {
            return l_name;
        }

        vector<Book *> *GetAllBooks()
        {
            return l_book;
        }

        void SetName(string s)
        {
            l_name = s;
        }

        ~Library()
        {
            if (l_book)
            {
                delete l_book;
                l_book = nullptr;
            }
            if (all)
            {

                for (int i = 0; i < (*all).size(); i++)
                {
                    // (*all)[i] = nullptr;
                    delete (*all)[i];
                }
                delete all;
                all = nullptr;
            }
        }

        vector<Member *> *GetAllMembers()
        {
            return all;
        }

        void RegisterMember(Member *m)
        {

            if ((*m).GetSavingMoney() > 1000)
            {
                (*m).m_price = (*m).m_price - 1000;
                (*all).push_back(m);
            }
        }

    private:
        string l_name;
        vector<Book *> *l_book = new vector<Book *>();
        vector<Member *> *all = new vector<Member *>();
        int a = all->size();
        int b = l_book->size();
        int i = 0;
    };
}
