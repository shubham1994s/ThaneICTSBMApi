using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachhBhart.API.Bll.ViewModels
{
    public class SBAHousePrabhag
    {
        public string ReferanceId { get; set; }
        public int ReferancePrabhagId { get; set; }
        public int UserPrabhagId { get; set; }

        public string Status { get; set; }

        public string Msg { get; set; }
        public string MsgMarathi { get; set; }

    }
}
