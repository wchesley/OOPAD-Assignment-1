# Description:

We want to design a Date class to representa date using three integer numbers for day, month, and year. Our class will be named `tDate`. The class has two static attributes(earliestDate, latestDate) to represent the earliest and latest dates it can hold. These static attributes are strings contain dates formatted as “mm/dd/yyyy” (using USdate formatting). The class can be instantiated in two ways, the firstisusing three integer arguments separated by comma as (mm, dd, yyyy), and the secondis using string contains a date formatted as“mm/dd/yyyy”. Each object of this class type can show its date formatted as either (US) mm/dd/yyyy or (Europe) dd/mm/yyyy according to an argument passed to its showDate() method.

## Tasks[1-4 for both CIDM4360and CIDM5360]:

>Write C# program that implements the date class described above according to the following:   
1. Declare the class named tDate with the appropriate private static and non-static attributes, public constructors, and public methods. Make this class in a separate `.cs` file
2. The class constructors must parse the passed arguments correctly and do the following verification(s) before initializing the attributes(day,month,year) of the created object:
    - Verify that the arguments it received form a valid date(do just simple verification, like, `0 < days<=31, 0 < months <= 12, year > 0`). i.e. using (15,18,2010) should not be accepted as valid date because the month >12. Similarly, “15/18/2010”is not valid too. If the verification failed, the constructor should initializethe attributes(day,month,year) of the new object usingthe “earliestDate” datevalues. *Hint: The “earliestDate”attribute is a string, so you need to parse it to extract its day, month and year components using string split()method.*
3. The show `Datemethod` should receive an argument to specify which format the method  should use to display the date (US or Europe), then prints the date according to the given format. The argument could be char(‘U’ for US, ‘E’ for Europe) or int (0 for US, 1 for Europe) or a string.
4. The main program method main() should do the following:  
    - Set the static attributes (earliestDate, latestDate) of the tDateclass as “1/1/1900”, and “12/31/2100” respectively. 
    - instantiate the following objectsa s follows:
        - d1 using three integer values (12,15,1990)
        - d2 using the string (“12/15/1990”)
        - d3 using the string (“15/12/1990”), which is invalid date
        - d4 using the string(“11/11/1811”), which is out of range date (CIDM5360programmerscode shouldn’t accept this as valid date)
    - Display the dates of the objectsaboveusing the showDatemethod with both date formats (US, and Europe). That is, call the method showDatetwice on each object.
>[Tasks 5 and 6 are for CIDM5360 Only]  
5. Write additional staticmember method `verifyRange()` in the class `tDate` to perform the following verification, and then call it from your 2nd constructor before you initialize the attributes of the new object: 
    - Verify that the received date is between the earlies and latest dates specified by the classs tatic attributes “earliestDate” and “latestDate”Hint: One way to testif date1 > date2 (i.e. if date1 comes after date2) is to compare if year1 >year2 then date1 comes after date2, and you don’t need to check months or days. But if year1==year2 then heck the months, and if they were equal then check the days too. You can find otherways, but don’t use any date library
6. Make the 2nd constructor, which has a string parameter, process string dates in the format “dd-MMM-yyyy”(like. “13-Sep-2019”)in addition to the “mm/dd/yyyy”format. *Hint:Try to split the string using ‘-‘first, then if you succeed, extract the month name, and use switch statement with a case for each month name. It would be more organized if you made the switchinside anauxiliary(utility) methodthat you can call and pass the month nameas argument, and it returns the monthnumber(indexfrom 1to 12)corresponding to that month. For example, write a method named getMonthIndexthat you can call as  int mm=getMonthIndex(mmm);whichshould assign 9 to mmif mmmequals “Sep”.Also you canuse arraysto store month names, and check their index in the array.*