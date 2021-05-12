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
            /*沙河校区*/
            new Building(){index=1,type=Academic,name="SH_ShiYanAcademic"},
            new Building(){index=2,type=Academic,name="SH_XueYuanAcademic_South"},
            new Building(){index=3,type=Academic,name="SH_XueYuanAcademic_North"},
            new Building(){index=4,type=Academic,name="SH_ZongHeAcademic_South"},
            new Building(){index=5,type=Academic,name="SH_ZongHeAcademic_North"},
            new Building(){index=6,type=Office,name="SH_ZongHeOffice"},
            new Building(){index=7,type=Office,name="SH_DormOffice"},
            new Building(){index=8,type=Dorm,name="SH_DormS2"},
            new Building(){index=9,type=Dorm,name="SH_DormS3"},
            new Building(){index=10,type=Dorm,name="SH_DormS4"},
            new Building(){index=11,type=Dorm,name="SH_DormS5"},
            new Building(){index=12,type=Dorm,name="SH_DormB"},
            new Building(){index=13,type=Dorm,name="SH_DormC"},
            new Building(){index=14,type=Dorm,name="SH_DormD"},
            new Building(){index=15,type=Dorm,name="SH_DormE"},
            new Building(){index=16,type=Dining,name="SH_DiningStu"},
            new Building(){index=17,type=Dining,name="SH_DiningTea"},
            new Building(){index=18,type=Dining,name="SH_DiningSouth"},
            new Building(){index=19,type=Store,name="SH_StoreDorm"},
            new Building(){index=20,type=Store,name="SH_StoreStuCenter"},
            new Building(){index=21,type=Coffee,name="SH_CoffeeLibrary"},
            new Building(){index=22,type=Coffee,name="SH_CoffeeDining"},
            new Building(){index=23,type=Printing,name="SH_PrintingDorm"},
            new Building(){index=24,type=Printing,name="SH_PrintingStore"},
            new Building(){index=25,type=Barber,name="SH_Barber"},
            new Building(){index=26,type=Medical,name="SH_Medical"},
            new Building(){index=27,type=StuCenter,name="SH_StuCenter"},
            new Building(){index=28,type=Playground,name="SH_Playground"},
            new Building(){index=29,type=Gate,name="SH_Gate"},
            new Building(){index=30,type=Bus,name="SH_BusStop"},
            /*西土城校区*/
            new Building(){index=31,type=Academic,name="XT_ThefirstAcademic"},
            new Building(){index=32,type=Academic,name="XT_TheSecondAcademic"},
            new Building(){index=33,type=Academic,name="XT_TheThirdAcademic"},
            new Building(){index=34,type=Academic,name="XT_TheForthAcademic"},
            new Building(){index=35,type=Academic,name="XT_EconomyAndManagement"},
            new Building(){index=36,type=Academic,name="XT_InnovationCenter"},
            new Building(){index=37,type=Academic,name="XT_ScientificResearch"},
            new Building(){index=38,type=Academic,name="XT_MainAcademic"},
            new Building(){index=39,type=Dorm,name="XT_Dorm1"},
            new Building(){index=40,type=Dorm,name="XT_Dorm2"},
            new Building(){index=41,type=Dorm,name="XT_Dorm3"},
            new Building(){index=42,type=Dorm,name="XT_Dorm4"},
            new Building(){index=43,type=Dorm,name="XT_Dorm5"},
            new Building(){index=44,type=Dorm,name="XT_Dorm6"},
            new Building(){index=45,type=Dorm,name="XT_Dorm8"},
            new Building(){index=46,type=Dorm,name="XT_Dorm9"},
            new Building(){index=47,type=Dorm,name="XT_Dorm10"},
            new Building(){index=48,type=Dorm,name="XT_Dorm29"},
            new Building(){index=49,type=Dorm,name="XT_InternationalDorm"},
            new Building(){index=50,type=Office,name="XT_Administration"},
            new Building(){index=51,type=Office,name="XT_FinancialOffice"},
            new Building(){index=52,type=Office,name="XT_SecurityOffice"},
            new Building(){index=53,type=Dining,name="XT_StudentCanteen"},
            new Building(){index=54,type=Dining,name="XT_StaffRestaurant"},
            new Building(){index=55,type=Dining,name="XT_SynthesizeCanteen"},
            new Building(){index=56,type=Store,name="XT_XueYuanStore"},
            new Building(){index=57,type=Store,name="XT_NanMenStore"},
            new Building(){index=58,type=Coffee,name="XT_ShiGuang"},
            new Building(){index=59,type=Printing,name="XT_MingGuang"},
            new Building(){index=60,type=Medical,name="XT_SchoolInfirmaty"},
            new Building(){index=61,type=StuCenter,name="XT_StuCenter"},
            new Building(){index=62,type=Playground,name="XT_SportGround"},
            new Building(){index=63,type=Playground,name="XT_Stadium"},
            new Building(){index=64,type=Playground,name="XT_BasketballCourt"},
            new Building(){index=65,type=Bath,name="XT_BathHouse"},
            new Building(){index=66,type=Square,name="XT_ShiGuangSquare"},
            new Building(){index=67,type=Square,name="XT_Fountain"},
            new Building(){index=68,type=Auditorium,name="XT_KeXueAuditorium"},
            new Building(){index=69,type=Library,name="XT_Library"},
            new Building(){index=70,type=Gate,name="XT_EastGate"},
            new Building(){index=71,type=Gate,name="XT_NortheastGate"},
            new Building(){index=72,type=Gate,name="XT_WestGate"},
            new Building(){index=73,type=Gate,name="XT_SouthGate"},
            new Building(){index=74,type=Gate,name="XT_NorthGate"},
            new Building(){index=75,type=Bus,name="XT_MingguangNorthBridge"},
            new Building(){index=76,type=Bus,name="XT_MingguangEastBridge"},
            new Building(){index=77,type=Bus,name="XT_XingtanRoad"},
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