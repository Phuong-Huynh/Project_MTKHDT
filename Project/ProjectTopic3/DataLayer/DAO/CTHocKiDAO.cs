using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Topic3.DataLayer.DAO
{
    class CTHocKiDAO : IDAO<CTHocKi>
    {
        
        public CTHocKiDAO()
        {
            
        }
        public CTHocKi get(int id)
        {
            
            using (MyDbContext db = new MyDbContext() )
            {
                return db.CTHocKis.Find(id);
                
            }

            
        }

        public bool insert(CTHocKi t)
        {
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    db.CTHocKis.Add(t);
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e )
                {
                    return false;
                }
                

            }
        }

        public bool delete(int id)
        {
            using (MyDbContext db = new MyDbContext())
            { 
                CTHocKi t = this.get(id);
                if (t != null)
                {
                    try
                    {
                        db.CTHocKis.Remove(t);
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

        public bool update(CTHocKi t)
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

        public List<CTHocKi> getList()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.CTHocKis.ToList<CTHocKi>();
            }
        }
    }
}
