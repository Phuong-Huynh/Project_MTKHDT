using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    public class HocSinhDAO :IDAO<HocSinh>
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
    }
}
