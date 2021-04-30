using System.Collections.Generic;
using System.Linq;

namespace CodeCalisthenics.RoadRepair
{
    public class Result
    {
        public static long GetMinCost(List<int> crew_id, List<int> job_id)
        {
            var crewMembers = new List<int>(crew_id.OrderBy(x => x));
            var jobs = new List<int>(job_id.OrderBy(x => x));
            var costs = new List<int>();

            for (var index = 0; index < jobs.Count; index++)
            {
                (int greater, int minor) = GreaterInteger(crewMembers[index], jobs[index]);
                costs.Add(greater - minor);
            }
            
            return costs.Sum();
        }

        private static (int, int) GreaterInteger(int a, int b)
        {
            return a > b 
                ? (a, b) : (b, a);
        }
    }
}