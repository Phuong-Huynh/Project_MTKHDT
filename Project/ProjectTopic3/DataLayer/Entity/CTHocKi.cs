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
    
    public partial class CTHocKi
    {
        public CTHocKi()
        {
            this.TKBs = new HashSet<TKB>();
        }
    
        public int Id { get; set; }
        public string PhongHoc { get; set; }
        public System.DateTime NgayHoc { get; set; }
        public string GioHoc { get; set; }
    
        public virtual GiangVien GiangVien { get; set; }
        public virtual HocKi HocKi { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public virtual ICollection<TKB> TKBs { get; set; }
    }
}
