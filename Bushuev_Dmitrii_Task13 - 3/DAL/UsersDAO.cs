using Entities;
using System;
using System.Collections.Generic;

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

        public void Delete(User DeleteUser)
        {
            userList.Remove(DeleteUser);
        }
    }
}
