using System;
namespace Assignment_1
{
    class tDate
    {
        public static string earliestDate;
        public static string latestDate;
        public static string userDate = "1/1/2000"; 
        public tDate(string earlyDate, string lateDate)
        {
            earliestDate = earlyDate;
            latestDate = lateDate;
            userDate = "1/1/2000";
        }
        public tDate(int day, int month, int year, string earlyDate, string lateDate)
        {
            earliestDate = earlyDate;
            latestDate = lateDate;
            userDate = dateAsIntToString(month, day, year);
        }
        public tDate(string date, string earlyDate, string lateDate)
        {
            earliestDate = earlyDate; 
            latestDate = lateDate; 
            userDate = parseDate(date);
        }
        private string parseDate(string date)
        {
            string[] dateAsArray = splitDate(date);
            int[] datesAsInt = new int[dateAsArray.Length];
            for(int i = 0; i < dateAsArray.Length; i++)
            {
                if(int.TryParse(dateAsArray[i], out datesAsInt[i]))
                {

                }
            }
            date = dateAsIntToString(datesAsInt[0], datesAsInt[1], datesAsInt[2]);
            return date;
        }
        private int verifyYearRange(int date)
        {
            int[] lateDate = convertStaticDates(latestDate);
            int[] earlyDate = convertStaticDates(earliestDate);
            if (date >= earlyDate[2] && date <= lateDate[2])
            {
                return date;
            }
            else 
            {
                Console.WriteLine($"Error: Date out of range. Year should be between {earlyDate[2].ToString()} and {lateDate[2].ToString()}");
                return date;
            }
        }
        private int verifyMonthRange(int date)
        {
            if (date < 13 && date > 0)
            {
                return date;
            }
            else
            {
                Console.WriteLine("Error: Month out of range");
                return date;
            }
        }
        private int verifyDayRange(int date)
        {
            if (date <= 31 || date > 0)
            {
                return date;
            }
            else
            {
                Console.WriteLine("Error: Date out of range");
                return date;
            }
        }
        // takes given date and splits it into array
        // if date was given in DD-MMM-YYYY format
        // will parse month to it's numeric format then 
        // swap date and months placement. 
        private string[] splitDate(string rawDate)
        {
            string[] splitDate = rawDate.Split('/', '-');
            if (splitDate[1].Length == 3)
            {
                splitDate[1] = monthToNumber(splitDate[1]);
                string temp = splitDate[0];
                splitDate[0] = splitDate[1];
                splitDate[1] = temp;
            }
                return splitDate;
        }
        private string monthToNumber(string month)
        {
            month = month.ToUpper();
            switch (month)
            {
                case "JAN":
                    return 1.ToString();
                case "FEB":
                    return 2.ToString();
                case "MAR":
                    return 3.ToString();
                case "APR":
                    return 4.ToString();
                case "MAY":
                    return 5.ToString();
                case "JUN":
                    return 6.ToString();
                case "JUL":
                    return 7.ToString();
                case "AUG":
                    return 8.ToString();
                case "SEP":
                    return 9.ToString();
                case "OCT":
                    return 10.ToString();
                case "NOV":
                    return 11.ToString();
                case "DEC":
                    return 12.ToString();
                default:
                    return "Error parsing month";
            }
        }
        private string dateAsIntToString(int month, int day, int year)
        {
            day = verifyDayRange(day);
            month = verifyMonthRange(month);
            year = verifyYearRange(year);
            return userDate = month.ToString() + "/" +  day.ToString()+ "/" + year.ToString();
        }
        public void showDate(string EuOrNa)
        {
            switch(EuOrNa)
            {
                case "E":
                case "e":
                case "EU":
                case "Europe":
                case "Eur":
                    Console.WriteLine($"EU date: {buildEUDate(userDate)}"); 
                    break;
                case "N":
                case "NA":
                case "USA":
                case "US":
                case "America": 
                    Console.WriteLine($"date: {userDate}");
                    break;
            }
        }
        public void showDate(int EuOrNa)
        {
            if(EuOrNa == 0)
            {
                Console.WriteLine($"EU date: {buildEUDate(userDate)}");
            }
            else if ( EuOrNa == 1)
            {
                Console.WriteLine($"date: {userDate}");
            }
            else
            {
                Console.WriteLine("Invalid input, try again...");
            }
        }
        private string buildEUDate(string userDate)
        {
            string[] euDate = splitDate(userDate);
            string temp = euDate[1];
            euDate[1] = euDate[0];
            euDate[0] = temp; 
            userDate = euDate[0] + "/" + euDate[1] + "/" + euDate[2]; 
            return userDate; 
        }
        private int[] convertStaticDates(string earlyOrLateDate)
        {
            string[] dates = earlyOrLateDate.Split('/','-');
            int[] intDate = new int[dates.Length];
            for (int i = 0; i < dates.Length; i++)
            {
                if(int.TryParse(dates[i], out intDate[i]))
                {

                }
            }
            return intDate; 
        }
    }
}