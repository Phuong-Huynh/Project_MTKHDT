using Project_Topic3.DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    public class HocSinhDAO :IDAO<HocSinh>, IObjectDAO<HocSinh, HocSinhDTO>
    {
        public HocSinh get(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.HocSinhs.Find(id);
            }
        }

        public bool insert(HocSinh t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.HocSinhs.Add(t);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public bool delete(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                HocSinh t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.HocSinhs.Remove(t);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
                return false;
            }
        }

        public bool update(HocSinh t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.Entry(t).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public List<HocSinh> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.HocSinhs.ToList<HocSinh>();
            }
        }

        public HocSinhDTO convert(HocSinh t)
        {
            HocSinhDTO hsdto = new HocSinhDTO
                {
                    Id = t.Id,
                    HoTen = t.HoTen,
                    NgaySinh = t.NgaySinh,
                    DiaChi = t.DiaChi,
                    IdLop = t.IdLop,
                    IdTaiKhoan = t.IdTaiKhoan,
                };
                return hsdto;
        }
        public List<HocSinhDTO> getListDTO()
        {
            List<HocSinh> list = this.getList();
            return this.getListDTO(list);
        }

        public List<HocSinhDTO> getListDTO(List<HocSinh> t)
        {
            List<HocSinhDTO> listDTO = new List<HocSinhDTO>();
            foreach (HocSinh hs in t)
            {
                listDTO.Add(this.convert(hs));
            }
            return listDTO;
        }
    }
}
