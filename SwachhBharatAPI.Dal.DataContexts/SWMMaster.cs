//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwachhBharatAPI.Dal.DataContexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class SWMMaster
    {
        public int swmId { get; set; }
        public string swmNumber { get; set; }
        public string swmName { get; set; }
        public string swmManager { get; set; }
        public string swmOwnerMar { get; set; }
        public string swmOwnerMobile { get; set; }
        public string swmAddress { get; set; }
        public string swmLat { get; set; }
        public string swmLong { get; set; }
        public string swmQRCode { get; set; }
        public Nullable<int> ZoneId { get; set; }
        public Nullable<int> AreaId { get; set; }
        public Nullable<int> WardNo { get; set; }
        public string ReferanceId { get; set; }
        public Nullable<System.DateTime> modified { get; set; }
        public Nullable<int> userId { get; set; }
        public string FCMID { get; set; }
        public Nullable<System.DateTime> lastModifiedEntry { get; set; }
        public string RFIDTagId { get; set; }
        public string WasteType { get; set; }
        public string swmType { get; set; }
    }
}
