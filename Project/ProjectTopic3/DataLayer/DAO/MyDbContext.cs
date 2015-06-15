using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class MyDbContext : DbContext
    {

        public MyDbContext() : base("name=MyStundent") { }

        public virtual DbSet<CTHocKi> CTHocKis { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<HocKi> HocKis { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TKB> TKBs { get; set; }
        public virtual DbSet<TongKetHK> TongKetHKs { get; set; }
    }
    
}
