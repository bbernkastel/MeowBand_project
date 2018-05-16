
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
    public static class GenreService 
    {
        static IGenreRepository repository;

        static GenreService()
        {
            repository = new GenreRepository();
        }

        public static IEnumerable<t_genre> GetAll()
        {
            return repository.GetAll();
        }

        public static t_genre Get(int id)
        {
            return repository.Get(id);
        }

        public static t_genre Create(t_genre item)
        {
            return repository.Create(item);

        }

        public static void Update(t_genre item)
        {
            repository.Update(item);
        }

        public static void Delete(t_genre item)
        {
            repository.Delete(item);

        }

        public static IEnumerable<t_genre> Find(Func<t_genre, bool> predicate)
        {
            return repository.Find(predicate);
        }
    }
}
