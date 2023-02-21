using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice1
{
    internal class Student
    {
        public double Point;
        public string FullName;
        public string Group;
        public List<Exam> Exams = new List<Exam>();

        public double GetAvgPoint()
        {
            double sum = 0;
            foreach(var item in Exams)
            {
                sum += item.Point;
            }
            return sum/Exams.Count;
        }

        public override string ToString()
        {
            return FullName + " - " + Group;
        }

        public List<Exam> GetExamsByPointRange(byte minPoint, byte maxPoint)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.Point >= minPoint && item.Point <= maxPoint)
                    wantedExams.Add(item);
            }

            return wantedExams;
        }
    }
}
