using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class StatisticsHelper
    {
        
            private int[] grades;

            public StatisticsHelper(int[] grades)
            {
                this.grades = grades;
            }

            public float GetAverageGrade()
            {
                int sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }

                return (float)sum / grades.Length;
            }

            public int GetLowestGrade()
            {
                int minGrade = int.MaxValue;
                foreach (int grade in grades)
                {
                    if (grade < minGrade)
                    {
                        minGrade = grade;
                    }
                }

                return minGrade;
            }

            public int GetHighestGrade()
            {
                int maxGrade = int.MinValue;
                foreach (int grade in grades)
                {
                    if (grade > maxGrade)
                    {
                        maxGrade = grade;
                    }
                }

                return maxGrade;
            }
        }

    }
