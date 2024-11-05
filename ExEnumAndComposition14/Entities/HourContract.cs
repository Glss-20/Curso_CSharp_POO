using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumAndComposition14.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValeuPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValeuPerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {

            return Hours * ValeuPerHour; 

        }

    }
}
