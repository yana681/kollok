using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kollok
{
    class Equipment
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public int AvailableCount { get; set; }

        public Equipment(string type, string brand, int count)
        {
            Type = type;
            Brand = brand;
            AvailableCount = count;
        }

        public override string ToString()
        {
            return $"{Type} {Brand} (Доступно: {AvailableCount})";
        }
    }
}
