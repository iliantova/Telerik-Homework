//Problem 7. GSM test

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class TestGSM
    {
        static void Main()
        {
            var mobileList = new List<GSM>();

            Battery nokiaBattery = new Battery("BJ51", 40, 12, BatteryType.LiIon);
            Battery sonyBattery = new Battery("BA900", 30, 15, BatteryType.NiCd);
            Battery samsungBattery = new Battery("EB-L1G6LLA", 30, 15, BatteryType.NiMH);

            Display smallDisplay = new Display(5, 16000000);
            Display mediumDisplay = new Display(7, 16000000);
            Display bigDisplay = new Display(11, 16000000);

            GSM nokiaLumia = new GSM("Lumia630", "Nokia", 300.00, "Microsoft", nokiaBattery, smallDisplay);
            mobileList.Add(nokiaLumia);
            GSM sonyExperia = new GSM("XperiaM", "Sony", 350.00, "Sony", sonyBattery, mediumDisplay);
            mobileList.Add(sonyExperia);
            GSM samsungNote = new GSM("GalaxyNote", "Samsung", 600.00, "Samsung", samsungBattery, bigDisplay);
            mobileList.Add(samsungNote);

            foreach (var phone in mobileList)
            {
                Console.WriteLine(phone.ToString());
            }
            Console.WriteLine(GSM.GetIPhone());
        }



    }
}
