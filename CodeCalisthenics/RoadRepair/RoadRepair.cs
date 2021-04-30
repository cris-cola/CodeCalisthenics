using System;
using System.Collections.Generic;

namespace CodeCalisthenics.RoadRepair
{

    public class RoadRepair
    {
        public static void MainEntrance(string[] args)
        {
            int crewIdCount = Convert.ToInt32(5);//Convert.ToInt32(Console.ReadLine().Trim());

            List<int> crew_id = new List<int> { 5, 3, 1, 6, 9 };
                                            // 1, 3, 5, 6, 9 
            
            int jobIdCount = Convert.ToInt32(5);

            List<int> jobId = new List<int> { 9, 8, 3, 15, 1 };
                                             //1, 3, 8, 9, 15 
            
            var result = Result.GetMinCost(crew_id, jobId);

            Console.Write(result);
        }
    }
}
