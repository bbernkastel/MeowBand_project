using Meow_Band.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.IntRepository
{
    public class LikeRepository : ILikeRepository
    {
        public t_userlikes Create(t_userlikes item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_userlikes.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public void Delete(t_userlikes item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_userlikes.Attach(item);
                //t_userlikes item = db.t_userlikes.Find(id);
                if (item != null)
                    db.t_userlikes.Remove(item);
                db.SaveChanges();
            }
        }

        public IEnumerable<t_userlikes> Find(Func<t_userlikes, bool> predicate)
        {
            using (DB_Context db = new DB_Context()) { return db.t_userlikes.Where(predicate).ToList(); }
        }

        public t_userlikes Get(int id)
        {
            using (DB_Context db = new DB_Context()) { return db.t_userlikes.Find(id); }
        }

        
    }
}
