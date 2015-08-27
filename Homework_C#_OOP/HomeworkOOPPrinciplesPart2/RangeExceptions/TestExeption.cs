
namespace RangeExceptions
{
    using System;
    class TestExeption
    {
        static readonly int startInt = 1;
        static readonly int endInt = 100;
        static readonly DateTime startDate = new DateTime(1980, 1, 1);
        static readonly DateTime endDate = new DateTime(2013, 12, 31);
        static void Main()
        {
            
            int wrongNumber = 1337;
            DateTime wrongDate = DateTime.Now;

            try
            {

                if (wrongNumber < startInt || wrongNumber > endInt)
                {
                    throw new InvalidRangeException<int>("Invalid range!", 1, 100);
                }

                if (wrongDate < startDate || wrongDate > endDate)
                {
                    throw new InvalidRangeException<DateTime>("Invalid range!", startDate, endDate);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
