using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap_05
{
    class Book
    {
        private string name;
        private Author[] author;
        private double price;
        private int qty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Author[] Author
        {
            get
            {
                return this.author;   
            }
            set
            {
                this.author = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;

            }
            set
            {
                this.price = value;
            }
        }
       public int Qty
        {
            get
            {
                return this.qty;
            }
            set
            {
                this.qty = value;
            }
        }
        public Book(string name,  Author[] author,double price)
        {
            this.name = name;
            int lenght = author.Length;
            this.author = new Author[lenght];
            for(int i = 0; i < lenght; i++)
            {
                this.author[i] = author[i]; 
            }
            this.price = price;

        }
        public Book(string name, Author[] author, double price,int qty =0)
        {
            this.name = name;
            int lenght = author.Length;
            this.author = new Author[lenght];
            for (int i = 0; i < lenght; i++)
            {
                this.author[i] = author[i];
            }
            this.price = price;
            this.qty = qty;
        }
        public string getName()
        {
            return this.name;
        }
        public Author[] getAuthors()
        {
            return this.author;
        } 
        public double getPrice()
        {
            return this.price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public int getQty()
        {
            return this.qty;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public string toString()
        {
            string authorList = "";
            authorList = authorList + "authors{";
            for (int i = 0;i < this.author.Length;i++)
            {
                authorList = authorList + this.author.ToString();
                if (i != this.author.Length  - 1 )
                {
                    authorList = authorList + ',';
                }
            }
            authorList = authorList + "}";
            return authorList;
        }
        public string getAuthorNames()
        {
            string nameAuthors ="";
            
            for(int i = 0; i < this.author.Length; i++)
            {
                nameAuthors = nameAuthors + this.author[i].Name;

                if(i != this.author.Length -1)
                {
                    nameAuthors = nameAuthors + ",";
                }
            }
            return nameAuthors;
        }
        public static void Xuat(int booksSize, Book[] bookList)
        {
            for (int i = 0; i < booksSize; i++)
            {
                Console.WriteLine("Ten sach: " + bookList[i].Name);
                Console.WriteLine("Ten cac tac gia: ");
                for(int j= 0; j < bookList[i].Author.Length; j++)
                {
                    Console.WriteLine("-" + bookList[i].Author[j].Name);
                }
                Console.WriteLine("Gia quyen sach: " + bookList[i].Price);
                Console.WriteLine("So luong quyen sach: " + bookList[i].Qty);

            }
        }

    }
}
