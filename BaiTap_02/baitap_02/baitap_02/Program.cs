using System;

namespace baitap_02
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
                return this.name ; 
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
                if(value == 'm'||value == 'f' || value == 'u')
                {
                    this.gender = value;                                       
                }
                else
                {
                    Console.WriteLine("Gio tinh chi chua m(male) -  f(female) - u(unknown)");
                }
            }
        }
        
        public Author(string name = "",string email = "",char gender = 'u')
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public string getName()
        {
            return this.name;
        }
        public string getEmail ()
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
        public void Print()
        {
            Console.WriteLine($"{this.name} ({this.gender}) at {this.email}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Author user = new Author("Tuan","ha@");
            user.setEmail("ha@");
            Console.WriteLine(user.getName());
            user.Print();*/
            Author[] users = new Author[100];
            Console.WriteLine("Nhap so luong nguoi dung");
            int sizeOfUs = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i<sizeOfUs;i++)
            {
                Author userTerm = new Author();
                Console.WriteLine("Nhap ten nguoi dung");
                userTerm.Name = Console.ReadLine();
                Console.WriteLine("Nhap Email nguoi dung");
                userTerm.Email = Console.ReadLine();
                Console.WriteLine("Nhap gioi tinh nguoi dung");
                userTerm.Gender = Console.ReadLine()[0]; // syntax read char 
                users[i] = userTerm;
            }
            Console.WriteLine("Nhap ten nguoi dung can tim kiem thong tin");
            string userName = Console.ReadLine();
            int keyFindUser= 0;
            foreach(Author user in users)
            {
                   if(user.Name == userName)
                   {
                    keyFindUser = 1;
                    Console.WriteLine("--> Thong tin nguoi dung");
                    user.Print();
                    break;
                   }
            }
            if (keyFindUser == 0)
                Console.WriteLine("Khong co nguoi dung nao co ten nhu da nhap");
            
        }
    }
}
