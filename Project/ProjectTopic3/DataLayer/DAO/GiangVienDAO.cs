﻿using Project_Topic3.DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    public class GiangVienDAO :IDAO<GiangVien>, IObjectDAO<GiangVien,GiangVienDTO>
    {
        

        public GiangVien get(int id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.GiangViens.Find(id);
            }
        }

        public bool insert(GiangVien t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.GiangViens.Add(t);
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
                GiangVien t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.GiangViens.Remove(t);
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

        public bool update(GiangVien t)
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

        public List<GiangVien> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                
                return db.GiangViens.ToList<GiangVien>();
            }
        }

        public GiangVienDTO convert(GiangVien t)
        {
            GiangVienDTO gvdto = new GiangVienDTO
            {
                Id = t.Id,
                HoTen = t.HoTen,
                NgaySinh = t.NgaySinh,
                DiaChi = t.DiaChi,
            };
            return gvdto;
        }

        public List<GiangVienDTO> getListDTO()
        {
            List<GiangVien> list = this.getList();
            return this.getListDTO(list);    
        }

        public List<GiangVienDTO> getListDTO(List<GiangVien> t)
        {
            List<GiangVienDTO> listDTO = new List<GiangVienDTO>();
            foreach (GiangVien g in t)
            {
                listDTO.Add(this.convert(g));
            }
            return listDTO;
        }


        public GiangVien convertDTOToEntity(GiangVienDTO t)
        {
            throw new NotImplementedException();
        }
    }
}
