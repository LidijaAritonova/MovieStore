using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;

namespace MovieStore.Repositories.Repository.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int userId);

        IEnumerable<User> GetUsers();
        IQueryable<User> GetUsersQueryable();

        User GetUserById(int userId);
    }
}
