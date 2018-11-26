using Entities;
using System.Collections.Generic;

namespace DAL
{
    public interface IUsersDAO
    {
        void Add(User user);
        void Delete(int id);
        IEnumerable<User> GetList();
        void Edit(User userForEdit);
        void AddAward(int userId, int awardId);
        void RemoveAward(int userId, int awardId);
    }
}
