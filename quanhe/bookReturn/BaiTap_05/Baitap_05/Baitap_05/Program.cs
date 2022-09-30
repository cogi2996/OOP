using System;

namespace Baitap_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] bookList;
            int booksSize;
            void Render()
            {
                Nhap();
                Book.Xuat(booksSize,bookList);
            }
            void Nhap()
            {
                Console.WriteLine("Nhap so luong quyen sach: ");
                booksSize = int.Parse(Console.ReadLine());
                bookList = new Book[booksSize];
                for(int i = 0; i < booksSize; i++)
                {
                    string bookName = "";
                    double bookPrice = 0;
                    int bookQty = 0;
                    int sizeAut;
                    Author[] auts;
                    Console.WriteLine("Nhap ten quyen sach: ");
                    bookName = Console.ReadLine();
                    Console.WriteLine("Nhap so luong tac gia: ");
                    sizeAut = int.Parse(Console.ReadLine());
                    auts = new Author[sizeAut];
                    Console.WriteLine("Nhap thong tin cac tac gia: ");
                    for(int j= 0; j < sizeAut; j++)
                    {
                        string autName, autEmail;
                        char autGender;
                        Console.WriteLine("Ten: ");
                        autName = Console.ReadLine();
                        Console.WriteLine("Mail: ");
                        autEmail = Console.ReadLine();
                        Console.WriteLine("Gender: ");
                        autGender = Console.ReadLine()[0];
                        auts[j] = new Author(autName, autEmail, autGender);
                    }
                    Console.WriteLine("Nhap gia quyen sach: ");
                    bookPrice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so luong quyen sach can muon: ");
                    bookQty = int.Parse(Console.ReadLine());
                    for(int z = 0; z < auts.Length; z++)
                    {
                        Console.WriteLine(auts[i].Name);
                    }
                    bookList[i] = new Book(bookName, auts, bookPrice, bookQty);
                }
            }

           
            Render();
        }
    }
}
