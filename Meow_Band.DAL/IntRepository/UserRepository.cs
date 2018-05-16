using Meow_Band.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.IntRepository
{
    public class UserRepository : IUserRepository
    {
        

        public t_user Create(t_user item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_user.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public void Delete(t_user item)
        {

            using (DB_Context db = new DB_Context())
            {
                db.t_user.Attach(item);
                //t_user item = db.t_user.Find(id);
                if (item != null)
                    
                    item.disactivated = true;
                db.SaveChanges();
            }
        }

        public IEnumerable<t_user> Find(Func<t_user, bool> predicate)
        {
            using (DB_Context db = new DB_Context()) {
                return db.t_user.Where(predicate).ToList();
            }
        }

        public t_user Get(int id)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_user.Find(id);
            }
         }

        public IEnumerable<t_user> GetAll()
        {
            using (DB_Context db = new DB_Context())
            { return db.t_user; }
        }

        public void Update(t_user item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_user.Attach(item);//hz
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
