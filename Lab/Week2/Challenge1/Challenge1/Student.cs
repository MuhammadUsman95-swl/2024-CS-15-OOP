using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Student
    {
        string name;
        float matricMarks;
        float interMarks;
        float ecatMarks;
        float aggregate;

        public Student(string sName, float sMatricMarks, float SinterMarks, float secatMarks)
        {
            name = sName;
            matricMarks = sMatricMarks;
            interMarks = SinterMarks;
            ecatMarks = secatMarks;
            aggregate = ((matricMarks / 1100) * 25) + ((interMarks / 1200) * 45) + ((ecatMarks / 400) * 30);
        }
        public void calculateStuAggregate()
        {
            Console.WriteLine($"Student Name: {name}, Aggregate: {aggregate}");
        }
        public void showStudent()
        {
            Console.WriteLine($"Student Name: {name}, Matric Marks: {matricMarks}, Inter Marks: {interMarks}, ECAT marks: {ecatMarks}");
        }
    }

}
