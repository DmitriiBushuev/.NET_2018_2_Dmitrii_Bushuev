using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class UsersDAO : IUsersDAO
    {
        private List<User> userList = new List<User>();

        public void Add(User newUser)
        {
            if (newUser == null)
                throw new ArgumentException("user не существует");

            userList.Add(newUser);
        }

        public IEnumerable<User> GetList()
        {
            return userList;
        }

        public void Delete(int id)
        {
            User userForRemove = userList.FirstOrDefault(u => u.Id == id);
            userList.Remove(userForRemove);
        }

        public void Edit(User userForEdit)
        {
        }

        public void AddAward(int userId, int awardId)
        {
            throw new NotImplementedException();
        }

        public void RemoveAward(int userId, int awardId)
        {
            throw new NotImplementedException();
        }
    }
}
