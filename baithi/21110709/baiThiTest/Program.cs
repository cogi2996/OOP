using System;

namespace baiThiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a)");
            Person HourlyE = new HourlyEmployee(3000000, 8, "An", "Nguyen", "Le Van Viet", "Thu Duc", "Ho Chi Minh");
            Person salariedE = new SalariedEmployee(20000, 6, "Thuan", "Phan", "Le Van Viet", "Binh Duong", "Ho Chi Minh");
            Console.WriteLine("-Hourly employee:");
            Console.WriteLine(HourlyE.toString());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-Salaried employee:");
            Console.WriteLine(salariedE.toString());
            Console.WriteLine("b)");
            Console.WriteLine("-Hourly employee pay:");
            Console.WriteLine(HourlyE.pay());
            Console.WriteLine("-Salaried employee pay:");
            Console.WriteLine(salariedE.pay());
            Console.WriteLine("--->Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            Person[] listPerSon = new Person[n];
            Console.WriteLine("Nhap 1: Nhap nhan vien tra luong theo thang: ");
            Console.WriteLine("Nhap 2: Nhap nhan vien tra luong theo gio: ");
            int choice;
            for(int i= 0;i<listPerSon.Length;i++)
            {
                Console.WriteLine("-->Nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());
                do
                {
                    if (choice == 1)
                    {
                        string firstName;
                        string lastName;
                        string street;
                        string ward;
                        string city;
                        double basicSalary;
                        float rate;
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Street: ");
                        street = Console.ReadLine();
                        Console.WriteLine("Ward: ");
                        ward = Console.ReadLine();
                        Console.WriteLine("City: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Basic Salary: ");
                        basicSalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("rate: ");
                        rate = float.Parse(Console.ReadLine());
                        listPerSon[i] = new SalariedEmployee(basicSalary, rate, firstName, lastName, street, ward, city);

                    }
                    else
                    {
                        string firstName;
                        string lastName;
                        string street;
                        string ward;
                        string city;
                        double hourSalary;
                        int totalHour;
                        Console.Write("First Name: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Street: ");
                        street = Console.ReadLine();
                        Console.WriteLine("Ward: ");
                        ward = Console.ReadLine();
                        Console.WriteLine("City: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Hour salary: ");
                        hourSalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Total hour: ");
                        totalHour = int.Parse(Console.ReadLine());
                        listPerSon[i] = new HourlyEmployee(hourSalary, totalHour, firstName, lastName, street, ward, city);
                    }
                    
                } while (choice!=1&&choice !=2);
            }
            Console.WriteLine("Xuat danh sach da nhap");
            for(int i= 0;i<listPerSon.Length;i++)
            {
                Console.WriteLine(listPerSon[i].toString());
            }
        }
    }
}
