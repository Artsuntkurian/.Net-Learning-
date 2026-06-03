using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentPerformanceDashboard
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }
    }

    class StudentManager<T>
    {
        private List<T> students = new List<T>();

        public void AddStudent(T student)
        {
            students.Add(student);
        }

        public List<T> GetStudents()
        {
            return students;
        }
    }

    class AssignmentProgram
    {
        public static void Run(string[] args)
        {
            StudentManager<Student> manager = new StudentManager<Student>();

            Console.Write("Enter number of students: ");

            int count;
            string? countInput = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(countInput) || !int.TryParse(countInput, out count) || count <= 0)
            {
                Console.Write("Invalid input. Enter a valid number: ");
                countInput = Console.ReadLine();
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}");

                string name;
                do
                {
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine() ?? string.Empty;
                } while (string.IsNullOrWhiteSpace(name));

                int marks;
                string? marksInput;
                do
                {
                    Console.Write("Enter Marks: ");
                    marksInput = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(marksInput) || !int.TryParse(marksInput, out marks) || marks < 0 || marks > 100);

                manager.AddStudent(new Student(name, marks));
            }

            Console.WriteLine("\n===== ALL STUDENTS =====");

            foreach (var student in manager.GetStudents())
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
            }

            Console.WriteLine("\n===== TOP PERFORMERS (Marks >= 75) =====");

            var topStudents = manager.GetStudents()
                                     .Where(s => s.Marks >= 75);

            foreach (var student in topStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}