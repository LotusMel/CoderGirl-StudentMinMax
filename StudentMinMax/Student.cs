using System.Linq;
using System.IO;

namespace StudentMinMax
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }
        

        public int GetMaximumScore()
        {
            

            int maxScore = Scores.Max();
              return maxScore;
        }

        public int GetMinimumScore()
        {
            
            
            int minScore = Scores.Min();
           return minScore;
        }
    }

    
}