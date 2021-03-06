﻿using Project_Topic3.DataLayer.DTO;
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
                //Loi
                return db.CTHocKis.ToList<CTHocKi>();
            }
        }

        public List<CTHocKi> getListWithCurrentTerm() {
            using (MyDbContext db = new MyDbContext())
            {
                HocKi hocki = db.HocKis.OrderByDescending(y => y.Id).First();
                return db.CTHocKis.Where(n => n.HocKi == hocki).ToList<CTHocKi>();
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
                TenGiangVien = t.GiangVien.HoTen,
                TenMonHoc = t.GiangVien.MonHoc.TenMonHoc,
            };
            return gvdto;
            
        }

        public List<CTHocKiDTO> getListDTO(List<CTHocKi> t)
        {
            List<CTHocKiDTO> listDTO = new List<CTHocKiDTO>();   
            foreach (CTHocKi g in t)
            {
                listDTO.Add(this.convert(g));
            }
            return listDTO;
        }

        public List<CTHocKiDTO> getListDTO()
        {
            List<CTHocKi> list = this.getList();
            return this.getListDTO(list);
        }



        public CTHocKi convertDTOToEntity(CTHocKiDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
