using Meow_Band.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.IntRepository
{
    public class GenreRepository: IGenreRepository 
    {


        public t_genre Create(t_genre item)
        {
            using (DB_Context db = new DB_Context()) { db.t_genre.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public void Delete(t_genre item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_genre.Attach(item);
                //t_genre item = db.t_genre.Find(id);
                if (item != null)
                    db.t_genre.Remove(item);
                db.SaveChanges();
            }
        }

        public IEnumerable<t_genre> Find(Func<t_genre, bool> predicate)
        {
            using (DB_Context db = new DB_Context()) { return db.t_genre.Where(predicate).ToList(); }
        }

        public IEnumerable<t_genre> GetAll()
        {
            using (DB_Context db = new DB_Context()) { return db.t_genre.ToList(); }
        }

        public t_genre Get(int id)
        {
            using (DB_Context db = new DB_Context()) { return db.t_genre.Find(id); }
        }


        public void Update(t_genre item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_genre.Attach(item);
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    
    }
}
