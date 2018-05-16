using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.Interfaces
{
    public interface ICompositionRepository
    {
        t_composition Create(t_composition item);
        t_composition Get(int id);
        void Update(t_composition item);
        void Delete(t_composition item);
        IEnumerable<t_composition> GetAll();
        IEnumerable<t_composition> Find(Func<t_composition, Boolean> predicate);
    
    }
}
