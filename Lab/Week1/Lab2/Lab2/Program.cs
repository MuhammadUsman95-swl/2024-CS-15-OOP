using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student > studentsInfo = new List <Student> ();
            input();
            Console.WriteLine();
        }
        static void input()
        {
            Console.Write("Enter student name: ");
            string stuName = Console.ReadLine();
            Console.Write("Enter student matric marks: ");
            float stuMatricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter student intermediate marks: ");
            float stuInterMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter student ECAT marks: ");
            float stuEcatMarks = float.Parse(Console.ReadLine());
            Student info = new Student(stuName, stuMatricMarks, stuInterMarks, stuEcatMarks);
            studentsInfo.Add(info);
        }
        class Student
        {
            public Student(string StudentName,float StudentmatricMarks, float StudentFscMarks, float StudentEcatMarks) 
            {
                name = StudentName;
                matricMarks = StudentmatricMarks;
                fscMarks = StudentFscMarks;
                ecatMarks   = StudentEcatMarks;
            }
            public string name;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
        }
    }
}
