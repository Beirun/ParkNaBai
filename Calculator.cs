using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkInParkOut
{
    internal class Calculator
    {

        public Calculator() { }

        public int parkingFee(int timeHour, String vehicleType)
        {
            int result = 0;
            //if (timeHour != 0) timeHour--;
            switch (vehicleType)
            {
                case "SUV":
                case "Van":
                    result = (timeHour * 20) + 40;
                    break;
                case "MotorBike":
                    result = (timeHour * 5) + 20;
                    break;
                case "Sedan":
                    result = (timeHour * 15) + 30;
                    break;
            }
            return result;
        }
        public int calculateHours(DateTime timeIn, DateTime timeOut)
        {
            TimeSpan timeSpan = getTimeSpan(timeIn, timeOut);
            int hours = (timeSpan.Days * 24) + timeSpan.Hours;
            return hours;
        }
        public TimeSpan getTimeSpan(DateTime timeIn, DateTime timeOut)
        {
            return timeOut - timeIn;
        }
        public double calculateMinutePoint(int minutes)
        {
            return (double)minutes / 60;
        }
    }
}
