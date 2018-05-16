
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Meow_Band.DAL.Interfaces;
using Meow_Band.DAL;
using Meow_Band.DAL.IntRepository;
using Meow_Band.BLL.Infrastructure;
using System.Text.RegularExpressions;
using AutoMapper;

namespace Meow_Band.BLL.Services
{
    public static class UserService 
    {
        static IUserRepository repository;

        static UserService()
        {
            repository = new UserRepository();
        }

        public static IEnumerable<t_user> GetAll()
        {
            return repository.GetAll();
        }

        public static t_user Get(int id)
        {
            return repository.Get(id);
        }

        public static t_user Create(t_user item)
        {
            return repository.Create(item);

        }

        public static void Update(t_user item)
        {
            repository.Update(item);
        }

        public static void Delete(t_user item)
        {
            repository.Delete(item);

        }

        public static IEnumerable<t_user> Find(Func<t_user, bool> predicate)
        {
            return repository.Find(predicate);
        }

           
    }
}
