using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Department.BLL
{
    public class AwardsBL
    {
        private readonly IAwardsDAO AwardsDAO;

        public AwardsBL()
        {
            if (!bool.TryParse(ConfigurationManager.AppSettings["UseDb"], out bool useDb))
            {
                useDb = false;
            }

            AwardsDAO = useDb ? new AwardsSqlDAO() : (IAwardsDAO)new AwardsDAO();
        }

        //public AwardsBL()
        //{
        //    AwardsDAO = new AwardsSqlDAO();
        //}

        public IEnumerable<Award> InitList()
        {
            //Add(new Award("First degree hero", "great hero"));
            //Add(new Award("Second degree hero", "so-so hero"));
            //Add(new Award("Darwin Award", "not cool"));
            //Add(new Award("Duelist", "the fastest hand in the wild west"));
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

            AwardsDAO.Delete(award.Id);
        }

        public IEnumerable<Award> GetList()
        {
            return AwardsDAO.GetList();
        }

        public void Edit(Award award)
        {
            AwardsDAO.Edit(award);
        }

        public IEnumerable<Award> SortByAsc(Func<Award, object> orderBy)
        {
            return GetList().OrderBy(orderBy).ToList();
        }

        public IEnumerable<Award> SortByDesc(Func<Award, object> orderBy)
        {
            return GetList().OrderByDescending(orderBy).ToList();
        }
    }
}

