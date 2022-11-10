using System;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new HourlyEmployee(2, 6, 1234, "Tuan", "Dang");
            Console.WriteLine(employee1.toString());
            SalariedEmployee employee2 = new SalariedEmployee(3, 4.4, 6, 5678, "Phung", "Mi");
            Console.WriteLine(employee2.pay());

        }
    }
}
