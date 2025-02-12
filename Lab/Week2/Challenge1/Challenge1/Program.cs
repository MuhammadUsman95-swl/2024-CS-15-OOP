using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {

        static List<Student> studentInfo = new List<Student>();
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.Clear();
                choice = menu();
                switch (choice) {
                    case 1:
                        addStudent(); 
                        Console.ReadKey();
                        break;
                    case 2:
                        showStudent();
                        Console.ReadKey();
                        break;
                    case 3:
                        calculateAggregate();
                        Console.ReadKey();
                        break;
                    case 4:
                        //topStudent();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                    }
            } 
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. Add Student....");
            Console.WriteLine("2. Show all student....");
            Console.WriteLine("3. Calculate aggregate....");
            Console.WriteLine("4. Top 3 student.....");
            Console.Write("Enter a valid option.... ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string addStudent()
        {
            Console.Write("Enter name of student.. ");
            string name = Console.ReadLine();
            Console.Write("Entre marks in Matric (out of 1100)... ");
            float matric = float.Parse(Console.ReadLine());
            Console.Write("Enter marks in inter (out of 1200).... ");
            float inter = float.Parse(Console.ReadLine());
            Console.Write("Enter marks ECAT (out of 400)... ");
            float ecat = float.Parse(Console.ReadLine());
            Student student = new Student(name, matric, inter, ecat);
            studentInfo.Add(student);

            return "Student Add Successfully.....";
        }
        static void showStudent()
        {
            foreach (Student student in studentInfo)
            {
                student.showStudent();
            }
        }
        static void calculateAggregate()
        {
            foreach (Student student in studentInfo)
            {
                student.calculateStuAggregate();
            }
        }
       


    }

}