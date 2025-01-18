using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace Clock
{
	public partial class Alarm:IComparable<Alarm>
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week WeekDays { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }
		public Alarm()
		{
			WeekDays = new Week();
		}
		public Alarm(DateTime date, TimeSpan time, Week week, string filename, string message)
		{
			this.Date = date;
			this.Time = time;
			this.WeekDays = week;
			this.Filename = filename;
			this.Message = message;
			Console.WriteLine($"Constructor:{this.GetHashCode()}");
		}
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.WeekDays = other.WeekDays;
			this.Filename = other.Filename;
			this.Message = other.Message;
			Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");
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
public string ToFileString()
		{
			string info = "";
			if (Date != DateTime.MinValue) info += $"{Date.Ticks}";
			info += $",{DateTime.Today.Add(Time).Ticks},";
			//info += Time;//.ToString(@"hh\:mm\:ss");

			info += $"{WeekDays.ToFileString()},";
			info += $"{Filename},";
			info += $"{Message},";
			return info;
		}


		/*public static bool operator ==(Alarm left, Alarm right)
		{
			return
				left.Date == right.Date &&
				left.Time == right.Time &&
				left.WeekDays == right.WeekDays &&
				left.Filename == right.Filename &&
				left.Message == right.Message;
		}
			public static bool operator !=(Alarm left, Alarm right)
		{
			return !(left == right);
		}*/

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

		public int CompareTo(Alarm other)
		{
			//Console.WriteLine("Alarm Comparison");
			return this.Time.CompareTo(other.Time);
		}
	}
}
