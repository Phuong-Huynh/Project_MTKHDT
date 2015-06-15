using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class RoleDAO : IDAO<Role>
    {
        public Role get(int id)
        {

            using (MyDbContext db = new MyDbContext())
            {
                return db.Roles.Find(id);

            }


        }

        public bool insert(Role t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.Roles.Add(t);
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
                Role t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.Roles.Remove(t);
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

        public bool update(Role t)
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

        public List<Role> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Roles.ToList<Role>();
            }
        }
    }
}
