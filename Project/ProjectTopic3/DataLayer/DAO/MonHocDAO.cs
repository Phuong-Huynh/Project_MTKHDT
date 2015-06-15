using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class MonHocDAO : IDAO<MonHoc>
    {
        public MonHoc get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.MonHocs.Find(id);

            }


        }

        public bool insert(MonHoc t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.MonHocs.Add(t);
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
                MonHoc t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.MonHocs.Remove(t);
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

        public bool update(MonHoc t)
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

        public List<MonHoc> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.MonHocs.ToList<MonHoc>();
            }
        }
    }
}
