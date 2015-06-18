using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DTO
{
    public class HocSinhDTO : PersonDTO
    {
        public string MSSV { get; set; }
        public int TenLop { get; set; }
        public int TenTaiKhoan { get; set; }
    }
}
