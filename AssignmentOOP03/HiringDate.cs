using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AssignmentOOP03
{
    public class HiringDate
    {
		private int _day;
		private DateTime dateTime=new DateTime();
		

		public HiringDate(int day,int month,int year)
		{

			if (isValidDate(day, month, year))
			{
				_day = day;
				_month = month;
				_year = year;

			}
			else
				Console.WriteLine("Invalid Date");
        }

		 bool isValidDate(int day, int month, int year)
		{
            DateTime enteredDate;
			bool isValid=DateTime.TryParseExact($"{day:D2}/{month:D2}/{year}","dd/MM/yyyy", CultureInfo.InvariantCulture ,
				DateTimeStyles.None,
				 out enteredDate);

			dateTime=DateTime.Now.Date;
			
            if (isValid)
                if (dateTime > enteredDate)
				{
					return true;
				}

			return false;

        }
        public int Day
		{
			get {
				return _day; 
			}
			set {
           

                if (value > 0&& value <= DateTime.DaysInMonth(dateTime.Year,dateTime.Month))
					_day = value;


            }
        }

		private int _month;

		public int Month
		{
			get 
			{
				return _month;
			}
			set 
			{ 
				if(value > 0&& value <= 12)

				_month = value;
				
            }
		}

		private int _year;

		public int Year
		{
			get 
			{
				return _year; 
			}
			set 
			{ 
				if(dateTime.Year <=value)
				_year = value;
				
            }
		}

		public string getDate()
		{
			if (_day == 0) {
				
				return "null";
					}
			else
				return $"{_day}/{_month}/{_year}"; ;

        }


	}
}
