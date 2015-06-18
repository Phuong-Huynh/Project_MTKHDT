using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class TkbDAO :IDAO<TKB>
    {
        public TKB get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.TKBs.Find(id);

            }


        }

        public bool insert(TKB t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.TKBs.Add(t);
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
                TKB t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.TKBs.Remove(t);
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

        public bool update(TKB t)
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

        public List<TKB> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.TKBs.ToList<TKB>();
            }
        }
        public List<TKB> getList(HocSinh Hs)
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.TKBs.Where(n => n.HocSinhID == Hs.Id).ToList<TKB>();
            }
        }
    }
}
