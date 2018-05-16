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
    public static class CompositionGenreService
    {
        static ICompGenreRepository repository;

        static CompositionGenreService()
        {
            repository = new CompositionGenreRepository();
        }
        
        public static t_compositiongenre Get(int id)
        {
            return repository.Get(id);
        }

        public static t_compositiongenre Create(t_compositiongenre item)
        {
            return repository.Create(item);

        }

        public static void Update(t_compositiongenre item)
        {
            repository.Update(item);
        }

        public static void Delete(t_compositiongenre item)
        {
            repository.Delete(item);

        }

        public static IEnumerable<t_compositiongenre> Find(Func<t_compositiongenre, bool> predicate)
        {
            return repository.Find(predicate);
        }

    }
}
