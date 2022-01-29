using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels
{
   public class SBWorkDetails
    {
        public string date { get; set; }
        public int houseCollection { get; set; }
        public int pointCollection { get; set; }
        public int DumpYardCollection { get; set; }

        public int LiquidCollection { get; set; }
        public int StreetCollection { get; set; }

        public int ResidendialCollection { get; set; }
        public int ResidendialBCollection { get; set; }

        public int ResidendialSCollection { get; set; }
        public int CommertialCollection { get; set; }


    }
}
