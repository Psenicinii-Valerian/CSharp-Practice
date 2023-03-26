using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_constructorilor
{
    internal class Student
    {
        string name;
        int[] grades;
        int age;
        double averageGrade;

        public Student(string name, int[] grades)
        {
            this.name = name;
            this.grades = grades;

            for (int i=0; i<grades.Length; i++)
            {
                this.averageGrade += grades[i];
            }

            this.averageGrade /= grades.Length;
        }

        public Student(string name, int age, int[] grades)
        {
            this.name = name;
            this.age = age;
            this.grades = grades;

            for (int i = 0; i < grades.Length; i++)
            {
                this.averageGrade += grades[i];
            }

            this.averageGrade /= grades.Length;
        }

        public void showStudent()
        {       
            if (name != null)
            {
                Console.WriteLine($"Name: {name}");
            }

            if (age > 0)
            {
                Console.WriteLine($"Age: {age} years old");
            }

            if (grades.Length > 0)
            {
                int i = 0;
                Console.WriteLine("Grades::");

                foreach(var grade in grades)
                {
                    Console.WriteLine($"grade[{i++ + 1}]::{grade}");
                }
            }

            if (averageGrade > 0)
            {
                Console.WriteLine($"Average grade: {Math.Round(averageGrade, 2)}");
            }
        }
    }
}
