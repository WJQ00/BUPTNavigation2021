using System.Collections;
using System.Collections.Generic;
using StatsTypes;
using UnityEngine;

namespace Stats
{
    //static initiate all const data
    public static class BaseStats
    {
        public const int navigationPointCount = 50;
        public const int offset = 32;
        public static Building[] buildings = new Building[]
        {
            new Building(){index=1,type=Building_type.jiaoxuelou,name="abc"},
        };

        public static schoolbus[] busTable = new schoolbus[]
        {
            new schoolbus(3,new System.DateTime(),new System.DateTime())

        };

    }
    //mono stats,for draw route between two navigation point
    public class AdjacentRouteStats
    {
        private route[,] routes;
        public AdjacentRouteStats()
        {
            routes = new route[BaseStats.navigationPointCount + 1, BaseStats.navigationPointCount + 1];

            #region route data
            for (int i = 1; i < BaseStats.navigationPointCount + 1; i++)
                for (int j = i + 1; j < BaseStats.navigationPointCount + 1; j++)
                {
                    routes[i, j] = new route();
                    routes[i, j].startNavigationPointIndex = i;
                    routes[i, j].endNavigationPointIndex = j;
                }
            {
                routes[1, 2].Set(new int[] { 1,2,3 });
                routes[1, 3].Set(new int[] { 2, 3 }); 

            }
            {
                routes[2, 4].Set(new int[] { 2, 3 });
            }
            {

            }
            #endregion
        }

        public route GetRoute(int startIndex,int endIndex)
        {
            return routes[startIndex, endIndex];
        }
    }
    //algo data for dijkstra
    public class PathStats
    {
        public path[,] paths;
        public PathStats()
        {
            paths = new path[BaseStats.navigationPointCount + 1, BaseStats.navigationPointCount + 1];

            #region path data
            for (int i = 1; i < BaseStats.navigationPointCount + 1; i++)
                for (int j = i + 1; j < BaseStats.navigationPointCount + 1; j++)
                {
                    paths[i, j] = new path();
                    paths[i, j].departure = BaseStats.buildings[i];
                    paths[i, j].destination = BaseStats.buildings[j];
                }

            {
                paths[1, 2].Set(25, 0.5, true);
            }
            {
                paths[5, 12].Set(100, 1, false);
            }
            #endregion
        }
    }
    //UI data for show details
    public class UIStats
    {

    }
}