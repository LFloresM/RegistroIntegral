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
    
    public partial class Calificacion
    {
        public int Cal_Id { get; set; }
        public int Mod_Id { get; set; }
        public int Alu_Id { get; set; }
        public Nullable<System.DateTime> Cal_Fech { get; set; }
        public string Cal_Condicion { get; set; }
        public decimal Cal_Practica { get; set; }
        public decimal Cal_Teorica { get; set; }
        public Nullable<decimal> Cal_Oral { get; set; }
        public Nullable<decimal> Cal_Otros { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
