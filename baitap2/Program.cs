using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Anh", 10),
                new Student(2, "Binh", 20),
                new Student(3, "Cuong", 15),
                new Student(4, "Dung", 18),
                new Student(5, "An", 14)
            };

            Console.WriteLine("Danh sach toan bo hoc sinh:");
            students.ForEach(student => student.Display());

            var age15to18 = students.Where(student => student.Age >= 15 && student.Age <= 18).ToList();
            Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:");
            age15to18.ForEach(student => student.Display());

            var startsWithA = students.Where(student => student.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nDanh sach hoc sinh co ten bat dau bang chu 'A':");
            startsWithA.ForEach(student => student.Display());

            int totalAge = students.Sum(student => student.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            var oldestStudent = students.OrderByDescending(student => student.Age).FirstOrDefault();
            Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
            oldestStudent?.Display();

            var sortedByAge = students.OrderBy(student => student.Age).ToList();
            Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
            sortedByAge.ForEach(student => student.Display());

            Console.ReadKey();
        }
    }
}
