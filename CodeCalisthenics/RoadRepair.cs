using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCalisthenics
{

    public class RoadRepair
    {
        public static void MainEntrance(string[] args)
        {
           int crew_idCount = Convert.ToInt32(5);//Convert.ToInt32(Console.ReadLine().Trim());

            List<int> crew_id = new List<int> { 5, 3, 1, 6, 9 };
                                            // 1, 3, 5, 6, 9 
            
            int job_idCount = Convert.ToInt32(5);

            List<int> job_id = new List<int> { 9, 8, 3, 15, 1 };
                                             //1, 3, 8, 9, 15 
            
            long result = Result.getMinCost(crew_id, job_id);

            Console.Write(result);
        }
    }

    public class Result
    {

        /*
         * Complete the 'getMinCost' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY crew_members
         *  2. INTEGER_ARRAY jobs
         */

        public static long getMinCost(List<int> crew_id, List<int> job_id)
        {
            List<int> crew_members = new List<int>(crew_id.OrderBy(x => x));
            List<int> jobs = new List<int>(job_id.OrderBy(x => x));
            var costs = new List<int>();

            for (var index = 0; index < crew_members.Count; index++)
            {
                var crew = crew_members[index];
                var distances = new List<int>();
                foreach (var job in jobs)
                {
                    var (greater, minor) = GreaterInteger(crew, job);
                    distances.Add(greater - minor);
                }

                crew_members.Remove(crew);

                var minDistance = distances.Min(x => x);

                var jobToRemove = JobToRemove(jobs, distances, minDistance);
                jobs.Remove(jobToRemove);

                costs.Add(minDistance);

            }

            var sum = costs.Sum();

            return sum;
        }

        private static int JobToRemove(List<int> jobs, List<int> distances, int minDistance)
        {
            var minDistanceIndex = distances.IndexOf(minDistance);
            var jobToRemove = jobs.ElementAt(minDistanceIndex);
            return jobToRemove;
        }

        private static (int, int) GreaterInteger(int a, int b)
        {
            return a > b 
                ? (a, b) : (b, a);
        }

    }
}
