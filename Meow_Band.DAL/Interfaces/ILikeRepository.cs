using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.Interfaces
{
    public interface ILikeRepository
    {
        t_userlikes Create(t_userlikes item);
        t_userlikes Get(int id);
        
        void Delete(t_userlikes item);
        
        IEnumerable<t_userlikes> Find(Func<t_userlikes, Boolean> predicate);
    }
}
