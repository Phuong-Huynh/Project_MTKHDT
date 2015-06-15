using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class HocKiDAO : IDAO<HocKi>
    {
        public HocKi get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.HocKis.Find(id);

            }


        }

        public bool insert(HocKi t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.HocKis.Add(t);
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
                HocKi t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.HocKis.Remove(t);
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

        public bool update(HocKi t)
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

        public List<HocKi> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.HocKis.ToList<HocKi>();
            }
        }
    }
}
