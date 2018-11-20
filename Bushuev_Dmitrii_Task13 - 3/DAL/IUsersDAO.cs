using Entities;
using System.Collections.Generic;

namespace DAL
{
    public interface IUsersDAO
    {
        void Add(User user);
        void Delete(User user);
        IEnumerable<User> GetList();
    }
}
