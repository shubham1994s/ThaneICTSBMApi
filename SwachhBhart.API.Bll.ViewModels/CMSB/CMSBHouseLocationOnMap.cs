﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels.CMSB
{
   public class CMSBHouseLocationOnMap
    {
        public int houseId { get; set; }
        public string ReferanceId { get; set; }
        public string houseOwnerName { get; set; }
        public string houseOwnerMobile { get; set; }
        public string houseAddress { get; set; }
        public string houseLat { get; set; }
        public string houseLong { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string lat { get; set; }
        public string log { get; set; }
        public string address { get; set; }
        public string vehcileNumber { get; set; }
        public string userMobile { get; set; }

        public string gcDate { get; set; }
        public string gcTime { get; set; }
        public Nullable<int> garbageType { get; set; }

    }
}
