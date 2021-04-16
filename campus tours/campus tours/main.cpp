#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include"mapinfo.h"

/*
校车时刻表，每天一样
7:00
9:00
12:00
14:00
17:00
21:00
时长均为60分钟，距离均为23000米

公交时刻表，每天一样
7:00
9:00
11:00
13:00
15:00
17:00
19:00
21:00
时长与距离有所波动

*/
schoolbus schoolbus01 = { 7,23000,60 }; schoolbus schoolbus02 = { 9,23000,60 };
schoolbus schoolbus03 = { 12,23000,60 }; schoolbus schoolbus04 = { 14,23000,60 };
schoolbus schoolbus05 = { 17,23000,60 }; schoolbus schoolbus06 = { 21,23000,60 };

bus bus01 = { 7,25000,75 }; bus bus02 = { 9,24000,68 };
bus bus03 = { 11,25000,75 }; bus bus04 = { 13,24500,72 };
bus bus05 = { 15,23500,64 }; bus bus06 = { 17,25000,75 };
bus bus07 = { 19,25000,75 }; bus bus08 = { 21,24000,68 };


int year = 2021;
int month = 3;
int date = 24;
int Hour = 14;
int Minute = 25;

void initiate_time() //初始化计时器
{
	clock_t start = clock();
	printf("%d/%d/%d %d:%d", year, month, date, Hour, Minute);
	int key = 0;
	while (true)
	{
		key = kbhit();
		if (key)
		{
			printf("\n检测到输入，计时暂停。\n");
			printf("如要开始导航请按1，否则请按0。");
			int a;	scanf_s("%d", &a);
			if (a)
			{
				printf("是否需要跳转到指定日期？\n");
				printf("需要请按1，否则请按0。\n");
				int b; scanf_s("%d", &b);
				if (b)
				{
					printf("请按如下格式输入：yyyy mm dd time\n");
					scanf_s("%d %d %d %d", &year, &month, &date, &Hour);
				}
				return;
			}
			key = 0;
			start = clock();
		}
		else
		{
			clock_t end = (clock() - start) / 1000;
			if (end / 10 == 1)
			{
				system("cls");
				Minute++;
				if (Minute <= 59)
					printf("%d/%d/%d %d:%d", year, month, date, Hour, Minute);
				else
				{
					Minute = 0;
					Hour++;
					if (Hour >= 24)
					{
						Hour = 0;
						date++;
					}
					printf("%d/%d/%d %d:%d", year, month, date, Hour, Minute);
				}
				start = clock();
			}
		}
	}
}
int main()
{
	XT_pathgeneration();
	initiate_time();

	system("pause");
	return 0;
}

