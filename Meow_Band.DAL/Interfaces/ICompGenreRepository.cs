using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.Interfaces
{
    public interface ICompGenreRepository
    {
        t_compositiongenre Create(t_compositiongenre item);
        t_compositiongenre Get(int id);
        void Update(t_compositiongenre item);
        void Delete(t_compositiongenre item);
        
        IEnumerable<t_compositiongenre> Find(Func<t_compositiongenre, Boolean> predicate);
    }
}
