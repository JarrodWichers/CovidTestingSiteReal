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
    
    public partial class tblChronic
    {
        public int ChronicID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> MedicationID { get; set; }
        public string Frequency { get; set; }
    }
}
