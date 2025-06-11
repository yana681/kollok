using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kollok
{
    public class Booking
    {

        public Equipment Equipment { get; set; }
        public string ForemanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Booking(Equipment equipment, string foreman, DateTime start, DateTime end)
        {
            Equipment = equipment;
            ForemanName = foreman;
            StartDate = start;
            EndDate = end;
        }

        public override string ToString()
        {
            return $"{Equipment.Type} {Equipment.Brand}, {ForemanName}, с {StartDate.ToShortDateString()} по {EndDate.ToShortDateString()}";
        }
    }
}
