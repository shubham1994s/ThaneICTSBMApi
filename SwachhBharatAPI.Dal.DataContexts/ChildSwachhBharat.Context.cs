﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DevSwachhBharatNagpurEntities : DbContext
    {
        public DevSwachhBharatNagpurEntities(int AppId)
              : base(SwachhBharatAppConnection.GetConnectionString(AppId))
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GramCleaningComplient> GramCleaningComplients { get; set; }
        public virtual DbSet<TeritoryMaster> TeritoryMasters { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<WardNumber> WardNumbers { get; set; }
        public virtual DbSet<ZoneMaster> ZoneMasters { get; set; }
        public virtual DbSet<GarbagePointDetail> GarbagePointDetails { get; set; }
        public virtual DbSet<DumpYardDetail> DumpYardDetails { get; set; }
        public virtual DbSet<Qr_Employee_Daily_Attendance> Qr_Employee_Daily_Attendance { get; set; }
        public virtual DbSet<QrEmployeeMaster> QrEmployeeMasters { get; set; }
        public virtual DbSet<BinLatLong> BinLatLongs { get; set; }
        public virtual DbSet<DeviceDetail> DeviceDetails { get; set; }
        public virtual DbSet<GamePlayerDetail> GamePlayerDetails { get; set; }
        public virtual DbSet<WM_GarbageCategory> WM_GarbageCategory { get; set; }
        public virtual DbSet<WM_GarbageSubCategory> WM_GarbageSubCategory { get; set; }
        public virtual DbSet<WM_Garbage_Summary> WM_Garbage_Summary { get; set; }
        public virtual DbSet<WM_Garbage_Details> WM_Garbage_Details { get; set; }
        public virtual DbSet<Vw_GetHouseNumber> Vw_GetHouseNumber { get; set; }
        public virtual DbSet<WM_Garbage_Sales> WM_Garbage_Sales { get; set; }
        public virtual DbSet<Vw_MsgNotification> Vw_MsgNotification { get; set; }
        public virtual DbSet<Vw_GetLiquidNumber> Vw_GetLiquidNumber { get; set; }
        public virtual DbSet<Vw_GetStreetNumber> Vw_GetStreetNumber { get; set; }
        public virtual DbSet<Daily_Attendance> Daily_Attendance { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Qr_Location> Qr_Location { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<StreetSweepingBeat> StreetSweepingBeats { get; set; }
        public virtual DbSet<Vw_BitCount> Vw_BitCount { get; set; }
        public virtual DbSet<GarbageCollectionDetail> GarbageCollectionDetails { get; set; }
        public virtual DbSet<CommercialMaster> CommercialMasters { get; set; }
        public virtual DbSet<HouseMaster> HouseMasters { get; set; }
        public virtual DbSet<LiquidWasteDetail> LiquidWasteDetails { get; set; }
        public virtual DbSet<StreetSweepingDetail> StreetSweepingDetails { get; set; }
        public virtual DbSet<SWMMaster> SWMMasters { get; set; }
        public virtual DbSet<SauchalayAddress> SauchalayAddresses { get; set; }
    
        public virtual ObjectResult<sp_area_Result> sp_area()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_area_Result>("sp_area");
        }
    
        public virtual ObjectResult<CollecctionArea_Result> CollecctionArea(Nullable<int> type)
        {
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CollecctionArea_Result>("CollecctionArea", typeParameter);
        }
    
        public virtual ObjectResult<CurrentAllUserLocation_Result> CurrentAllUserLocation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CurrentAllUserLocation_Result>("CurrentAllUserLocation");
        }
    
        public virtual ObjectResult<GetMobile_Result> GetMobile(Nullable<int> areaId)
        {
            var areaIdParameter = areaId.HasValue ?
                new ObjectParameter("areaId", areaId) :
                new ObjectParameter("areaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMobile_Result>("GetMobile", areaIdParameter);
        }
    
        public virtual ObjectResult<SP_Dashboard_Details_Result> SP_Dashboard_Details()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Dashboard_Details_Result>("SP_Dashboard_Details");
        }
    
        public virtual ObjectResult<SP_GarbageCollection_Result> SP_GarbageCollection(Nullable<int> appId, Nullable<int> userid, Nullable<System.DateTime> fdate, Nullable<System.DateTime> tdate, Nullable<int> zoneId, Nullable<int> areaId, Nullable<int> wardNo, Nullable<int> segid, Nullable<int> segidSub)
        {
            var appIdParameter = appId.HasValue ?
                new ObjectParameter("appId", appId) :
                new ObjectParameter("appId", typeof(int));
    
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            var fdateParameter = fdate.HasValue ?
                new ObjectParameter("fdate", fdate) :
                new ObjectParameter("fdate", typeof(System.DateTime));
    
            var tdateParameter = tdate.HasValue ?
                new ObjectParameter("tdate", tdate) :
                new ObjectParameter("tdate", typeof(System.DateTime));
    
            var zoneIdParameter = zoneId.HasValue ?
                new ObjectParameter("ZoneId", zoneId) :
                new ObjectParameter("ZoneId", typeof(int));
    
            var areaIdParameter = areaId.HasValue ?
                new ObjectParameter("AreaId", areaId) :
                new ObjectParameter("AreaId", typeof(int));
    
            var wardNoParameter = wardNo.HasValue ?
                new ObjectParameter("WardNo", wardNo) :
                new ObjectParameter("WardNo", typeof(int));
    
            var segidParameter = segid.HasValue ?
                new ObjectParameter("Segid", segid) :
                new ObjectParameter("Segid", typeof(int));
    
            var segidSubParameter = segidSub.HasValue ?
                new ObjectParameter("SegidSub", segidSub) :
                new ObjectParameter("SegidSub", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GarbageCollection_Result>("SP_GarbageCollection", appIdParameter, useridParameter, fdateParameter, tdateParameter, zoneIdParameter, areaIdParameter, wardNoParameter, segidParameter, segidSubParameter);
        }
    
        public virtual ObjectResult<SP_DumpYardDetails_Result> SP_DumpYardDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DumpYardDetails_Result>("SP_DumpYardDetails");
        }
    
        public virtual ObjectResult<SP_DistanceCount_Result> SP_DistanceCount(Nullable<double> sLat, Nullable<double> sLong, Nullable<double> dLat, Nullable<double> dLong)
        {
            var sLatParameter = sLat.HasValue ?
                new ObjectParameter("sLat", sLat) :
                new ObjectParameter("sLat", typeof(double));
    
            var sLongParameter = sLong.HasValue ?
                new ObjectParameter("sLong", sLong) :
                new ObjectParameter("sLong", typeof(double));
    
            var dLatParameter = dLat.HasValue ?
                new ObjectParameter("dLat", dLat) :
                new ObjectParameter("dLat", typeof(double));
    
            var dLongParameter = dLong.HasValue ?
                new ObjectParameter("dLong", dLong) :
                new ObjectParameter("dLong", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_DistanceCount_Result>("SP_DistanceCount", sLatParameter, sLongParameter, dLatParameter, dLongParameter);
        }
    
        public virtual ObjectResult<HouseDetails_Result> HouseDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HouseDetails_Result>("HouseDetails");
        }
    
        public virtual ObjectResult<PointDetails_Result> PointDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PointDetails_Result>("PointDetails");
        }
    
        public virtual ObjectResult<CurrentAllUserLocationUserIDWise_Result> CurrentAllUserLocationUserIDWise(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CurrentAllUserLocationUserIDWise_Result>("CurrentAllUserLocationUserIDWise", userIdParameter);
        }
    
        public virtual ObjectResult<SP_IdelTime_Result> SP_IdelTime(Nullable<int> userId, Nullable<System.DateTime> fdate, Nullable<System.DateTime> tdate)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var fdateParameter = fdate.HasValue ?
                new ObjectParameter("fdate", fdate) :
                new ObjectParameter("fdate", typeof(System.DateTime));
    
            var tdateParameter = tdate.HasValue ?
                new ObjectParameter("tdate", tdate) :
                new ObjectParameter("tdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_IdelTime_Result>("SP_IdelTime", userIdParameter, fdateParameter, tdateParameter);
        }
    
        public virtual ObjectResult<SP_EmployeeSummary_Result> SP_EmployeeSummary(Nullable<System.DateTime> from, Nullable<System.DateTime> to, Nullable<int> userid)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(System.DateTime));
    
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EmployeeSummary_Result>("SP_EmployeeSummary", fromParameter, toParameter, useridParameter);
        }
    
        public virtual ObjectResult<SP_EmployeeTarget_Result> SP_EmployeeTarget(Nullable<System.DateTime> fdate, Nullable<System.DateTime> tdate, Nullable<int> userid)
        {
            var fdateParameter = fdate.HasValue ?
                new ObjectParameter("fdate", fdate) :
                new ObjectParameter("fdate", typeof(System.DateTime));
    
            var tdateParameter = tdate.HasValue ?
                new ObjectParameter("tdate", tdate) :
                new ObjectParameter("tdate", typeof(System.DateTime));
    
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EmployeeTarget_Result>("SP_EmployeeTarget", fdateParameter, tdateParameter, useridParameter);
        }
    
        public virtual ObjectResult<SP_HousePointDumpDetails_Scanify_Result> SP_HousePointDumpDetails_Scanify(string referenceId, Nullable<int> gcType)
        {
            var referenceIdParameter = referenceId != null ?
                new ObjectParameter("ReferenceId", referenceId) :
                new ObjectParameter("ReferenceId", typeof(string));
    
            var gcTypeParameter = gcType.HasValue ?
                new ObjectParameter("gcType", gcType) :
                new ObjectParameter("gcType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_HousePointDumpDetails_Scanify_Result>("SP_HousePointDumpDetails_Scanify", referenceIdParameter, gcTypeParameter);
        }
    
        public virtual ObjectResult<HouseDetails_ReferanceId_Result> HouseDetails_ReferanceId(string referanceId)
        {
            var referanceIdParameter = referanceId != null ?
                new ObjectParameter("ReferanceId", referanceId) :
                new ObjectParameter("ReferanceId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HouseDetails_ReferanceId_Result>("HouseDetails_ReferanceId", referanceIdParameter);
        }
    
        public virtual ObjectResult<SP_UserLatLongDetail_Result> SP_UserLatLongDetail(Nullable<int> userid, Nullable<int> typeId)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("userid", userid) :
                new ObjectParameter("userid", typeof(int));
    
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("typeId", typeId) :
                new ObjectParameter("typeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_UserLatLongDetail_Result>("SP_UserLatLongDetail", useridParameter, typeIdParameter);
        }
    
        public virtual ObjectResult<SP_HouseOnMapDetails_Result> SP_HouseOnMapDetails(Nullable<System.DateTime> gcDate, Nullable<int> userId, Nullable<int> zoneId, Nullable<int> areaId, Nullable<int> wardNo, Nullable<int> garbageType, Nullable<int> filterType, Nullable<int> segType)
        {
            var gcDateParameter = gcDate.HasValue ?
                new ObjectParameter("gcDate", gcDate) :
                new ObjectParameter("gcDate", typeof(System.DateTime));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var zoneIdParameter = zoneId.HasValue ?
                new ObjectParameter("ZoneId", zoneId) :
                new ObjectParameter("ZoneId", typeof(int));
    
            var areaIdParameter = areaId.HasValue ?
                new ObjectParameter("AreaId", areaId) :
                new ObjectParameter("AreaId", typeof(int));
    
            var wardNoParameter = wardNo.HasValue ?
                new ObjectParameter("WardNo", wardNo) :
                new ObjectParameter("WardNo", typeof(int));
    
            var garbageTypeParameter = garbageType.HasValue ?
                new ObjectParameter("GarbageType", garbageType) :
                new ObjectParameter("GarbageType", typeof(int));
    
            var filterTypeParameter = filterType.HasValue ?
                new ObjectParameter("FilterType", filterType) :
                new ObjectParameter("FilterType", typeof(int));
    
            var segTypeParameter = segType.HasValue ?
                new ObjectParameter("SegType", segType) :
                new ObjectParameter("SegType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_HouseOnMapDetails_Result>("SP_HouseOnMapDetails", gcDateParameter, userIdParameter, zoneIdParameter, areaIdParameter, wardNoParameter, garbageTypeParameter, filterTypeParameter, segTypeParameter);
        }
    
        public virtual ObjectResult<SP_TotalHouseCollection_Count_Result> SP_TotalHouseCollection_Count(Nullable<System.DateTime> gcdate)
        {
            var gcdateParameter = gcdate.HasValue ?
                new ObjectParameter("gcdate", gcdate) :
                new ObjectParameter("gcdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_TotalHouseCollection_Count_Result>("SP_TotalHouseCollection_Count", gcdateParameter);
        }
    
        public virtual ObjectResult<GetGarbageCountDetailsTotal_Result> GetGarbageCountDetailsTotal(Nullable<int> userId, Nullable<int> year, Nullable<int> month)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGarbageCountDetailsTotal_Result>("GetGarbageCountDetailsTotal", userIdParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<GetGarbageCountDetailsHistory_Result> GetGarbageCountDetailsHistory(Nullable<int> userId, Nullable<int> year, Nullable<int> month, Nullable<int> day)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var dayParameter = day.HasValue ?
                new ObjectParameter("day", day) :
                new ObjectParameter("day", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGarbageCountDetailsHistory_Result>("GetGarbageCountDetailsHistory", userIdParameter, yearParameter, monthParameter, dayParameter);
        }
    
        public virtual ObjectResult<sp_MsgNotification_Result> sp_MsgNotification(string starttime)
        {
            var starttimeParameter = starttime != null ?
                new ObjectParameter("starttime", starttime) :
                new ObjectParameter("starttime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MsgNotification_Result>("sp_MsgNotification", starttimeParameter);
        }
    
        public virtual ObjectResult<sp_Locationdata_Result> sp_Locationdata(Nullable<System.DateTime> fdate, Nullable<System.DateTime> tdate)
        {
            var fdateParameter = fdate.HasValue ?
                new ObjectParameter("fdate", fdate) :
                new ObjectParameter("fdate", typeof(System.DateTime));
    
            var tdateParameter = tdate.HasValue ?
                new ObjectParameter("tdate", tdate) :
                new ObjectParameter("tdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Locationdata_Result>("sp_Locationdata", fdateParameter, tdateParameter);
        }
    
        public virtual ObjectResult<GetAttendenceDetailsTotalLiquid_Result> GetAttendenceDetailsTotalLiquid(Nullable<int> userId, Nullable<int> year, Nullable<int> month)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAttendenceDetailsTotalLiquid_Result>("GetAttendenceDetailsTotalLiquid", userIdParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<GetAttendenceDetailsTotalStreet_Result> GetAttendenceDetailsTotalStreet(Nullable<int> userId, Nullable<int> year, Nullable<int> month)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAttendenceDetailsTotalStreet_Result>("GetAttendenceDetailsTotalStreet", userIdParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<CollecctionAreaForLiquid_Result> CollecctionAreaForLiquid(Nullable<int> type)
        {
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CollecctionAreaForLiquid_Result>("CollecctionAreaForLiquid", typeParameter);
        }
    
        public virtual ObjectResult<CollecctionAreaForStreet_Result> CollecctionAreaForStreet(Nullable<int> type)
        {
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CollecctionAreaForStreet_Result>("CollecctionAreaForStreet", typeParameter);
        }
    
        public virtual ObjectResult<GetQrWorkHistory_Result> GetQrWorkHistory(Nullable<int> userId, Nullable<int> year, Nullable<int> month)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetQrWorkHistory_Result>("GetQrWorkHistory", userIdParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<GetAttendenceDetailsTotal_Result> GetAttendenceDetailsTotal(Nullable<int> userId, Nullable<int> year, Nullable<int> month)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAttendenceDetailsTotal_Result>("GetAttendenceDetailsTotal", userIdParameter, yearParameter, monthParameter);
        }
    }
}
