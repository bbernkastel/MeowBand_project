using Meow_Band.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.IntRepository
{
    public class CompositionRepository : ICompositionRepository
    {



        public t_composition Create(t_composition item)
        {
            using (DB_Context db = new DB_Context())
            {

                db.t_composition.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public void Delete(t_composition item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_composition.Attach(item);
                //t_composition item = db.t_composition.Find(id);
                if (item != null)
                    db.t_composition.Remove(item);
                db.SaveChanges();
            }
        }

        public IEnumerable<t_composition> Find(Func<t_composition, Boolean> predicate)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_composition.Where(predicate).ToList();
            }
        }

        public IEnumerable<t_composition> GetAll()
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_composition;
            }
        }

        public t_composition Get(int id)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_composition.Find(id);
            }
        }

        public void Update(t_composition item)
        {

            using (DB_Context db = new DB_Context())
            {
                db.t_composition.Attach(item);
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    
    }
}
