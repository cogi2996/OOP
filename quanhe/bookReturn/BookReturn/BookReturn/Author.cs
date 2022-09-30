using System;
using System.Collections.Generic;
using System.Text;

namespace BookReturn
{
    class Author
    {
        private string name;
        private string email;
        private char gender;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value.IndexOf("@") != -1)
                {
                    this.email = value;
                }
                else
                {
                    Console.WriteLine("Truong email bat buoc phai co ki tu @");
                }
            }
        }
        public char Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value == 'm' || value == 'f' || value == 'u')
                {
                    this.gender = value;
                }
                else
                {
                    Console.WriteLine("Gio tinh chi chua m(male) -  f(female) - u(unknown)");
                }
            }
        }

        public Author(string name = "", string email = "", char gender = 'u')
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public string getName()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public char getGender()
        {
            return this.gender;
        }
        public string toString()
        {
            return $"name author= {this.name}, author's gender = ({this.gender}) at {this.email}";
        }

    }
}
