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
    
    public partial class CommercialMaster
    {
        public int commercialId { get; set; }
        public string commercialNumber { get; set; }
        public string commercialOwner { get; set; }
        public string commercialOwnerMar { get; set; }
        public string commercialOwnerMobile { get; set; }
        public string commercialAddress { get; set; }
        public string commercialLat { get; set; }
        public string commercialLong { get; set; }
        public string commercialQRCode { get; set; }
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
        public string CType { get; set; }
        public string QRCodeImage { get; set; }
    }
}
