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
    
    public partial class HocKi
    {
        public HocKi()
        {
            this.CTHocKis = new HashSet<CTHocKi>();
            this.TongKetHKs = new HashSet<TongKetHK>();
        }
    
        public int Id { get; set; }
        public string TenHK { get; set; }
        public System.DateTime BatDau { get; set; }
        public System.DateTime KetThuc { get; set; }

        public virtual ICollection<CTHocKi> CTHocKis { get; set; }
        public virtual ICollection<TongKetHK> TongKetHKs { get; set; }
    }
}
