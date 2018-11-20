using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.BLL
{
    public class AwardsBL
    {
        private readonly IAwardsDAO AwardsDAO;

        public AwardsBL()
        {
            AwardsDAO = new AwardsDAO();
        }

        public IEnumerable<Award> InitList()
        {
            Add(new Award("First degree hero", "great hero"));
            Add(new Award("Second degree hero", "so-so hero"));
            Add(new Award("Darwin Award", "not cool"));
            Add(new Award("Duelist", "the fastest hand in the wild west"));
            return GetList();
        }

        public IEnumerable<Award> SortAwardsByTitleAsc()
        {
            return (from s in GetList()
                    orderby s.title ascending
                    select s);
        }

        public IEnumerable<Award> SortAwardsByTitleDesc()
        {
            return (from s in GetList()
                    orderby s.title descending
                    select s).ToList();
        }

        public void Add(string title,string description)
        {
            Add(new Award(title, description));
        }

        public void Add(Award award)
        {
            if (award == null)
                throw new ArgumentException("Не выбрана награда");

            AwardsDAO.Add(award);
        }

        public void Delete(Award award)
        {
            if (award == null)
                throw new ArgumentException("Не выбрана награда");

            AwardsDAO.Delete(award);
        }

        public IEnumerable<Award> GetList()
        {
            return AwardsDAO.GetList();
        }
    }
}

