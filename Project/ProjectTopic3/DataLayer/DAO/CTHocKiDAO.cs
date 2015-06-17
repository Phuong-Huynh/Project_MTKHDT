using Project_Topic3.DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    public class CTHocKiDAO : IDAO<CTHocKi>, IObjectDAO<CTHocKi, CTHocKiDTO>
    {
        
        public CTHocKiDAO()
        {
            
        }
        public CTHocKi get(int id)
        {
            
            using (MyDbContext db = new MyDbContext() )
            {
                return db.CTHocKis.Find(id);
                
            }

            
        }

        public bool insert(CTHocKi t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.CTHocKis.Add(t);
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e )
                {
                    return false;
                }
                

            }
        }

        public bool delete(int id)
        {
            using (MyDbContext db = new MyDbContext())
            { 
                CTHocKi t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.CTHocKis.Remove(t);
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

        public bool update(CTHocKi t)
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

        public List<CTHocKi> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.CTHocKis.ToList<CTHocKi>();
            }
        }

        public List<CTHocKi> getListWithCurrentTerm() {
            using (MyDbContext db = new MyDbContext())
            {
                HocKi hocki = db.HocKis.OrderByDescending(y => y.Id).First();
                return db.CTHocKis.Where(n => n.IdHocKi == hocki.Id).ToList<CTHocKi>();
            }
        }

        public CTHocKiDTO convert(CTHocKi t)
        {
            CTHocKiDTO gvdto = new CTHocKiDTO
            {
                Id = t.Id,
                PhongHoc = t.PhongHoc,
                NgayHoc = t.NgayHoc,
                GioHoc = t.GioHoc,
                //TenHocKi = t.HocKi.TenHK,
                TenMonHoc = t.MonHoc.TenMonHoc,
                TenGiangVien = t.GiangVien.HoTen,
            };
            return gvdto;
        }

        public List<CTHocKiDTO> getListDTO()
        {
            throw new NotImplementedException();
        }
    }
}
