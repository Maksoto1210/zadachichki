using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachichki
{
    internal class Program
    {
        static void BubbleSort(List<Student> students)
        {
            int n = students.Count;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (students[i].Age > students[i + 1].Age)
                    {
                        var temp = students[i];
                        students[i] = students[i + 1];
                        students[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student("Иван", 19),
            new Student("Мария", 21),
            new Student("Георги", 18),
            new Student("Анна", 20)
        };

            Console.WriteLine("Преди сортиране:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age} години");
            }

            BubbleSort(students);

            Console.WriteLine("\nСлед сортиране:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age} години");
            }
        }
    }
}
