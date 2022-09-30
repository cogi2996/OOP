using System;

namespace BookReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Book[] listBook;
            void Render()
            {
                Nhap();
                Xuat(size);
                TimKiem(listBook);
            }

            void Nhap()
            {
                Console.WriteLine("Nhap so luong cac quyen sach can truy cap");
                size = int.Parse(Console.ReadLine());
                listBook = new Book[size];
                for (int i = 0; i < size; i++)
                {
                    string bookName, authorName, authorEmail;
                    char authorGender;
                    double bookPrice;
                    int bookQty;
                    Console.WriteLine("Nhap ten sach: ");
                    bookName = Console.ReadLine();
                    Console.WriteLine("Nhap ten tac gia sach: ");
                    authorName = Console.ReadLine();
                    Console.WriteLine("Nhap email tac gia: ");
                    authorEmail = Console.ReadLine();

                    while (authorEmail.IndexOf("@") == -1)
                    {
                        Console.WriteLine("Email phai chua ki tu @, vui long nhap lai.");
                        authorEmail = Console.ReadLine();
                    }
                    

                        Console.WriteLine("Nhap gioi tinh tac gia: ");
                        authorGender = Console.ReadLine()[0];
                        while (authorGender != 'm' && authorGender != 'f' && authorGender != 'u')
                        {
                            Console.WriteLine("Gio tinh chi chua m(male) -  f(female) - u(unknown) , vui long nhap lai: ");
                            authorGender = Console.ReadLine()[0];

                        }
                        Console.WriteLine("Nhap gia quyen sach: ");
                        bookPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so luong quyen sach: ");
                        bookQty = int.Parse(Console.ReadLine());
                        Author author = new Author(authorName, authorEmail, authorGender);
                        Book bk = new Book(bookName, author, bookPrice, bookQty);
                        listBook[i] = bk;
                    }
                }

                void Xuat(int size)
                {
                Console.WriteLine("\n ---------------------------------");
                for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine(listBook[i].toString());
                        Console.WriteLine("\n ---------------------------------");
                    }

                }
                void TimKiem(Book[] listBook)
                {
                Console.WriteLine("Nhap ten phan tu can tim kiem: ");
                string nameBook = Console.ReadLine();
                Console.WriteLine(nameBook);
                int keyFind = 0;
                Console.WriteLine("\n ---------------------------------");
                Console.WriteLine("Ket qua tim kiem: ");
                    foreach (Book bk in listBook)
                    {
                        if (bk.Name == nameBook)
                        {

                            Console.WriteLine(bk.toString());
                            keyFind = 1;
                        }
                    }
                    if (keyFind == 0)
                        Console.WriteLine("Khong co ket qua tim kiem");
                }
                Render();
            
        }
    }
}
