﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels
{
    public class AHouseGarbageCollectionVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; }
        public string Employee { get; set; }
        public string VehicleNumber { get; set; }
        public string Note { get; set; }
        public string attandDate { get; set; }
        public string gpBeforImage { get; set; }
        public string gpAfterImage { get; set; }
        public Nullable<DateTime> gcDate { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> houseId { get; set; }
        public Nullable<int> gpIdfk { get; set; }
        public Nullable<int> gpIdpk { get; set; }
        public Nullable<int> gcType { get; set; }
        public string ReferanceId { get; set; }
        public string type1 { get; set; }
        public string batterystatus { get; set; }
    }
}
