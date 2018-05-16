using Meow_Band.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.IntRepository
{
    public class CommentRepository : ICommentRepository
    {

        

        public t_comment Create(t_comment item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_comment.Add(item);
                db.SaveChanges();
                return item;
            }
        }

        public void Delete(t_comment item)
        {
            using (DB_Context db = new DB_Context())
            {
                db.t_comment.Attach(item);
                //t_comment item = db.t_comment.Find(id);
                if (item != null)
                    db.t_comment.Remove(item);
                db.SaveChanges();
            }
        }

        public IEnumerable<t_comment> Find(Func<t_comment, bool> predicate)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_comment.Where(predicate).ToList();
            }
        }

        public t_comment Get(int id)
        {
            using (DB_Context db = new DB_Context())
            {
                return db.t_comment.Find(id);
            }
        }
    }
}
