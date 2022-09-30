using System;
using System.Collections.Generic;
using System.Text;

namespace BookReturn
{
    class Book
    {
        private string name;
        private Author author;
        private double price;
        private int qty = 0;

        public string Name
        {
            get { return name;  }
            set { this.name = value; }
        }
        public Author Author
        {
            get { return this.author; }
            set
            {
                author = value;

            }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Qty
        {
            get{ return qty; }
            set { qty = value; }
        }
        public Book (string name, Author author, double price,int qty)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }
        public Book()
        {
            this.name = "";
            this.author = new Author();
            this.price = 0;
        }
        public string getName()
        {
            return name;
        }
        public Author getAuthor()
        {
            return author;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public int getQty()
        {
            return qty;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public string toString()
        {
            return $"name = {name}, {author.toString()}, price = {price},qty = {qty} ";
        }
        
    }
}
