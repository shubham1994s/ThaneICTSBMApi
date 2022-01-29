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

        public int ResidentialCollection { get; set; }
        public int ResidentialBCollection { get; set; }

        public int ResidentialSCollection { get; set; }
        public int CommertialCollection { get; set; }

        public int CADCollection { get; set; }
        public int HorticultureCollection { get; set; }


    }
}
