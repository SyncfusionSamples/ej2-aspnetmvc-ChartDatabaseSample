﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CDASH2018Entities : DbContext
    {
        public CDASH2018Entities()
            : base("name=CDASH2018Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TbAssetManagementLifeCycleStatus> TbAssetManagementLifeCycleStatuses { get; set; }
        public virtual DbSet<TbAssetManagementLinuxOsEndPoint> TbAssetManagementLinuxOsEndPoints { get; set; }
        public virtual DbSet<TbAssetManagementWindowsEndPoint> TbAssetManagementWindowsEndPoints { get; set; }
        public virtual DbSet<TbAssetManagementSoftwareLicense> TbAssetManagementSoftwareLicenses { get; set; }
    }
}
