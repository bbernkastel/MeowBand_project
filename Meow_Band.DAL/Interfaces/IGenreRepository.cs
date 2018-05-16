using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.Interfaces
{
    public interface IGenreRepository
    {
        t_genre Create(t_genre item);
        t_genre Get(int id);
        void Update(t_genre item);
        void Delete(t_genre item);
        IEnumerable<t_genre> GetAll();
        IEnumerable<t_genre> Find(Func<t_genre, Boolean> predicate);
    
    }
}
