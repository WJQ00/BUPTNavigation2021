using System;
using System.Collections;
using System.Collections.Generic;
using StatsTypes;
using Stats;

namespace PATHFinding
{
    //path between two building(or navigation point)
    public struct Path
    {
        public int[] navigationPointsIndex;
        public float time;
    }
    public class PathFinding
    {
        private static PathStats pathStats = new PathStats();
        private static Path[,] minDistanceMatrix = new Path[BaseStats.navigationPointCount + 1, BaseStats.navigationPointCount + 1];
        private static Path[,] minTimeMatrix = new Path[BaseStats.navigationPointCount + 1, BaseStats.navigationPointCount + 1];

        static PathFinding()
        {
            InitMinDistanceMatrix();
        }
        private static void InitMinDistanceMatrix()
        {

        }
        private static void UpdateMinTimeMatrix()
        {
            
        }
        public static int[] GetPath(int startIndex, int endIndex, int flag = 0)
        {
            switch (flag)
            {
                case 0:
                    UpdateMinTimeMatrix();
                    return minTimeMatrix[startIndex, endIndex].navigationPointsIndex;
                case 1:
                    return minDistanceMatrix[startIndex, endIndex].navigationPointsIndex;
                default:
                    return null;
            }
        }
    }
}

