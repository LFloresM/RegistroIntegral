//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistroIntegral.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Costo
    {
        public int Cos_Id { get; set; }
        public Nullable<int> Con_Id { get; set; }
        public Nullable<decimal> Cos_Precio { get; set; }
        public Nullable<System.DateTime> Cos_Fech { get; set; }
    
        public virtual Concepto Concepto { get; set; }
    }
}
