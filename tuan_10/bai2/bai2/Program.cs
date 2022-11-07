using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee employee1 = new HourlyEmployee(2, 6, 1234, "Tuan", "Dang");
            Console.WriteLine(employee1.pay());
            SalariedEmployee employee2 = new SalariedEmployee(3, 4.4, 6, 5678, "Phung", "Mi");
            Console.WriteLine(employee2.pay());

        }
    }
}
