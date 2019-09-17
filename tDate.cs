using System; 
namespace Assignment_1
{
    class tDate
    {
        public static string earliestDate;
        public static string latestDate;
        public tDate()
        {
            earliestDate = "1/1/1900";
            latestDate = "12/31/2100";
        }
        public tDate(int day, int month, int year)
        {

        }
        public tDate(string date)
        {
            //mm-dd-yyy
        }
        private string parseDate(string date)
        {
            string[] splitDate = date.Split('/','-');
            int counter = 0;
            foreach(string num in splitDate)
            {
                counter++;
                if(Int32.TryParse(num, out int parsedNum))
                {
                    parsedNum = verifyRange(parsedNum);
                    if (parsedNum == -1)
                    {
                        return date = "Error received, try again in the format MM-DD-YYY";
                    }
                    else if(counter == 1)
                    {
                        parsedNum = verifyMonthRange(parsedNum);
                        if (parsedNum == -1)
                        {
                            return date = "Error received, try again in the formate MM-DD-YYY";
                        }
                        else
                        {
                            date += parsedNum.ToString() + "/";
                        }
                    }
                    else if(counter == 2)
                    {
                        date += parsedNum.ToString() + "/";
                    }
                    else
                    {
                        date += parsedNum.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("Error parsing input");
                }
            }
            return date; 
        }
        private int verifyRange(int date)
        {
            if(date >= 1900 || date <= 2100)
            {
                return date;
            }
            else if(date <= 31 && date > 0)
            {
                return date;
            }
            else
            {
                Console.WriteLine("error date out of range");
                return -1; 
            }
            
        }
        private int verifyMonthRange(int date)
        {
            if (date <= 12 || date >=1 )
            {
                return date;
            }
            else
            {
                Console.WriteLine("ERROR: Month out of range");
                return -1;
            }
        }
    }
}