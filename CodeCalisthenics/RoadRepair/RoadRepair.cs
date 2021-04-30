﻿using System;
using System.Collections.Generic;

namespace CodeCalisthenics.RoadRepair
{

    public class RoadRepair
    {
        public static void MainEntrance(string[] args)
        {
            int crewIdCount = Convert.ToInt32(5);

            List<int> crewId = new List<int> { 5, 3, 1, 6, 9 };
            
            int jobIdCount = Convert.ToInt32(5);

            List<int> jobId = new List<int> { 9, 8, 3, 15, 1 };
            
            var result = Result.GetMinCost(crewId, jobId);

            Console.Write(result);
        }
    }
}
