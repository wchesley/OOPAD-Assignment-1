using System;
namespace Assignment_1
{
    class tDate
    {
        public static string earliestDate;
        public static string latestDate;
        public static string userDate; 
        public tDate()
        {
            earliestDate = "1/1/1900";
            latestDate = "12/31/2100";
            userDate = "1/1/2000";
        }
        public tDate(int day, int month, int year)
        {
            userDate = dateAsIntToString(day, month, year);
        }
        public tDate(string date)
        {
            userDate = parseDate(date);
        }
        private string parseDate(string date)
        {
            string[] dateAsArray = splitDate(date);
            int counter = 0;
            foreach (string num in dateAsArray)
            {
                counter++;
                if (Int32.TryParse(num, out int parsedNum))
                {
                    if (counter == 1)
                    {
                        parsedNum = verifyMonthRange(parsedNum);
                        date += parsedNum.ToString();
                    }
                    else if (counter == 2)
                    {
                        parsedNum = verifyDayRange(parsedNum);
                        date += parsedNum.ToString();
                    }
                    else if (counter == 31)
                    {
                        parsedNum = verifyYearRange(parsedNum);
                        date += parsedNum.ToString(); 
                    }
                }
                else if (parsedNum == -1 )
                {
                    Console.WriteLine("Error parsing input");
                    return null; 
                }
            }
            return date;
        }
        private int verifyYearRange(int date)
        {
            if (date >= 1900 || date <= 2100)
            {
                return date;
            }
            else
            {
                Console.WriteLine("Error: Date out of range. Year should be between 1900 and 2100");
                return -1;
            }

        }
        private int verifyMonthRange(int date)
        {
            if (date <= 12 || date >= 1)
            {
                return date;
            }
            else
            {
                Console.WriteLine("Error: Month out of range");
                return -1;
            }
        }
        private int verifyDayRange(int date)
        {
            if (date <= 31 || date >= 1)
            {
                return date;
            }
            else
            {
                Console.WriteLine("Error: Date out of range");
                return -1;
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
        private string dateAsIntToString(int day, int month, int year)
        {
            day = verifyDayRange(day);
            month = verifyMonthRange(month);
            year = verifyYearRange(year);
            if (day == -1)
            {
                Console.WriteLine("Error: Date out of range");
                return null; 
            }
            else if (month == -1)
            {
                Console.WriteLine("Error: Date out of range");
                return null; 
            }
             else if (year == -1)
            {
                Console.WriteLine("Error: Date out of range");
                return null; 
            }
            return userDate = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
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
                    Console.WriteLine($"date: {buildEUDate(userDate)}"); 
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
                Console.WriteLine($"date: {buildEUDate(userDate)}");
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
            euDate[0] = euDate[1];
            euDate[1] = temp; 
            userDate = euDate[0] + "/" + euDate[1] + "/" + euDate[2]; 
            return userDate; 
        }
    }
}