using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace PhucHN3
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public double CalculateAverageMarks(List<int> scores)
        {
            if (scores.Count == 0 || scores == null)
            {
                Console.WriteLine("No scores provided.");
                return 0;
            }
            double sum = 0;
            foreach (var item in scores)
            {
                sum += item;
            }
            return sum / scores.Count;
        }
        public void Display() {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
        }
    }
}
