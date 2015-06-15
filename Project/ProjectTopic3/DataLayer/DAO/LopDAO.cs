using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class LopDAO :IDAO<Lop>
    {
        public Lop get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.Lops.Find(id);

            }


        }

        public bool insert(Lop t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.Lops.Add(t);
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
                Lop t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.Lops.Remove(t);
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

        public bool update(Lop t)
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

        public List<Lop> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Lops.ToList<Lop>();
            }
        }
    }
}
