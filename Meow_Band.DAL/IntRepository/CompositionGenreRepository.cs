using Meow_Band.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.IntRepository
{
    public class CompositionGenreRepository : ICompGenreRepository
    {
        

        public t_compositiongenre Create(t_compositiongenre item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_compositiongenre.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public void Delete(t_compositiongenre item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_compositiongenre.Attach(item);
                //t_compositiongenre item = db.t_compositiongenre.Find(id);
                //if (item != null)
                    db.t_compositiongenre.Remove(item);
            }
        }

        public IEnumerable<t_compositiongenre> Find(Func<t_compositiongenre, bool> predicate)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_compositiongenre.Where(predicate).ToList();
            }
        }

        public t_compositiongenre Get(int id)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_compositiongenre.Find(id);
            }
        }

        public void Update(t_compositiongenre item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_compositiongenre.Attach(item);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
