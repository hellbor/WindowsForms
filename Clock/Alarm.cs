﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public partial class Alarm:IComparable
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week WeekDays { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }
		public Alarm()
		{

		}
		public override string ToString()
		{
			string info = "";
			if (Date != DateTime.MinValue) info += $"{Date}\t";
			info += DateTime.Today.Add(Time).ToString("HH:mm:ss");
			//info += Time;//.ToString(@"hh\:mm\:ss");

			info += "\t\t";
			info += $"{WeekDays}\t";
			info += $"{Filename}\t";
			info += $"{Message}\t";
			return info;
		}
		/*public static bool operator > (Alarm left, Alarm right)
		{
			if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
			{
				return
					(left.Date == DateTime.MinValue ? DateTime.Today : left.Date) >=
					(right.Date == DateTime.MinValue ? DateTime.Today : right.Date) &&
					left.Time > right.Time;
			}
			else return left.Time > right.Time;
		}
		public static bool operator < (Alarm left, Alarm right)
		{
			if (left.Date != DateTime.MinValue || right.Date != DateTime.MinValue)
			{
				return 
					(left.Date == DateTime.MinValue ? DateTime.Today : left.Date) <=
					(right.Date == DateTime.MinValue ? DateTime.Today : right.Date) &&
					left.Time < right.Time;
			}
			else return left.Time < right.Time;
		}*/

		public int CompareTo(object other)
		{
			Console.WriteLine("Alarm Comparison");
			return this.Time.CompareTo((other as Alarm).Time);
		}
	}
}
