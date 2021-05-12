#include "mapinfo.h"
#include <stdio.h>

/*
沙河校区 15个建筑物+13个服务设施 +大门+公交站
教学楼Academic： 5个 综合南；综合北；学院南；学院北；实验
办公楼Office：2个 综合办公楼；宿舍楼旁边的办公楼
宿舍楼Dorm:8个 宿舍S2;宿舍S3;宿舍S4;宿舍S5;宿舍B;宿舍C;宿舍D;宿舍E
食堂Dining:3个 学生食堂Stu；教工食堂Tea；南区食堂South
超市Store: 2个 雁北超市；小麦铺
咖啡厅Coffee: 2个 图书馆下方；食堂旁边
操场Playground: 1个 大操场
打印店 Printing: 2个 小麦铺打印店；雁北打印店
理发店 Barber: 1个 雁北理发店
医务室Medical: 1个 医务室
学活StuCenter: 1个 学活
//邮局ATM: 1个 学活ATM
//快递站Express: 1个 快递站
//信息楼Information: 1个 信息楼S1
正门Gate: 1个 正门
公交站Bus: 1个 公交站
*/
building _01 = { 1,Academic,"SH_ShiYanAcademic" };
building _02 = { 2,Academic,"SH_XueYuanAcademic_South" };
building _03 = { 3,Academic,"SH_XueYuanAcademic_North" };
building _04 = { 4,Academic,"SH_ZongHeAcademic_South" };
building _05 = { 5,Academic,"SH_ZongHeAcademic_North" };
building _06 = { 6,Office,"SH_ZongHeOffice" };
building _07 = { 7,Office,"SH_DormOffice" };
building _08 = { 8,Dorm,"SH_DormS2" };
building _09 = { 9,Dorm,"SH_DormS3" };
building _10 = { 10,Dorm,"SH_DormS4" };
building _11 = { 11,Dorm,"SH_DormS5" };
building _12 = { 12,Dorm,"SH_DormB" };
building _13 = { 13,Dorm,"SH_DormC" };
building _14 = { 14,Dorm,"SH_DormD" };
building _15 = { 15,Dorm,"SH_DormE" };
building _16 = { 16,Dining,"SH_DiningStu" };
building _17 = { 17,Dining,"SH_DiningTea" };
building _18 = { 18,Dining,"SH_DiningSouth" };
building _19 = { 19,Store,"SH_StoreDorm" };
building _20 = { 20,Store,"SH_StoreStuCenter" };
building _21 = { 21,Coffee,"SH_CoffeeLibrary" };
building _22 = { 22,Coffee,"SH_CoffeeDining" };
building _23 = { 23,Printing,"SH_PrintingDorm" };
building _24 = { 24,Printing,"SH_PrintingStore" };
building _25 = { 25,Barber,"SH_Barber" };
building _26 = { 26,Medical,"SH_Medical" };
building _27 = { 27,StuCenter,"SH_StuCenter" };
building _28 = { 28,Playground,"SH_Playground" };
building _29 = { 29,Gate,"SH_Gate" };
building _30 = { 30,Bus,"SH_BusStop" };
building building_list[30] = { _01,_02,_03,_04,_05,_06,_07,_08,_09,_10,
_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,
_21,_22,_23,_24,_25,_26,_27,_28,_29,_30 };

