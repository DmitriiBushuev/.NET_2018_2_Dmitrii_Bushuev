using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Department.BLL
{
    public class UsersBL
    {
        private readonly IUsersDAO UsersDAO;

        public UsersBL()
        {
            if (!bool.TryParse(ConfigurationManager.AppSettings["UseDb"], out bool useDb))
            {
                useDb = false;
            }

            UsersDAO = useDb ? new UsersSqlDAO() : (IUsersDAO)new UsersDAO();
        }

        public IEnumerable<User> InitList()
        {
            //Add(new User(new DateTime(2002, 09, 22), "Тom", "White"));
            //Add(new User(new DateTime(2003, 09, 22), "Sam", "Black"));
            //Add(new User(new DateTime(2004, 09, 22), "Pall", "Orange"));
            //Add(new User(new DateTime(2005, 09, 22), "Sasha", "Blue"));
            //Add(new User(new DateTime(2001, 09, 22), "Gor", "Grey"));
            //Add(new User(new DateTime(1995, 08, 29), "Иван", "Иванов"));
            return GetList();
        }

        public IEnumerable<User> SortByAsc(Func<User, object> orderBy)
        {
            return GetList().OrderBy(orderBy).ToList();
        }

        public IEnumerable<User> SortByDesc(Func<User, object> orderBy)
        {
            return GetList().OrderByDescending(orderBy).ToList();
        }

        public void Add(DateTime birthDate, string firstName, string lastName)
        {
            Add(new User(birthDate, firstName, lastName));
        }

        public void Delete(User user)
        {
            UsersDAO.Delete(user.Id);
        }

        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentException("Не выбран пользователь");

            UsersDAO.Add(user);
        }

        public void Edit(User user)
        {
            UsersDAO.Edit(user);
        }

        public IEnumerable<User> GetList()
        {
            return UsersDAO.GetList();
        }

        public void AddAward(int userId, int awardId)
        {
            UsersDAO.AddAward(userId, awardId);
        }

        public void RemoveAward(int userId, int awardId)
        {
            UsersDAO.RemoveAward(userId, awardId);
        }
    }
}

