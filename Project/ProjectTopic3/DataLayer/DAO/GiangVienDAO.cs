using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class GiangVienDAO :IDAO<GiangVien>
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
    }
}
