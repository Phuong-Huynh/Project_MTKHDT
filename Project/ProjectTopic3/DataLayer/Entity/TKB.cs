//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Topic3.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TKB
    {
        public int Id { get; set; }
        public int IdHocSinh { get; set; }
        public int IdCTHocKi { get; set; }
        public Nullable<int> Diem { get; set; }
    
        public virtual CTHocKi CTHocKi { get; set; }
        public virtual HocSinh HocSinh { get; set; }
    }
}