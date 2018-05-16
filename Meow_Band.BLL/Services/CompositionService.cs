
using Meow_Band.DAL;
using Meow_Band.DAL.Interfaces;
using Meow_Band.DAL.IntRepository;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Meow_Band.BLL.Services
{
    public static class CompositionService
    {
        static ICompositionRepository repository;

        static CompositionService()
        {
            repository = new CompositionRepository();
        }
            

        public static IEnumerable<t_composition> GetAll()
        {
            return repository.GetAll();
        }

        public static t_composition Get(int id)
        {
            return repository.Get(id);
        }

        public static t_composition Create(t_composition item)
        {
            return repository.Create(item);

        }

        public static void Update(t_composition item)
        {
            repository.Update(item);
        }

        public static void Delete(t_composition item)
        {
            repository.Delete(item);

        }

        public static IEnumerable<t_composition> Find(Func<t_composition, bool> predicate)
        {
            return repository.Find(predicate);
        }

        
           
    }
}
