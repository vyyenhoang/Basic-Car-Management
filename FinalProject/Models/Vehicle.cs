//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        public int VehicleId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public Nullable<System.DateTime> SoldDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
    
        public virtual CarModel CarModel { get; set; }
        public virtual Make Make { get; set; }
    }
}
