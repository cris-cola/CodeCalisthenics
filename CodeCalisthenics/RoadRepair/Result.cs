using System.Collections.Generic;
using System.Linq;

namespace CodeCalisthenics.RoadRepair
{
    public class Result
    {
        /**
         * A Number of points along the highway are in need of repair. An equal number of crews are available, stationed at various points along the highway.
         * They must move along the highway to reach an assigned point. Given that one crew must be assigned to each job,
         * what is the minimum total amount of distance traveled by all crews before they can begin to work ?
         *
         * For example, given crews at points {1,3,5}, one possible minimum assignment would be {1->3, 3->5, 5->7} for a total of 6 units traveled.
         * Function Description:
         * Complete the function GetMinCost in the editor below. The function should return the minimum total distance traveled as an integer. 
         */
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