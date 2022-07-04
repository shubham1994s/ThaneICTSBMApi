using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels
{
   public class VehicleList
    {
        public string VehicleNo { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public int VehicleId { get; set; }
        public int TypeId { get; set; }
        public int AreaId { get; set; }
    }
}