path path1 = { 150,0.98,1,_01,_02 }; path path2 = { 200,0.98,1,_01,_03 }; path path3 = { 110,0.90,0,_01,_04 }; path path4 = { 180,0.75,0,_01,_05 }; path path5 = { 230,0.95,1,_01,_21 };
path path6 = { 220,0.85,0,_02,_04 }; path path7 = { 110,0.97,0,_03,_21 }; path path8 = { 170,0.75,1,_03,_05 }; path path9 = { 290,0.85,1,_03,_04 };
path path10 = { 50,0.35,0,_04,_05 }; path path11 = { 500,0.86,1,_04,_18 }; path path12 = { 380,0.82,1,_04,_10 }; path path13 = { 400,0.82,1,_04,_09 };
path path14 = { 290,0.56,1,_04,_27 }; path path15 = { 350,0.45,1,_04,_20 }; path path16 = { 390,0.58,1,_04,_16 }; path path17 = { 570,0.60,1,_04,_19 };
path path18 = { 70,0.80,0,_05,_21 }; path path19 = { 540,0.85,1,_05,_18 }; path path20 = { 380,0.71,1,_05,_07 }; path path21 = { 420,0.81,1,_05,_10 };
path path22 = { 250,0.48,1,_05,_27 }; path path23 = { 290,0.48,1,_05,_20 }; path path24 = { 370,0.56,1,_05,_16 }; path path25 = { 450,0.76,1,_05,_19 };
path path26 = { 210,0.92,0,_21,_27 }; path path27 = { 250,0.92,0,_21,_06 }; path path28 = { 285,0.98,0,_21,_26 }; path path29 = { 410,0.82,1,_21,_07 };
//以上为国脉路东侧的建筑物的道路 
path path30 = { 80,0.81,1,_18,_11 }; path path31 = { 50,0.94,1,_11,_10 }; path path32 = { 50,0.90,1,_10,_09 };
path path33 = { 70,0.82,1,_09,_08 }; path path34 = { 65,0.84,1,_08,_07 }; path path35 = { 385,0.87,1,_07,_29 };
path path36 = { 125,0.83,0,_07,_19 }; path path37 = { 240,0.79,1,_07,_28 }; path path38 = { 190,0.65,1,_07,_16 };
path path39 = { 220,0.76,1,_07,_22 }; path path40 = { 240,0.81,1,_07,_20 }; path path41 = { 275,0.86,1,_07,_27 };
//以上为鸿雁路南侧建筑物的道路 
path path42 = { 140,0.97,0,_26,_06 }; path path43 = { 175,0.88,0,_26,_17 }; path path44 = { 220,0.81,0,_26,_20 };
path path45 = { 205,0.93,0,_26,_27 }; path path46 = { 265,0.72,0,_26,_16 }; path path47 = { 250,0.95,0,_26,_14 };
path path48 = { 140,0.78,0,_06,_17 }; path path49 = { 45,0.88,0,_06,_27 }; path path50 = { 115,0.84,1,_06,_20 };
path path51 = { 150,0.74,0,_06,_16 }; path path52 = { 85,0.90,0,_27,_20 };
path path53 = { 95,0.91,0,_27,_24 }; path path54 = { 170,0.75,0,_27,_17 }; path path55 = { 20,0.91,0,_20,_24 };
path path56 = { 60,0.83,0,_20,_22 }; path path57 = { 88,0.81,0,_20,_16 }; path path58 = { 140,0.76,0,_20,_17 };
//以上为医务室办公楼和学活的道路  
path path59 = { 65,0.77,0,_17,_16 }; path path60 = { 105,0.81,0,_17,_22 }; path path61 = { 75,0.87,0,_17,_14 };
path path62 = { 122,0.89,0,_17,_13 }; path path63 = { 189,0.92,0,_17,_19 }; path path64 = { 35,0.85,0,_22,_16 };
path path65 = { 145,0.84,0,_16,_19 }; path path66 = { 160,0.86,0,_16,_12 }; path path67 = { 135,0.89,0,_16,_13 };
path path68 = { 162,0.85,0,_14,_16 }; path path69 = { 550,0.89,1,_16,_29 };
//以上为学生食堂+教工食堂的道路
path path70 = { 60,0.94,0,_14,_15 }; path path71 = { 100,0.89,0,_14,_13 };
path path72 = { 85,0.96,0,_15,_13 }; path path73 = { 125,0.92,0,_15,_12 }; path path74 = { 85,0.84,0,_15,_28 };
path path75 = { 45,0.94,0,_13,_12 }; path path76 = { 64,0.96,0,_13,_19 }; path path77 = { 125,0.86,0,_13,_28 };
path path78 = { 72,0.80,0,_12,_28 }; path path79 = { 44,0.84,0,_12,_19 }; path path80 = { 415,0.87,1,_12,_29 };
path path81 = { 17,0.81,0,_19,_23 }; path path82 = { 15,0.86,0,_19,_25 }; path path83 = { 20,0.82,0,_23,_25 };
path path84 = { 110,0.85,0,_19,_28 }; path path85 = { 425,0.86,0,_29,_19 };
path path86 = { 405,0.84,1,_28,_29 }; path path87 = { 200,0.95,1,_29,_30 };
//以上为鸿雁路以南建筑物的道路 

