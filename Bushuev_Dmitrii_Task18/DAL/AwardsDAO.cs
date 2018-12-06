using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class AwardsDAO : IAwardsDAO
    {
        private List<Award> awardList = new List<Award>();

        public void Add(Award newAward)
        {
            if (newAward == null)
                throw new ArgumentException("award не существует");

            awardList.Add(newAward);
        }

        public IEnumerable<Award> GetList()
        {
            return awardList;
        }

        public void Delete(int id)
        {
            Award awardForRemove = awardList.FirstOrDefault(u => u.Id == id);
            awardList.Remove(awardForRemove);
        }

        public void Edit(Award awardForEdit)
        {

        }
    }
}
