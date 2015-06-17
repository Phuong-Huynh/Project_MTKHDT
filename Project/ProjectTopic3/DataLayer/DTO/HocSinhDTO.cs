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
        public int IdLop { get; set; }
        public int IdTaiKhoan { get; set; }
    }
}
