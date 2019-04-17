using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {
            
            string filePath = @"C:\Users\mjlan\source\repos\LotusMel\CoderGirl-StudentMinMax\studentdata.txt";
            List<Student> studentList = new List<Student>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            Student student = new Student();

            foreach (string line in lines)
            {
                string[] entries = line.Split(' ');
                int[] scores = new int[entries.Length - 1];
                student.Name = entries[0];
                for (int i = 1; i < entries.Length; i++)
                {
                    scores[i - 1] = int.Parse(entries[i]);
                }
                student.Scores = scores;
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();
                

        }

        
    }
}