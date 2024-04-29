using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", GradingStudents(new List<int>() { 73, 67, 38, 33 })));
        }
        public static List<int> GradingStudents(List<int> grades)
        {
            //if num ends in 3,4 or 8,9 && is above 40 we round it
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                    continue;
                string strGrade = grades[i].ToString();
                if (strGrade[1] == '3' || strGrade[1] == '8')
                    grades[i] += 2;
                else if (strGrade[1] == '4' || strGrade[1] == '9')
                    grades[i] += 1;
            }
            return grades;
        }
    }
}
