using System;
using System.Collections;
using System.Collections.Generic;

namespace StatsTypes
{
	public enum Building_type
    {
		Academic, Office, Dorm, Dining, Store, 
		Coffee, Printing, Barber, Medical, StuCenter, 
		Library, Bath, Square, Auditorium, Playground, 
		Gate, Bus
	}
	[System.Serializable]
	public struct Building
	{
		//algorithm param
		public int index;
		//ui param
		public Building_type type;
		public string name;
	}

	public struct path
	{
		public int length;
		public double crowded;
		public bool bicycle;
		public Building departure;
		public Building destination;

		public void Set(int _length, double _crowded, bool _bicycle)
		{
			length = _length;
			crowded = _crowded;
			bicycle = _bicycle;
		}
		public path(int _length, double _crowded, bool _bicycle, Building _departure, Building _destination)
		{
			length = _length;
			crowded = _crowded;
			bicycle = _bicycle;
			departure = _departure;
			destination = _destination;
		}
	}
	//draw part
	public struct route
	{
		public int[] routeTurningPoints;
		public int startNavigationPointIndex;
		public int endNavigationPointIndex;
		public void Set(int[] pts)
        {
			routeTurningPoints = pts;
        }
	}

	public class schoolbus
	{
		int time_dep;
		int length;
		int time;

		int interval;//minitues
		DateTime startTime;
		DateTime endTime;
		public schoolbus(int _interval,DateTime _startTime,DateTime _endTime)
        {
			interval = _interval;
			startTime = _startTime;
			endTime = _endTime;
        }
	}
}
