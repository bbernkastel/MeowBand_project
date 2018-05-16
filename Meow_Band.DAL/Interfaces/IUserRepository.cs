using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow_Band.DAL.Interfaces
{
    public interface IUserRepository 
    {
        t_user Create(t_user item);
        t_user Get(int id);
        void Update(t_user item);
        void Delete(t_user item);
        IEnumerable<t_user> GetAll();
        IEnumerable<t_user> Find(Func<t_user, Boolean> predicate);
    
    }
}
