using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class MEMBER
    {
        public string Book_Name;
        public string Author_Name;
        public string Publisher_name;
        public int ISBN;
        public int Price;
        public int Year;
        public string Name;
        public string Phone;
        public long CNIC;
        public MEMBER(string book_name, string author_name, string publihser, int isbn, int price, int year )
        {
            Book_Name = book_name;
            Author_Name = author_name;
            Publisher_name = publihser;
            ISBN = isbn;
            Price = price;
            Year = year;
        }
        public MEMBER(string name, string phone, long cnic)
        {
            Name = name;
            Phone = phone;
            CNIC = cnic;
        }
    }
}