//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMedication
    {
        public int MedicationID { get; set; }
        public string Name { get; set; }
        public int ManufacturerID { get; set; }
        public string Strength { get; set; }
        public string DrugType { get; set; }
        public string ScheduleNo { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public string ContainsPenicilin { get; set; }
        public Nullable<int> AlternativeID { get; set; }
    }
}
