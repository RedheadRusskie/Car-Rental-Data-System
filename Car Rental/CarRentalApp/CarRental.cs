//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRental
    {
        public int ID { get; set; }
        public string Customer_Name { get; set; }
        public Nullable<System.DateTime> Date_Rented { get; set; }
        public Nullable<System.DateTime> Date_Returned { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> CarType { get; set; }
    
        public virtual CarType CarType1 { get; set; }
    }
}
