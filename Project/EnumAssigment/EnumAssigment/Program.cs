using System;

namespace EnumAssigment
{
    class Program
    {
		enum DayofWeek { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
		static void Main(string[] args)
        {

			try
			{
				Console.WriteLine("Enter current day of the week:");

				string Day = Console.ReadLine();
				object f = Enum.Parse(typeof(DayofWeek),Day);
			}
			catch(Exception ex)
			{
				Console.WriteLine("Please enter an actual day of the week");
			}
			Console.WriteLine("Enum:-");
			foreach (DayofWeek day in Enum.GetValues(typeof(DayofWeek)))
			{
				Console.WriteLine(day);
			}


		}
	}
    }

