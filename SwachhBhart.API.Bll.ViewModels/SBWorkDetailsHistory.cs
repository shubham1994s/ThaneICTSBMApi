﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels
{
   public class SBWorkDetailsHistory
    {
        public string time { get; set; }
        public string Refid{ get; set; }
        public string name { get; set; }
        public string vehicleNumber { get; set; }
        public string areaName { get; set; }
        public int type { get; set; }
    }
}