﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels
{
  public  class SBUserView
    {
        public string userId { get; set; }
        public string name { get; set; }
        public string nameMar { get; set; }
        public string mobileNumber { get; set; }
        public string address { get; set; }
        public string profileImage { get; set; }
        public string type { get; set; }
        public int typeId { get; set; }
        public string bloodGroup { get; set; }

        public string userDesignation { get; set; }

        public string PrabhagName { get; set; }
    }
}
