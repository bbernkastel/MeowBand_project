
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
    public static class LikesService 

    {
        static ILikeRepository repository;

        static LikesService()
        {
            repository = new LikeRepository();
        }

        
        public static t_userlikes Get(int id)
        {
            return repository.Get(id);
        }

        public static t_userlikes Create(t_userlikes item)
        {
            return repository.Create(item);

        }

        

        public static void Delete(t_userlikes item)
        {
            repository.Delete(item);

        }

        public static IEnumerable<t_userlikes> Find(Func<t_userlikes, bool> predicate)
        {
            return repository.Find(predicate);
        }

    }
}
