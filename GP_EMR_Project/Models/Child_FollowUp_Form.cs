//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GP_EMR_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Child_FollowUp_Form
    {
        public long Patient_Id { get; set; }
        public int Age_In_Month { get; set; }
        public string Feed_Type { get; set; }
        public string Vaccination_Type { get; set; }
        public Nullable<System.DateTime> Vaccination_Date { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}