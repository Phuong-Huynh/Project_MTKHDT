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
    using Project_Topic3.DataLayer.DAO;
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
        public int HocKiID { get; set; }
        public int GiangVienID { get; set; }

        public GiangVien GiangVien { 
            get{
                GiangVienDAO giangVienDAO = new GiangVienDAO();
                return giangVienDAO.get(HocKiID);
            }
            set 
            {

            }
        }

        public HocKi HocKi { 
            get {
                HocKiDAO hocKiDAO = new HocKiDAO();
                return hocKiDAO.get(HocKiID);
            }
            set { 
            }
        }

        public ICollection<TKB> TKBs { get; set; }
    }
}

