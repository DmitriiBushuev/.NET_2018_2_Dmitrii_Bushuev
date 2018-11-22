using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.BLL
{
    public class UsersBL
    {
        private readonly IUsersDAO UsersDAO;

        public UsersBL()
        {
            UsersDAO = new UsersDAO();
        }

        public IEnumerable<User> InitList()
        {
            Add(new User(new DateTime(2002, 09, 22), "Тom", "White"));
            Add(new User(new DateTime(2003, 09, 22), "Sam", "Black"));
            Add(new User(new DateTime(2004, 09, 22), "Pall", "Orange"));
            Add(new User(new DateTime(2005, 09, 22), "Sasha", "Blue"));
            Add(new User(new DateTime(2001, 09, 22), "Gor", "Grey"));
            Add(new User(new DateTime(1995, 08, 29), "Иван", "Иванов"));
            return GetList();
        }

        public IEnumerable<User> SortUsersByLastNameAsc()
        {
            return (from s in GetList()
                    orderby s.LastName ascending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByLastNameDesc()
        {
            return (from s in GetList()
                    orderby s.LastName descending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByFirstNameAsc()
        {
            return (from s in GetList()
                    orderby s.FirstName ascending
                    select s).ToList();
        }

        public IEnumerable<User> SortUsersByFirstNameDesc()
        {
            return (from s in GetList()
                    orderby s.FirstName descending
                    select s).ToList();
        }

        public void Add(DateTime birthDate, string firstName, string lastName)
        {
            Add(new User(birthDate, firstName, lastName));
        }

        public void Delete(User user)
        {
            UsersDAO.Delete(user);
        }

        public void Add(User user)
        {
            if (user == null)
                throw new ArgumentException("Не выбран пользователь");

            UsersDAO.Add(user);
        }

        public IEnumerable<User> GetList()
        {
            return UsersDAO.GetList();
        }
    }
}

