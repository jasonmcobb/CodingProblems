namespace CodingProblems.HackerRank;

public class DayOfTheProgrammer
{
    public string GetDateFromYear(int year)
    {
        // Leap years: 
        // divisible by either 400 OR 4 and !100
        // 1918 has a weird thing going on If year is 1918 subtract 13 days
        // Lets start with 1918:

        if (year == 1918) return "26.09.1918";
        
        if(
            (
                (year <= 1917) && 
                (year % 4 == 0)
            ) || 
            (
                (year % 400 == 0) ||
                (
                    (year % 4 == 0) && 
                    (year % 100 != 0)
                )
            )
        )
        {
            return $"12.09.{year}";
        }
        else
        {
            return $"13.09.{year}";
        }
    }
}