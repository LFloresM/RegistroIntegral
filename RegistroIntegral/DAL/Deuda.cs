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
    
    public partial class Deuda
    {
        public int Deu_Id { get; set; }
        public Nullable<int> Con_Id { get; set; }
        public Nullable<decimal> Deu_Monto { get; set; }
        public Nullable<bool> Deu_Estado { get; set; }
        public Nullable<int> Alu_Id { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Concepto Concepto { get; set; }
    }
}
