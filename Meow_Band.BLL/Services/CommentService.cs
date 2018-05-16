
using Meow_Band.DAL;
using Meow_Band.DAL.Interfaces;
using Meow_Band.DAL.IntRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Meow_Band.BLL.Services
{
    public static class CommentService 
    {
        static ICommentRepository repository;

        static CommentService()
        {
            repository = new CommentRepository();
        }


        public static t_comment Get(int id)
        {
            return repository.Get(id);
        }

        public static t_comment Create(t_comment item)
        {
            return repository.Create(item);

        }



        public static void Delete(t_comment item)
        {
            repository.Delete(item);

        }

        public static IEnumerable<t_comment> Find(Func<t_comment, bool> predicate)
        {
            return repository.Find(predicate);
        }
    }
}
