using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Student
    {
        string name;
        string major;
        int graduationYear;
        DateTime now = DateTime.Now;

        public Student()
        {

        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setMajor(string major) 
        { 
            this.major = major;
        }

        public void setGraduationYear(int graduationYear)
        {
            this.graduationYear = graduationYear;
        } 

        public string getName()
        {
            return this.name;
        }

        public string getMajor()
        {
            return this.major;
        }

        public int getGraduationYear() 
        { 
            return this.graduationYear;
        }

        public void study()
        {
            if (now.Year - this.graduationYear < 0 )
            {
                Console.WriteLine($"The student {this.name} that majors in {this.major} is still studying" +
                                  $"(untill {this.graduationYear})");
            } else
            {
                Console.WriteLine($"The student {this.name} that majored in {this.major} has already finished " +
                                  $"to study in {this.graduationYear}");                                   
            }
        }

    }
}
