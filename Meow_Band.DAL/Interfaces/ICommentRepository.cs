using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.Interfaces
{
    public interface ICommentRepository
    {
        t_comment Create(t_comment item);
        t_comment Get(int id);
        
        void Delete(t_comment item);
        
        IEnumerable<t_comment> Find(Func<t_comment, Boolean> predicate);
    }
}
