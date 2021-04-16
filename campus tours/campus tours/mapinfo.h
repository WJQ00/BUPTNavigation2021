#pragma once
#ifndef _MAPINFO_H_
#define _MAPINFO_H_

#include <conio.h>
#include <stdio.h>
#include <stdlib.h>

enum building_type {Academic, Office, Dorm, Dining, Store, Coffee, Printing, Barber, Medical, StuCenter,Library,Bath, Square,Auditorium,Playground, Gate, Bus};

typedef struct building
{
	int index;
	building_type type;
	char name[30];
}building;

typedef struct path 
{
	int length;
	double crowded;
	bool bicycle;
	building departure;
	building destination;
}path;

typedef struct schoolbus
{
	int time_dep;
	int length;
	int time;
}schoolbus;

typedef struct bus
{
	int time_dep;
	int length;
	int time;
}bus;

typedef struct cur_pos
{
	int x;
	int y;
}cur_pos;
void XT_pathgeneration();

#endif // !_MAPINFO_H_
