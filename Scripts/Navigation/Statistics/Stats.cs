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
                paths[1, 2].Set(150, 0.98, true);
                paths[1, 3].Set(200, 0.98, true);
                paths[1, 4].Set(110, 0.90, false);
                paths[1, 5].Set(180, 0.75, false);
                paths[1, 21].Set(230, 0.95, true);
            }
            {
                paths[2, 4].Set(220, 0.85, false);
            }
            {
                paths[3, 4].Set(290, 0.85, true);
                paths[3, 5].Set(170, 0.75, true);
                paths[3, 21].Set(110, 0.97, false);
            }
            {
                paths[4, 5].Set(50, 0.35, false);
                paths[4, 18].Set(500, 0.86, true);
                paths[4, 10].Set(380, 0.82, true);
                paths[4, 9].Set(400, 0.82, true);
                paths[4, 27].Set(290, 0.56, true);
                paths[4, 20].Set(350, 0.45, true);
                paths[4, 16].Set(390, 0.58, true);
                paths[4, 19].Set(570, 0.60, true);
            }
            {
                paths[5, 21].Set(70, 0.80, false);
                paths[5, 18].Set(540, 0.85, true);
                paths[5, 7].Set(380, 0.71, true);
                paths[5, 10].Set(420, 0.81, true);
                paths[5, 27].Set(250, 0.48, true);
                paths[5, 20].Set(290, 0.48, true);
                paths[5, 16].Set(370, 0.56, true);
                paths[5, 19].Set(450, 0.76, true);
            }
            {
                paths[6, 16].Set(150, 0.74, false);
                paths[6, 17].Set(140, 0.78, false);
                paths[6, 20].Set(115, 0.84, true);
                paths[6, 21].Set(250, 0.92, false);
                paths[6, 26].Set(140, 0.97, false);
                paths[6, 27].Set(45, 0.88, false);
            }
            {
                paths[7, 8].Set(65, 0.84, true);
                paths[7, 16].Set(190, 0.65, true);
                paths[7, 19].Set(125, 0.83, false);
                paths[7, 20].Set(240, 0.81, true);
                paths[7, 21].Set(410, 0.82, true);
                paths[7, 22].Set(220, 0.76, true);
                paths[7, 27].Set(275, 0.86, true);
                paths[7, 28].Set(240, 0.79, true);
                paths[7, 29].Set(385, 0.87, true);
            }
            {
                paths[8, 9].Set(70, 0.82, true);
            }
            {
                paths[9, 10].Set(50, 0.90, true);
            }
            {
                paths[10, 11].Set(50, 0.94, true);
            }
            {
                paths[11, 18].Set(80, 0.81, true);
            }
            {
                paths[12, 13].Set(45, 0.94, false);
                paths[12, 15].Set(125, 0.92, false);
                paths[12, 16].Set(160, 0.86, false);
                paths[12, 19].Set(44, 0.84, false);
                paths[12, 28].Set(72, 0.80, false);
                paths[12, 29].Set(415, 0.87, true);
            }
            {
                paths[13, 14].Set(100, 0.89, false);
                paths[13, 15].Set(85, 0.96, false);
                paths[13, 16].Set(135, 0.89, false);
                paths[13, 17].Set(122, 0.89, false);
                paths[13, 19].Set(64, 0.96, false);
                paths[13, 28].Set(125, 0.86, false);
            }
            {
                paths[14, 15].Set(60, 0.94, false);
                paths[14, 16].Set(162, 0.85, false);
                paths[14, 17].Set(75, 0.87, false);
                paths[14, 26].Set(250, 0.95, false);
            }
            {
                paths[15, 28].Set(85, 0.84, false);
            }
            {
                paths[16, 17].Set(65, 0.77, false);
                paths[16, 19].Set(145, 0.84, false);
                paths[16, 20].Set(88, 0.81, false);
                paths[16, 22].Set(35, 0.85, false);
                paths[16, 26].Set(265, 0.72, false);
                paths[16, 29].Set(550, 0.89, true);
            }
            {
                paths[17, 19].Set(189, 0.92, false);
                paths[17, 20].Set(140, 0.76, false);
                paths[17, 22].Set(105, 0.81, false);
                paths[17, 26].Set(175, 0.88, false);
                paths[17, 27].Set(170, 0.75, false);
            }
            {
                paths[19, 23].Set(17, 0.81, false);
                paths[19, 25].Set(15, 0.86, false);
                paths[19, 28].Set(110, 0.85, false);
                paths[19, 29].Set(425, 0.86, false);
            }
            {
                paths[20, 22].Set(60, 0.83, false);
                paths[20, 24].Set(20, 0.91, false);
                paths[20, 26].Set(220, 0.81, false);
                paths[20, 27].Set(85, 0.90, false);
            }
            {
                paths[21, 27].Set(210, 0.92, false);
                paths[21, 26].Set(285, 0.98, false);               
            }
            {
                paths[23, 25].Set(20, 0.82, false);
            }
            {
                paths[24, 27].Set(95, 0.91, false);
            }
            {
                paths[26, 27].Set(205, 0.93, false);
            }
            {
                paths[28, 29].Set(405, 0.84, true);
            }
            {
                paths[29, 30].Set(200, 0.95, true);
            }
            #endregion
        }
    }
    //UI data for show details
    public class UIStats
    {

    }
}