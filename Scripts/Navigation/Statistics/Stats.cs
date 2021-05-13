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
                routes[1, 3].Set(new int[] { 5, 4 });
                routes[1, 4].Set(new int[] { 10 });
                routes[1, 5].Set(new int[] { 5, 3, 6 });
                routes[1, 21].Set(new int[] { 5, 3, 7 });
            }
            {
                routes[2, 4].Set(new int[] { 1, 2, 5, 10 });
            }
            {
                routes[3, 4].Set(new int[] { 4, 5, 10 });
                routes[3, 5].Set(new int[] { 4, 3, 6 });
                routes[3, 21].Set(new int[] { 4, 3, 7 });
            }
            {
                routes[4, 9].Set(new int[] { 10, 11, 12 });
                routes[4, 10].Set(new int[] { 10, 11 });
                routes[4, 16].Set(new int[] { 8, 13, 14, 15 });
                routes[4, 18].Set(new int[] { 8, 17, 16, 18 });
                routes[4, 19].Set(new int[] { 8, 13, 19, 20 });
                routes[4, 20].Set(new int[] { 8, 13, 14, 15 });
                routes[4, 27].Set(new int[] { 8, 21 });
            }
            {
                routes[5, 7].Set(new int[] { 6, 19 });
                routes[5, 10].Set(new int[] { 22, 23, 11 });
                routes[5, 16].Set(new int[] { 22, 13, 14, 15 });
                routes[5, 18].Set(new int[] { 22, 17, 16, 18 });
                routes[5, 19].Set(new int[] { 22, 13, 19, 20 });
                routes[5, 20].Set(new int[] { 6, 14, 15 });
                routes[5, 21].Set(new int[] { 6, 7 });
                routes[5, 27].Set(new int[] { 6, 13, 21 });
            }
            {
                routes[6, 16].Set(new int[] { 25, 24 });
                routes[6, 17].Set(new int[] { 25, 24 });
                routes[6, 21].Set(new int[] { 26, 13, 7 });
                routes[6, 26].Set(new int[] { 25, 27, 28 });
                routes[6, 27].Set(new int[] { 25, 26, 21 });
            }
            {
                routes[7, 16].Set(new int[] { 29, 30 });
                routes[7, 19].Set(new int[] { 20 });
                routes[7, 20].Set(new int[] { 19, 14, 15 });
                routes[7, 21].Set(new int[] { 19, 7 });
                routes[7, 22].Set(new int[] { 19, 14, 15 });
                routes[7, 27].Set(new int[] { 19, 13, 21 });
                routes[7, 28].Set(new int[] { 19, 31, 32 });
                routes[7, 29].Set(new int[] { 19 });
            }
            {
                routes[11, 18].Set(new int[] { 16, 18 });
            }
            {
                routes[12, 15].Set(new int[] { 33, 32 });
                routes[12, 16].Set(new int[] { 30 });
                routes[12, 28].Set(new int[] { 33, 32 });
                routes[12, 29].Set(new int[] { 33, 31 });
            }
            {
                routes[13, 14].Set(new int[] { 34, 35, 36 });
                routes[13, 15].Set(new int[] { 34, 37, 32 });
                routes[13, 16].Set(new int[] { 34, 24 });
                routes[13, 17].Set(new int[] { 34, 24 });
                routes[13, 28].Set(new int[] { 34, 37, 32 });
            }
            {
                routes[14, 16].Set(new int[] { 36, 30 });
                routes[14, 26].Set(new int[] { 36, 38, 28 });
            }
            {
                routes[16, 19].Set(new int[] { 30 });
                routes[16, 26].Set(new int[] { 15, 28 });
                routes[16, 29].Set(new int[] { 30, 9 });
            }
            {
                routes[17, 19].Set(new int[] { 24, 35, 30 });
                routes[17, 20].Set(new int[] { 24, 27 });
                routes[17, 22].Set(new int[] { 24, 27, 15 });
                routes[17, 26].Set(new int[] { 24, 27, 28 });
                routes[17, 27].Set(new int[] { 24, 26, 21 });
            }
            {
                routes[19, 28].Set(new int[] { 20, 19, 31, 32 });
                routes[19, 29].Set(new int[] { 20, 19 });
            }
            {
                routes[20, 26].Set(new int[] { 27, 28 });
                routes[20, 27].Set(new int[] { 27, 26, 21 });
            }
            {
                routes[21, 26].Set(new int[] { 7, 14, 28 });
                routes[21, 27].Set(new int[] { 7, 13, 21 });
            }
            {
                routes[24, 27].Set(new int[] { 15, 27, 26, 21 });
            }
            {
                routes[26, 27].Set(new int[] { 28, 27, 26, 21 });
            }
            {
                routes[28, 29].Set(new int[] { 32, 31 });
            }
            {
                routes[31, 32].Set(new int[] { 1, 2 });
                routes[31, 33].Set(new int[] { 1, 2 });
                routes[31, 34].Set(new int[] { 1 });
                routes[31, 38].Set(new int[] { 3 });
                routes[31, 40].Set(new int[] { 1, 4 });
                routes[31, 51].Set(new int[] { 1 });
                routes[31, 63].Set(new int[] { 5, 6, 7 });
                routes[31, 67].Set(new int[] { 3, 9 });
                routes[31, 68].Set(new int[] { 5, 64, 11 });
            }
            {
                routes[32, 33].Set(new int[] { 2 });
                routes[32, 34].Set(new int[] { 2, 1 });
                routes[32, 36].Set(new int[] { 12, 13 });
                routes[32, 38].Set(new int[] { 14 });
                routes[32, 57].Set(new int[] { 2 });
                routes[32, 60].Set(new int[] { 2, 15 });
                routes[32, 62].Set(new int[] { 12, 16, 17, 18 });
                routes[32, 67].Set(new int[] { 14, 10 });
            }
            {
                routes[33, 34].Set(new int[] { 2, 1 });
                routes[33, 36].Set(new int[] { 2, 19 });
                routes[33, 57].Set(new int[] { 2 });
                routes[33, 60].Set(new int[] { 2, 15 });
                routes[33, 67].Set(new int[] { 20, 10 });
                routes[33, 72].Set(new int[] { 21, 22 });
            }
            {
                routes[34, 39].Set(new int[] { 23, 24 });
                routes[34, 40].Set(new int[] { 1, 4 });
                routes[34, 51].Set(new int[] { 1 });
            }
            {
                routes[35, 44].Set(new int[] { 25, 27, 28 });
                routes[35, 47].Set(new int[] { 26, 29 });
                routes[35, 55].Set(new int[] { 26, 29, 30 });
                routes[35, 61].Set(new int[] { 26, 31 });
                routes[35, 65].Set(new int[] { 26, 32 });
                routes[35, 74].Set(new int[] { 25 });
            }
            {
                routes[36, 38].Set(new int[] { 13, 16, 14 });
                routes[36, 60].Set(new int[] { 19, 15 });
                routes[36, 62].Set(new int[] { 33, 18 });
                routes[36, 63].Set(new int[] { 33, 34 });
                routes[36, 68].Set(new int[] { 13, 16, 35 });
            }
            {
                routes[37, 44].Set(new int[] { 36 });
                routes[37, 52].Set(new int[] { 37, 38 });
                routes[37, 53].Set(new int[] { 37, 39, 40 });
                routes[37, 56].Set(new int[] { 37 });
                routes[37, 64].Set(new int[] { 37, 39 });
                routes[37, 65].Set(new int[] { 37 });
                routes[37, 71].Set(new int[] { 36 });
            }
            {
                routes[38, 62].Set(new int[] { 14, 17, 18 });
                routes[38, 63].Set(new int[] { 3, 41, 34 });
                routes[38, 68].Set(new int[] { 3, 11 });
            }
            {
                routes[39, 41].Set(new int[] { 24, 42 });
                routes[39, 42].Set(new int[] { 45, 43 });
                routes[39, 43].Set(new int[] { 45, 44 });
                routes[39, 45].Set(new int[] { 45, 44 });
                routes[39, 51].Set(new int[] { 4 });
                routes[39, 72].Set(new int[] { 24, 22 });
            }
            {
                routes[40, 41].Set(new int[] { 45, 43 });
                routes[40, 42].Set(new int[] { 45, 43 });
                routes[40, 43].Set(new int[] { 45, 44 });
                routes[40, 45].Set(new int[] { 45, 44 });
                routes[40, 50].Set(new int[] { 65 });
                routes[40, 66].Set(new int[] { 65 });
                routes[40, 69].Set(new int[] { 65 });
            }
            {
                routes[41, 43].Set(new int[] { 43, 44 });
                routes[41, 45].Set(new int[] { 43, 44 });
            }
            {
                routes[42, 43].Set(new int[] { 43, 44 });
                routes[42, 45].Set(new int[] { 43, 44 });
                routes[42, 51].Set(new int[] { 46 });
                routes[42, 54].Set(new int[] { 46, 40 });
                routes[42, 56].Set(new int[] { 46 });
                routes[42, 61].Set(new int[] { 46, 48 });
                routes[42, 66].Set(new int[] { 46 });
                routes[42, 69].Set(new int[] { 46 });
            }
            {
                routes[43, 49].Set(new int[] { 44, 48 });
                routes[43, 55].Set(new int[] { 44, 48 });
            }
            {
                routes[44, 53].Set(new int[]{ 28, 40 });
                routes[44, 54].Set(new int[]{ 28 });
                routes[44, 61].Set(new int[]{ 26, 31 });
                routes[44, 65].Set(new int[]{ 32 });
                routes[44, 71].Set(new int[]{ 28 });
                routes[44, 74].Set(new int[]{ 28,27 });
            }
            {
                routes[45, 47].Set(new int[] { 44, 51, 50 });
                routes[45, 49].Set(new int[] { 44, 48 });
                routes[45, 54].Set(new int[] { 47, 46, 40 });
                routes[45, 55].Set(new int[] { 44, 48 });
                routes[45, 56].Set(new int[] { 47 });
                routes[45, 61].Set(new int[] { 47, 48 });
                routes[45, 66].Set(new int[] { 47 });
                routes[45, 74].Set(new int[] { 47 });
            }
            {
                routes[46, 47].Set(new int[] { 50 });
                routes[46, 55].Set(new int[] { 51, 48 });
                routes[46, 74].Set(new int[] { 51, 52 });
            }
            {
                routes[47, 49].Set(new int[] { 50 });
                routes[47, 61].Set(new int[] { 29, 31 });
                routes[47, 74].Set(new int[] { 29 });
            }
            {
                routes[48, 50].Set(new int[] { 65 });
                routes[48, 52].Set(new int[] { 7 });
                routes[48, 53].Set(new int[] { 7, 53 });
                routes[48, 63].Set(new int[] { 7 });
                routes[48, 64].Set(new int[] { 6 });
                routes[48, 71].Set(new int[] { 7, 53, 55 });
            }
            {
                routes[49, 55].Set(new int[] { 48 });
            }
            {
                routes[50, 51].Set(new int[] { 65, 4 });
                routes[50, 64].Set(new int[] { 65, 6 });
                routes[50, 66].Set(new int[] { 65 });
                routes[50, 69].Set(new int[] { 65 });
            }
            {
                routes[51, 69].Set(new int[] { 4 });
            }
            {
                routes[52, 53].Set(new int[] { 53 });
                routes[52, 71].Set(new int[] { 38, 56 });
            }
            {
                routes[53, 54].Set(new int[] { 40 });
                routes[53, 56].Set(new int[] { 40, 39 });
                routes[53, 64].Set(new int[] { 40 });
                routes[53, 65].Set(new int[] { 40, 39 });
                routes[53, 66].Set(new int[] { 40, 57 });
                routes[53, 69].Set(new int[] { 40, 57 });
            }
            {
                routes[54, 65].Set(new int[] { 39 });
                routes[54, 66].Set(new int[] { 40, 57 });
                routes[54, 69].Set(new int[] { 40, 57 });
            }
            {
                routes[55, 56].Set(new int[] { 30 });
                routes[55, 61].Set(new int[] { 30, 31 });
                routes[55, 65].Set(new int[] { 30, 48 });
                routes[55, 66].Set(new int[] { 30, 8 });
                routes[55, 74].Set(new int[] { 30 });
            }
            {
                routes[56, 61].Set(new int[] { 48 });
                routes[56, 66].Set(new int[] { 57 });
                routes[56, 69].Set(new int[] { 57 });
            }
            {
                routes[57, 58].Set(new int[] { 15 });
                routes[57, 59].Set(new int[] { 15, 58, 59 });
                routes[57, 60].Set(new int[] { 15 });
                routes[57, 73].Set(new int[] { 60, 61 });
            }
            {
                routes[58, 59].Set(new int[] { 58, 59 });
            }
            {
                routes[59, 60].Set(new int[] { 59, 58 });
            }
            {
                routes[60, 67].Set(new int[] { 15, 62 });
                routes[60, 72].Set(new int[] { 15, 62 });
                routes[60, 73].Set(new int[] { 15, 60, 61 });
            }
            {
                routes[61, 65].Set(new int[] { 48 });
                routes[61, 66].Set(new int[] { 48 });
                routes[61, 74].Set(new int[] { 31 });
            }
            {
                routes[62, 63].Set(new int[] { 63 });
                routes[62, 67].Set(new int[] { 18, 17, 10 });
                routes[62, 68].Set(new int[] { 18, 35 });
            }
            {
                routes[63, 64].Set(new int[] { 7, 6 });
                routes[63, 68].Set(new int[] { 34, 41, 11 });
                routes[63, 69].Set(new int[] { 7, 65 });
                routes[63, 70].Set(new int[] { 7 });
            }
            {
                routes[64, 65].Set(new int[] { 39 });
                routes[64, 66].Set(new int[] { 6, 65 });
                routes[64, 68].Set(new int[] { 64, 11 });
                routes[64, 69].Set(new int[] { 6, 65 });
                routes[64, 70].Set(new int[] { 6 });
            }
            {
                routes[66, 67].Set(new int[] { 8, 62 });
            }
            {
                routes[67, 68].Set(new int[] { 10, 16, 35 });
            }
            {
                routes[68, 69].Set(new int[] { 11, 64, 6, 65 });
            }
            {
                routes[69, 70].Set(new int[] { 65 });
            }
            {
                routes[73, 75].Set(new int[] { 66 });
            }
        }
        #endregion
        }

        public route GetRoute(int startIndex, int endIndex)
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
                paths[4, 9].Set(400, 0.82, true);
                paths[4, 10].Set(380, 0.82, true);
                paths[4, 16].Set(390, 0.58, true);
                paths[4, 18].Set(500, 0.86, true);                
                paths[4, 19].Set(570, 0.60, true);
                paths[4, 20].Set(350, 0.45, true);
                paths[4, 27].Set(290, 0.56, true);
            }
            {
                paths[5, 7].Set(380, 0.71, true);
                paths[5, 10].Set(420, 0.81, true);
                paths[5, 16].Set(370, 0.56, true);               
                paths[5, 18].Set(540, 0.85, true);
                paths[5, 19].Set(450, 0.76, true);
                paths[5, 20].Set(290, 0.48, true);
                paths[5, 21].Set(70, 0.80, false);
                paths[5, 27].Set(250, 0.48, true);
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
            {
                paths[31, 32].Set(200, 0.88, true);
                paths[31, 33].Set(200, 0.88, true);
                paths[31, 34].Set(32, 0.45, false);
                paths[31, 38].Set(67, 0.51, false);
                paths[31, 40].Set(45, 0.88, true);
                paths[31, 50].Set(5, 0.66, false);
                paths[31, 51].Set(43, 0.88, true);
                paths[31, 63].Set(185, 0.51, true);
                paths[31, 67].Set(80, 0.58, false);
                paths[31, 68].Set(57, 0.33, true);
            }
            {
                paths[32, 33].Set(32, 0.45, false);
                paths[32, 34].Set(205, 0.88, true);
                paths[32, 36].Set(75, 0.26, true);
                paths[32, 38].Set(60, 0.71, true);
                paths[32, 57].Set(113, 0.88, true);
                paths[32, 60].Set(130, 0.76, true);
                paths[32, 62].Set(181, 0.56, true);
                paths[32, 67].Set(98, 0.71, false);
            }
            {
                paths[33, 34].Set(200, 0.88, true);
                paths[33, 36].Set(227, 0.26, true);
                paths[33, 57].Set(113, 0.88, true);
                paths[33, 60].Set(98, 0.77, true);
                paths[33, 67].Set(100, 0.65, true);
                paths[33, 72].Set(165, 0.26, true);
            }
            {
                paths[34, 39].Set(79, 0.11, false);
                paths[34, 40].Set(79, 0.88, true);
                paths[34, 51].Set(33, 0.88, true);
            }
            {
                paths[35, 44].Set(173, 0.22, false);
                paths[35, 47].Set(60, 0.58, false);
                paths[35, 55].Set(90, 0.88, true);
                paths[35, 61].Set(20, 0.29, false);
                paths[35, 65].Set(80, 0.41, false);
                paths[35, 74].Set(38, 0.31, false);
            }
            {
                paths[36, 38].Set(240, 0.53, true);
                paths[36, 60].Set(220, 0.26, true);
                paths[36, 62].Set(123, 0.59, true);
                paths[36, 63].Set(210, 0.59, true);
                paths[36, 68].Set(174, 0.33, true);
            }
            {
                paths[37, 44].Set(70, 0.47, false);
                paths[37, 52].Set(95, 0.07, false);
                paths[37, 53].Set(76, 0.47, false);
                paths[37, 56].Set(105, 0.96, true);
                paths[37, 64].Set(200, 0.47, true);
                paths[37, 65].Set(95, 0.96, true);
                paths[37, 71].Set(160, 0.24, true);
            }
            {
                paths[38, 62].Set(180, 0.55, true);
                paths[38, 63].Set(200, 0.65, true);
                paths[38, 67].Set(28, 0.36, false);
                paths[38, 68].Set(110, 0.43, true);
                paths[38, 72].Set(290, 0.33, false);
            }
            {
                paths[39, 40].Set(45, 0.51, true);
                paths[39, 41].Set(80, 0.11, false);
                paths[39, 42].Set(80, 0.36, false);
                paths[39, 43].Set(140, 0.36, false);
                paths[39, 45].Set(140, 0.36, false);
                paths[39, 51].Set(160, 0.51, true);
                paths[39, 72].Set(200, 0.11, true);
            }
            {
                paths[40, 41].Set(80, 0.36, false);
                paths[40, 42].Set(80, 0.36, false);
                paths[40, 43].Set(140, 0.36, false);
                paths[40, 45].Set(140, 0.36, false);
                paths[40, 50].Set(120, 0.51, true);
                paths[40, 51].Set(55, 0.66, false);
                paths[40, 66].Set(58, 0.24, false);
                paths[40, 69].Set(170, 0.51, false);
            }
            {
                paths[41, 42].Set(45, 0.36, false);
                paths[41, 43].Set(80, 0.36, false);
                paths[41, 45].Set(80, 0.36, false);
            }
            {
                paths[42, 43].Set(80, 0.36, false);
                paths[42, 45].Set(80, 0.36, false);
                paths[42, 51].Set(115, 0.88, true);
                paths[42, 54].Set(130, 0.26, true);
                paths[42, 56].Set(125, 0.24, false);
                paths[42, 61].Set(155, 0.37, false);
                paths[42, 66].Set(65, 0.32, false);
                paths[42, 69].Set(95, 0.32, false);
            }      
            {
                paths[43, 45].Set(45, 0.36, false);
                paths[43, 49].Set(75, 0.77, false);
                paths[43, 55].Set(28, 0.77, false);
            }
            {
                paths[44, 53].Set(100, 0.47, true);
                paths[44, 54].Set(95, 0.47, true);
                paths[44, 61].Set(55, 0.24, false);
                paths[44, 65].Set(57, 0.33, false);
                paths[44, 71].Set(180, 0.24, true);
                paths[44, 74].Set(115, 0.14, false);
            }
            {
                paths[45, 47].Set(100, 0.77, false);
                paths[45, 49].Set(50, 0.77, false);
                paths[45, 54].Set(120, 0.96, true);
                paths[45, 55].Set(25, 0.77, false);
                paths[45, 56].Set(90, 0.13, false);
                paths[45, 61].Set(89, 0.88, false);
                paths[45, 66].Set(95, 0.88, true);
                paths[45, 74].Set(130, 0.88, true);
            }
            {
                paths[46, 47].Set(40, 0.22, false);
                paths[46, 49].Set(16, 0.29, false);
                paths[46, 55].Set(35, 0.49, false);
                paths[46, 74].Set(95, 0.22, false);
            }
            {
                paths[47, 49].Set(55, 0.49, false);
                paths[47, 55].Set(15, 0.49, false);
                paths[47, 61].Set(37, 0.78, true);
                paths[47, 74].Set(30, 0.88, true);
            }
            {
                paths[48, 50].Set(170, 0.51, true);
                paths[48, 52].Set(99, 0.38, true);
                paths[48, 53].Set(80, 0.38, true);
                paths[48, 63].Set(30, 0.44, false);
                paths[48, 64].Set(95, 0.51, true);
                paths[48, 70].Set(28, 0.51, true);
                paths[48, 71].Set(175, 0.16, true);
            }
            {
                paths[49, 55].Set(45, 0.36, false);
            }
            {
                paths[50, 51].Set(103, 0.21, true);
                paths[50, 64].Set(90, 0.51, true);
                paths[50, 66].Set(55, 0.51, false);
                paths[50, 69].Set(36, 0.51, false);
            }
            {
                paths[51, 66].Set(45, 0.88, true);
                paths[51, 69].Set(85, 0.21, false);
            }
            {
                paths[52, 53].Set(90, 0.11, false);
                paths[52, 71].Set(105, 0.14, true);
            }
            {
                paths[53, 54].Set(20, 0.47, false);
                paths[53, 56].Set(95, 0.96, true);
                paths[53, 64].Set(80, 0.47, true);
                paths[53, 65].Set(88, 0.96, true);
                paths[53, 66].Set(115, 0.26, true);
                paths[53, 69].Set(115, 0.26, true);
            }
            {
                paths[54, 56].Set(5, 0.79, false);
                paths[54, 64].Set(100, 0.47, true);
                paths[54, 65].Set(65, 0.47, true);
                paths[54, 66].Set(60, 0.26, false);
                paths[54, 69].Set(60, 0.26, false);
            }
            {
                paths[55, 56].Set(100, 0.67, false);
                paths[55, 61].Set(32, 0.88, true);
                paths[55, 65].Set(95, 0.96, true);
                paths[55, 66].Set(170, 0.88, true);
                paths[55, 74].Set(85, 0.88, true);
            }
            {
                paths[56, 61].Set(45, 0.96, false);
                paths[56, 65].Set(15, 0.96, false);
                paths[56, 66].Set(55, 0.68, false);
                paths[56, 69].Set(70, 0.53, false);
            }
            {
                paths[57, 58].Set(49, 0.22, true);
                paths[57, 59].Set(360, 0.22, true);
                paths[57, 60].Set(15, 0.22, false);
                paths[57, 73].Set(180, 0.90, true);
            }
            {
                paths[58, 59].Set(400, 0.22, true);
                paths[58, 60].Set(65, 0.22, true);
            }
            {
                paths[59, 60].Set(305, 0.06, true);
            }
            {
                paths[60, 67].Set(165, 0.88, true);
                paths[60, 72].Set(260, 0.65, true);
                paths[60, 73].Set(200, 0.90, true);
            }
            {
                paths[61, 65].Set(15, 0.45, false);
                paths[61, 66].Set(140,0.88, true);
                paths[61, 74].Set(80, 0.88, true);
            }
            {
                paths[62, 63].Set(65, 0.19, false);
                paths[62, 67].Set(195, 0.55, true);
                paths[62, 68].Set(60, 0.29, false);
            }
            {
                paths[63, 64].Set(85, 0.51, true);
                paths[63, 68].Set(65, 0.59, true);
                paths[63, 69].Set(105, 0.51, true);
                paths[63, 70].Set(80, 0.51, true);
            }
            {
                paths[64, 65].Set(195,0.47, true);
                paths[64, 66].Set(175,0.51, true);
                paths[64, 68].Set(150,0.47, true);
                paths[64, 69].Set(35, 0.75, false);
                paths[64, 70].Set(160, 0.51, true);
            }
            {
                paths[66, 67].Set(225,0.88, true);
                paths[66, 69].Set(45, 0.24, false);
            }
            {
                paths[67, 68].Set(75, 0.65, true);
                paths[67, 72].Set(205, 0.12, false);
            }
            {
                paths[68, 69].Set(190, 0.33, true);
            }
            {
                paths[69, 70].Set(220, 0.51, true);
            }
            {
                paths[70, 77].Set(60, 0.68, true);
            }
            {
                paths[71, 77].Set(310, 0.68, true);
            }
            {
                paths[72, 75].Set(290, 0.79, true);
            }
            {
                paths[73, 75].Set(315, 0.61, true);
                paths[73, 75].Set(15, 0.61, true);
            }
         #endregion
        }
    }
    //UI data for show details
    public class UIStats
    {

    }
}