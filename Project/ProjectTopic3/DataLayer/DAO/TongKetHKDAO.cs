using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class TongKetHKDAO : IDAO<TongKetHK>
    {
        public TongKetHK get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.TongKetHKs.Find(id);

            }


        }

        public bool insert(TongKetHK t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.TongKetHKs.Add(t);
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
                TongKetHK t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.TongKetHKs.Remove(t);
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

        public bool update(TongKetHK t)
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

        public List<TongKetHK> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.TongKetHKs.ToList<TongKetHK>();
            }
        }
    }
}
