using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class Odometer
    {
        //Instance Variables
        private int miles;
        private double fuelUsed;

        //Constructors
        public Odometer()
        {
            miles = 0;
            fuelUsed = 15;
        }
        public Odometer(int miles, double fuelUsed)
        {
            this.miles = miles;
            this.fuelUsed = fuelUsed;
        }
        //Methods
        public void setMiles(int m)
        {
            miles = m;
        }
        public int getMiles()
        {
            return miles;
        }
        public void setfuelUsed(double f)
        {
            fuelUsed = f;
        }
        public double getFuelUsed()
        {
            return fuelUsed;
        }
        public void reset()
        {
            miles = 0;
            fuelUsed = 0;
        }
        public void Add (int m, double f)
        {
            miles += m;
            fuelUsed += f;
        }
        public double mpg()
        {
            return ( miles / fuelUsed );
        }
        public string toString()
        {
            return " " + miles + " Miles driven " + fuelUsed + " fuel used";
        }
        public bool equals(Odometer other)
        {
           // return (this.miles == other.miles) && (this.fuelUsed == other.fuelUsed);
            return (this.getMiles() == other.getMiles()) && (this.getFuelUsed() == other.getFuelUsed());
        }
    }
}
