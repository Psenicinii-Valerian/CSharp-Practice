namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a class called "Student" that has string variables "name" and "major", an
            // integer variable "graduationYear", and a method "study" that prints a message
            // indicating that the student is studying.

            Student stud = new Student();
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();    
            stud.setName(studentName);

            Console.Write("Enter student's major: ");
            string studentMajor = Console.ReadLine();
            stud.setMajor(studentMajor);

            Console.Write("Enter student's graduation year: ");
            int studentGraduationYear = Convert.ToInt32(Console.ReadLine());
            stud.setGraduationYear(studentGraduationYear);

            stud.study();
        }
}
}