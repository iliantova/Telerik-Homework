//Problem 12. Call history test

//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

using System;
using System.Collections.Generic;
using System.Globalization;


namespace CallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {

            Battery samsungBattery = new Battery("EB-L1G6LLA", 30, 15, BatteryType.NiMH);
            Display bigDisplay = new Display(11, 16000000);
            GSM samsungNote = new GSM("GalaxyNote", "Samsung", 600.00, "Samsung", samsungBattery, bigDisplay);


            decimal pricePerMin = 0.37M;

            Calls call = new Calls( DateTime.Today, DateTime.Now.TimeOfDay, "+359887841089", 120);
            samsungNote.AddCall(call);
            Calls call2 = new Calls(DateTime.Today, DateTime.Now.TimeOfDay, "+359887845655", 400);
            samsungNote.AddCall(call2);
            Calls call3 = new Calls(DateTime.Today, DateTime.Now.TimeOfDay, "+359888999954", 324);
            samsungNote.AddCall(call3);
            Calls call4 = new Calls(DateTime.Today, DateTime.Now.TimeOfDay, "+359854454322", 487);
            samsungNote.AddCall(call4);


            Console.WriteLine("SORTED CALL LIST");
            List<Calls> tempList = samsungNote.HISTORY;
            tempList.Sort();
            foreach (var calls in tempList)
            {
                
                Console.WriteLine(calls.ToString());
            }

            Console.WriteLine("\nPrice per minute is: {0}. Total cost: {1}\n", pricePerMin.ToString("C", CultureInfo.CurrentCulture), samsungNote.CalculateCalls(pricePerMin).ToString("C", CultureInfo.CurrentCulture));

            
            Console.WriteLine("DELETING THE LONGEST CALL");
            samsungNote.DeleteCall(tempList[tempList.Count - 1]);
           
            foreach (var calls in tempList)
            {
                Console.WriteLine(calls.ToString());
            }

            Console.WriteLine("\nPrice per minute is: {0}. Total cost: {1}\n", pricePerMin.ToString("C", CultureInfo.CurrentCulture), samsungNote.CalculateCalls(pricePerMin).ToString("C", CultureInfo.CurrentCulture));

            
            Console.WriteLine("CLEARING THE WHOLE CALL LIST");
            samsungNote.ClearCall();
            foreach (var calls in tempList)
            {
                Console.WriteLine(calls.ToString());
            }
            Console.WriteLine("\nPrice per minute is: {0}. Total cost: {1}\n", pricePerMin.ToString("C", CultureInfo.CurrentCulture), samsungNote.CalculateCalls(pricePerMin).ToString("C", CultureInfo.CurrentCulture));



        }
    }
}