/*本部校区信息*/
/*教学楼Academic：8个
  宿舍Dorm：11个
  办公楼Office：3个
  餐厅Dining：3个
  超市Store：2个
  咖啡厅Coffee：1个
  打印店Printing：1个
  校医院Medical：1个
  学生中心StuCenter：1个
  体育场Playground：3个
  澡堂Bath：1个
  广场Square：2个
  礼堂Auditorium：1个
  图书馆Library：1个
  大门Gate：5个
  车站Bus：3个
*/
building XT_01 = { 31,Academic,"XT_ThefirstAcademic" };
building XT_02 = { 32,Academic,"XT_TheSecondAcademic" };
building XT_03 = { 33,Academic,"XT_TheThirdAcademic" };
building XT_04 = { 34,Academic,"XT_TheForthAcademic" };
building XT_05 = { 35,Academic,"XT_EconomyAndManagement" };
building XT_06 = { 36,Academic,"XT_InnovationCenter" };
building XT_07 = { 37,Academic,"XT_ScientificResearch" };
building XT_08 = { 38,Academic,"XT_MainAcademic" };
building XT_09 = { 39,Dorm,"XT_Dorm1" };
building XT_10 = { 40,Dorm,"XT_Dorm2" };
building XT_11 = { 41,Dorm,"XT_Dorm3" };
building XT_12 = { 42,Dorm,"XT_Dorm4" };
building XT_13 = { 43,Dorm,"XT_Dorm5" };
building XT_14 = { 44,Dorm,"XT_Dorm6" };
building XT_15 = { 45,Dorm,"XT_Dorm8" };
building XT_16 = { 46,Dorm,"XT_Dorm9" };
building XT_17 = { 47,Dorm,"XT_Dorm10" };
building XT_18 = { 48,Dorm,"XT_Dorm29" };
building XT_19 = { 49,Dorm,"XT_InternationalDorm" };
building XT_20 = { 50,Office,"XT_Administration" };
building XT_21 = { 51,Office,"XT_FinancialOffice" };
building XT_22 = { 52,Office,"XT_SecurityOffice" };
building XT_23 = { 53,Dining,"XT_StudentCanteen" };
building XT_24 = { 54,Dining,"XT_StaffRestaurant" };
building XT_25 = { 55,Dining,"XT_SynthesizeCanteen" };
building XT_26 = { 56,Store,"XT_XueYuanStore" };
building XT_27 = { 57,Store,"XT_NanMenStore" };
building XT_28 = { 58,Coffee,"XT_ShiGuang" };
building XT_29 = { 59,Printing,"XT_MingGuang" };
building XT_30 = { 60,Medical,"XT_SchoolInfirmaty" };
building XT_31 = { 61,StuCenter,"XT_StuCenter" };
building XT_32 = { 62,Playground,"XT_SportGround" };
building XT_33 = { 63,Playground,"XT_Stadium" };
building XT_34 = { 64,Playground,"XT_BasketballCourt" };
building XT_35 = { 65,Bath,"XT_BathHouse" };
building XT_36 = { 66,Square,"XT_ShiGuangSquare" };
building XT_37 = { 67,Square,"XT_Fountain" };
building XT_38 = { 68,Auditorium,"XT_KeXueAuditorium" };
building XT_39 = { 69,Library,"XT_Library" };
building XT_40 = { 70,Gate,"XT_EastGate" };
building XT_41 = { 71,Gate,"XT_NortheastGate" };
building XT_42 = { 72,Gate,"XT_WestGate" };
building XT_43 = { 73,Gate,"XT_SouthGate" };
building XT_44 = { 74,Gate,"XT_NorthGate" };
building XT_45 = { 75,Bus,"XT_MingguangNorthBridge" };
building XT_46 = { 76,Bus,"XT_MingguangEastBridge" };
building XT_47 = { 77,Bus,"XT_XingtanRoad" };
building XTbuilding_list[50] = { XT_01,XT_02,XT_03,XT_04,XT_05,XT_06,XT_07,XT_08,XT_09,XT_10,
XT_11,XT_12,XT_13,XT_14,XT_15,XT_16,XT_17,XT_18,XT_19,XT_20,
XT_21,XT_22,XT_23,XT_24,XT_25,XT_26,XT_27,XT_28,XT_29,XT_30,XT_31,XT_32,XT_33,XT_34,XT_35,XT_36,XT_37,XT_38,XT_39,XT_40,XT_41,XT_42,
XT_43,XT_44,XT_45,XT_46,XT_47};
static struct path XT_path[55][55] = {0};
void XT_pathgeneration() {
XT_path[1][2] = { 200,0.88,1,XT_01,XT_02 }; XT_path[1][3] = { 200,0.88,1,XT_01,XT_03 }; XT_path[1][4] = { 32,0.45,1,XT_01,XT_04 };  XT_path[1][6] = { 135,0.33,1,XT_01,XT_06 };  XT_path[1][8] = { 20,0.51,0,XT_01,XT_08 }; XT_path[1][10] = { 45,0.88,1,XT_01,XT_10 };  XT_path[1][20] = { 5,0.66,0,XT_01,XT_20 }; XT_path[1][21] = { 25,0.45,0,XT_01,XT_21 };  XT_path[1][33] = { 175,0.76,1,XT_01,XT_33 }; XT_path[1][36] = { 85,0.88,1,XT_01,XT_36 }; XT_path[1][37] = { 80,0.58,0,XT_01,XT_37 }; XT_path[1][38] = { 122,0.76,1,XT_01,XT_38 }; XT_path[1][39] = { 157,0.77,0,XT_01,XT_39 }; 
XT_path[2][3] = { 32,0.45,0,XT_02,XT_03 }; XT_path[2][4] = { 200,0.88,1,XT_02,XT_04 }; XT_path[2][6] = { 15,0.58,0,XT_02,XT_06 }; XT_path[2][8] = { 27,0.91,0,XT_02,XT_08 };   XT_path[2][21] = { 238,0.88,1,XT_02,XT_21 };  XT_path[2][27] = { 110,0.88,1,XT_02,XT_27 }; XT_path[2][30] = { 80,0.88,1,XT_02,XT_30 };  XT_path[2][32] = { 175,0.26,1,XT_02,XT_32 };  XT_path[2][37] = { 100,0.88,1,XT_02,XT_37 }; 
XT_path[3][4] = { 200,0.88,1,XT_03,XT_04 }; XT_path[3][6] = { 210,0.26,1,XT_03,XT_06 }; XT_path[3][8] = { 160,0.65,1,XT_03,XT_08 };  XT_path[3][21] = { 238,0.88,1,XT_03,XT_21 };  XT_path[3][27] = { 110,0.88,1,XT_03,XT_27 }; XT_path[3][30] = { 20,0.26,1,XT_03,XT_30 }; XT_path[3][37] = { 100,0.88,1,XT_03,XT_37 }; XT_path[3][42] = { 95,0.26,1,XT_03,XT_42 }; XT_path[3][43] = { 270,0.90,1,XT_03,XT_43 }; 
XT_path[4][8] = { 160,0.76,1,XT_04,XT_08 }; XT_path[4][9] = { 40,0.11,0,XT_04,XT_09 }; XT_path[4][10] = { 40,0.88,1,XT_04,XT_10 };  XT_path[4][21] = { 33,0.88,1,XT_04,XT_21 }; 
XT_path[5][14] = { 60,0.22,0,XT_05,XT_14 }; XT_path[5][17] = { 40,0.58,0,XT_05,XT_17 }; XT_path[5][25] = { 90,0.88,1,XT_05,XT_25 }; XT_path[5][31] = { 20,0.29,0,XT_05,XT_31 }; XT_path[5][35] = { 80,0.41,0,XT_05,XT_35 }; XT_path[5][44] = { 35,0.88,1,XT_05,XT_44 };
XT_path[6][8] = { 70,0.65,1,XT_06,XT_08 }; XT_path[6][30] = { 220,0.26,1,XT_06,XT_30 }; XT_path[6][32] = { 110,0.59,1,XT_06,XT_32 }; XT_path[6][33] = { 210,0.59,1,XT_06,XT_33 }; XT_path[6][37] = { 75,0.65,1,XT_06,XT_37 }; XT_path[6][38] = { 50,0.33,0,XT_06,XT_38 };
XT_path[7][14] = { 90,0.47,0,XT_07,XT_14 }; XT_path[7][22] = { 85,0.07,0,XT_07,XT_22 }; XT_path[7][23] = { 30,0.66,0,XT_07,XT_23 }; XT_path[7][24] = { 45,0.47,1,XT_07,XT_24 }; XT_path[7][26] = { 120,0.96,1,XT_07,XT_26 }; XT_path[7][31] = { 160,0.96,1,XT_07,XT_31 }; XT_path[7][34] = { 200,0.47,1,XT_07,XT_34 }; XT_path[7][35] = { 95,0.96,1,XT_07,XT_35 }; XT_path[7][39] = { 210,0.47,1,XT_07,XT_39 }; XT_path[7][41] = { 160,0.24,1,XT_07,XT_41 };
XT_path[8][32] = { 100,0.65,1,XT_08,XT_32 }; XT_path[8][33] = { 100,0.65,1,XT_08,XT_33 }; XT_path[8][34] = { 150,0.47,1,XT_08,XT_34 }; XT_path[8][37] = { 25,0.36,0,XT_08,XT_37 }; XT_path[8][38] = { 20,0.43,0,XT_08,XT_38 }; XT_path[8][39] = { 80,0.47,1,XT_08,XT_39 }; XT_path[8][42] = { 290,0.65,1,XT_08,XT_42 };
XT_path[9][10] = { 10,0.36,0,XT_09,XT_10 }; XT_path[9][11] = { 70,0.11,0,XT_09,XT_11 }; XT_path[9][12] = { 70,0.36,0,XT_09,XT_12 }; XT_path[9][13] = { 140,0.11,0,XT_09,XT_13 }; XT_path[9][15] = { 140,0.36,0,XT_09,XT_15 }; XT_path[9][21] = { 160,0.51,1,XT_09,XT_21 }; XT_path[9][36] = { 160,0.51,1,XT_09,XT_36 }; XT_path[9][39] = { 200,0.51,1,XT_09,XT_39 }; XT_path[9][42] = { 200,0.11,1,XT_09,XT_42 };
XT_path[10][11] = { 70,0.36,0,XT_10,XT_11 }; XT_path[10][12] = { 70,0.36,0,XT_10,XT_12 }; XT_path[10][13] = { 140,0.36,0,XT_10,XT_13 }; XT_path[10][15] = { 140,0.36,0,XT_10,XT_15 }; XT_path[10][20] = { 170,0.51,1,XT_10,XT_20 }; XT_path[10][21] = { 55,0.66,0,XT_10,XT_21 }; XT_path[10][36] = { 45,0.24,0,XT_10,XT_36 }; XT_path[10][37] = { 200,0.88,1,XT_10,XT_37 }; XT_path[10][39] = { 170,0.51,1,XT_10,XT_39 };
XT_path[11][12] = { 10,0.36,0,XT_11,XT_12}; XT_path[11][13] = { 70,0.11,0,XT_11,XT_13 }; XT_path[11][15] = { 70,0.36,0,XT_11,XT_15 }; 
XT_path[12][13] = { 70,0.36,0,XT_12,XT_13 }; XT_path[12][15] = { 70,0.36,0,XT_12,XT_15 }; XT_path[12][21] = { 100,0.88,1,XT_12,XT_21 }; XT_path[12][24] = { 130,0.26,1,XT_12,XT_24 }; XT_path[12][26] = { 125,0.24,0,XT_12,XT_26 }; XT_path[12][31] = { 155,0.88,1,XT_12,XT_31 }; XT_path[12][36] = { 45,0.32,0,XT_12,XT_36 }; XT_path[12][39] = { 95,0.32,0,XT_12,XT_39 }; 
XT_path[13][15] = { 10,0.36,0,XT_13,XT_15 }; XT_path[13][19] = { 25,0.15,0,XT_13,XT_19 }; XT_path[13][25] = { 28,0.15,0,XT_13,XT_25 };
XT_path[14][23] = { 100,0.47,1,XT_14,XT_23 }; XT_path[14][24] = { 95,0.47,1,XT_14,XT_24 }; XT_path[14][31] = { 40,0.24,0,XT_14,XT_31 }; XT_path[14][35] = { 30,0.33,1,XT_14,XT_35 }; XT_path[14][41] = { 180,0.24,1,XT_14,XT_41 }; XT_path[14][44] = { 80,0.14,0,XT_14,XT_44 };
XT_path[15][17] = { 100,0.88,1,XT_15,XT_17 }; XT_path[15][19] = { 50,0.77,0,XT_15,XT_19 }; XT_path[15][24] = { 120,0.96,1,XT_15,XT_24 }; XT_path[15][25] = { 25,0.77,0,XT_15,XT_25 }; XT_path[15][26] = { 90,0.13,0,XT_15,XT_26 }; XT_path[15][31] = { 60,0.88,1,XT_15,XT_31 }; XT_path[15][35] = { 140,0.96,1,XT_15,XT_35 }; XT_path[15][36] = { 95,0.88,1,XT_15,XT_36 }; XT_path[15][44] = { 130,0.88,1,XT_15,XT_44 };
XT_path[16][17] = { 20,0.22,0,XT_16,XT_17 }; XT_path[16][19] = { 16,0.29,0,XT_16,XT_19 }; XT_path[16][25] = { 35,0.49,0,XT_16,XT_25 }; XT_path[16][44] = { 95,0.22,0,XT_16,XT_44 };
XT_path[17][19] = { 35,0.49,0,XT_17,XT_19 }; XT_path[17][25] = { 15,0.49,0,XT_17,XT_25 }; XT_path[17][31] = { 37,0.78,1,XT_17,XT_31 }; XT_path[17][44] = { 30,0.88,1,XT_17,XT_44 };
XT_path[18][20] = { 170,0.51,1,XT_18,XT_20 }; XT_path[18][22] = { 40,0.38,1,XT_18,XT_22 }; XT_path[18][23] = { 70,0.38,1,XT_18,XT_23 }; XT_path[18][33] = { 30,0.44,1,XT_18,XT_33 }; XT_path[18][34] = { 95,0.51,1,XT_18,XT_34 }; XT_path[18][39] = { 160,0.51,1,XT_18,XT_39 }; XT_path[18][40] = { 28,0.51,1,XT_18,XT_40 }; XT_path[18][41] = { 175,0.16,1,XT_18,XT_41 };
XT_path[19][25] = { 10,0.36,0,XT_19,XT_25 };
XT_path[20][21] = { 13,0.21,0,XT_20,XT_21 }; XT_path[20][34] = { 90,0.51,1,XT_20,XT_34 }; XT_path[20][36] = { 55,0.51,1,XT_20,XT_36 }; XT_path[20][39] = { 36,0.51,1,XT_20,XT_39 };
XT_path[21][36] = { 45,0.88,1,XT_21,XT_36 }; XT_path[21][39] = { 75,0.51,1,XT_21,XT_39 };
XT_path[22][23] = { 100,0.11,0,XT_22,XT_23 }; XT_path[22][34] = { 89,0.32,1,XT_22,XT_34 }; XT_path[22][41] = { 105,0.14,1,XT_22,XT_41 };
XT_path[23][24] = { 20,0.47,1,XT_23,XT_24 }; XT_path[23][26] = { 95,0.96,1,XT_23,XT_26 }; XT_path[23][34] = { 80,0.47,1,XT_23,XT_34 }; XT_path[23][35] = { 88,0.96,1,XT_23,XT_35 }; XT_path[23][36] = { 115,0.26,1,XT_23,XT_36 }; XT_path[23][39] = { 65,0.26,1,XT_23,XT_39 };
XT_path[24][26] = { 5,0.79,0,XT_24,XT_26 }; XT_path[24][34] = { 100,0.47,1,XT_24,XT_34 }; XT_path[24][35] = { 35,0.47,1,XT_24,XT_35 }; XT_path[24][36] = { 60,0.26,0,XT_24,XT_36 }; XT_path[24][39] = { 38,0.26,0,XT_24,XT_39 };
XT_path[25][26] = { 100,0.67,0,XT_25,XT_26 }; XT_path[25][31] = { 32,0.88,1,XT_25,XT_31 }; XT_path[25][35] = { 95,0.96,1,XT_25,XT_35 }; XT_path[25][36] = { 170,0.88,1,XT_25,XT_36 }; XT_path[25][44] = { 85,0.88,1,XT_25,XT_44 };
XT_path[26][31] = { 45,0.96,1,XT_26,XT_31 }; XT_path[26][35] = { 15,0.96,1,XT_26,XT_35 }; XT_path[26][36] = { 55,0.68,0,XT_26,XT_36 }; XT_path[26][39] = { 70,0.53,0,XT_26,XT_39 };
XT_path[27][28] = { 20,0.22,1,XT_27,XT_28 }; XT_path[27][29] = { 360,0.22,1,XT_27,XT_29 }; XT_path[27][30] = { 15,0.22,0,XT_27,XT_30 }; XT_path[27][43] = { 180,0.90,1,XT_27,XT_43 };
XT_path[28][29] = { 400,0.22,1,XT_28,XT_29 };XT_path[28][30] = { 65,0.22,1,XT_28,XT_30 }; 
XT_path[29][30] = { 305,0.06,1,XT_29,XT_30 };
XT_path[30][32] = { 290,0.26,1,XT_30,XT_32 }; XT_path[30][37] = { 165,0.88,1,XT_30,XT_37 }; XT_path[30][42] = { 260,0.65,1,XT_30,XT_42 }; XT_path[30][43] = { 200,0.90,1,XT_30,XT_43};
XT_path[31][35] = { 15,0.45,0,XT_31,XT_35 }; XT_path[31][36] = { 140,0.88,1,XT_31,XT_36 }; XT_path[31][44] = { 80,0.88,1,XT_31,XT_44 };
XT_path[32][33] = { 65,0.59,1,XT_32,XT_33 }; XT_path[32][37] = { 195,0.55,1,XT_32,XT_37 }; XT_path[32][38] = { 60,0.29,0,XT_32,XT_38 };
XT_path[33][34] = { 85,0.51,1,XT_33,XT_34 }; XT_path[33][38] = { 65,0.59,1,XT_33,XT_38 }; XT_path[33][39] = { 105,0.51,1,XT_33,XT_39 }; XT_path[33][40] = { 80,0.51,1,XT_33,XT_40 };
XT_path[34][35] = { 195,0.47,1,XT_34,XT_35 }; XT_path[34][36] = { 175,0.51,1,XT_34,XT_36 }; XT_path[34][38] = { 150,0.47,1,XT_34,XT_38 }; XT_path[34][39] = { 35,0.75,0,XT_34,XT_39 }; XT_path[34][40] = { 160,0.51,1,XT_34,XT_40 };
XT_path[35][39] = { 195,0.47,1,XT_35,XT_39 };
XT_path[36][37] = { 225,0.88,1,XT_36,XT_37 };XT_path[36][39] = { 45,0.24,0,XT_36,XT_39 }; XT_path[36][40] = { 375,0.51,1,XT_36,XT_40 }; XT_path[36][44] = { 245,0.88,1,XT_36,XT_44 };
XT_path[37][38] = { 75,0.65,1,XT_37,XT_38 }; XT_path[37][42] = { 205,0.12,0,XT_37,XT_42 };
XT_path[38][39] = { 190,0.33,1,XT_38,XT_39 }; XT_path[38][42] = { 400,0.65,1,XT_38,XT_42 };
XT_path[39][40] = { 220,0.51,1,XT_39,XT_40 };
XT_path[40][47] = { 60,0.68,1,XT_40,XT_47 };
XT_path[41][47] = { 310,0.68,1,XT_41,XT_47 };
XT_path[42][45] = { 290,0.79,1,XT_42,XT_45 };
XT_path[43][45] = { 315,0.61,1,XT_43,XT_45 }; XT_path[43][46] = { 15,0.61,1,XT_43,XT_46 };
for (int i = 1; i < 48; i++)
	for (int j = 1; j < i; j++)
		XT_path[i][j] = XT_path[j][i];
}


