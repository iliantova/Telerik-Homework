
//Problem 3. Enumeration

//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.



namespace Enumeration
{

    

    class Display
    {
        double? size = null;
        int? numberOfColors = null;

        public Display()
        {

        }


       public Display(double size)
       {
           this.size = size;
       }

       public Display(double size, int colors)
       {
           this.size = size;
           this.numberOfColors = colors;
       }
        

    }
}
