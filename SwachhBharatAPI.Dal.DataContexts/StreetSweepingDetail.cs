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
    
    public partial class StreetSweepingDetail
    {
        public int SSId { get; set; }
        public string SSName { get; set; }
        public string SSNameMar { get; set; }
        public string SSLat { get; set; }
        public string SSLong { get; set; }
        public string SSQRCode { get; set; }
        public Nullable<int> zoneId { get; set; }
        public Nullable<int> wardId { get; set; }
        public Nullable<int> areaId { get; set; }
        public string ReferanceId { get; set; }
        public string SSAddress { get; set; }
        public Nullable<System.DateTime> lastModifiedDate { get; set; }
        public Nullable<int> userId { get; set; }
        public string QRCodeImage { get; set; }
        public Nullable<bool> QRStatus { get; set; }
        public Nullable<System.DateTime> QRStatusDate { get; set; }
        public byte[] BinaryQrCodeImage { get; set; }
        public Nullable<int> PrabhagId { get; set; }
        public Nullable<int> BeatId { get; set; }
        public Nullable<System.DateTime> DataEntryDate { get; set; }
    }
}
