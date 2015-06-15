using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class TaiKhoanDAO : IDAO<TaiKhoan>
    {
        public TaiKhoan get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.TaiKhoans.Find(id);

            }


        }

        public bool insert(TaiKhoan t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.TaiKhoans.Add(t);
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
                TaiKhoan t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.TaiKhoans.Remove(t);
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

        public bool update(TaiKhoan t)
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

        public List<TaiKhoan> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.TaiKhoans.ToList<TaiKhoan>();
            }
        }
    }
}
