
namespace Shapes
{
    using System;
   public abstract class Shape
    {
      private double width = default(double);
      private double height = default(double);

      public abstract double CalculateSurface();

      public Shape(double width, double height)
      {
          this.Wight = width;
          this.Height = height;
      }

      public double Wight
      { 
      get
      {
          return this.width;
      }
      set
      {
          if (value <= 0)
          {
              throw new ArgumentOutOfRangeException("The wight connot be null or less than 0!");
          }
          else
          {
              this.width = value;
          }    
      }   
      }

      public double Height
      {
          get
          {
              return this.height;
          }
          set
          {
              if (value <= 0)
              {
                  throw new ArgumentOutOfRangeException("The height connot be null or less than 0!");
              }
              else
              {
                  this.height = value;
              }
          }
      }   

    }
}
