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
    
    public partial class SP_GarbageCollection_Result
    {
        public int gcId { get; set; }
        public Nullable<System.DateTime> gcDate { get; set; }
        public Nullable<int> userId { get; set; }
        public string userName { get; set; }
        public Nullable<int> houseId { get; set; }
        public string houseOwner { get; set; }
        public string ReferanceId { get; set; }
        public string locAddresss { get; set; }
        public string vehicleNumber { get; set; }
        public string note { get; set; }
        public string gpBeforImage { get; set; }
        public string gpAfterImage { get; set; }
        public Nullable<int> garbageType { get; set; }
        public string batteryStatus { get; set; }
    }
}
