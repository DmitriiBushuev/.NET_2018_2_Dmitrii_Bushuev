using Entities;
using System.Collections.Generic;


namespace DAL
{
    public interface IAwardsDAO
    {
        void Add(Award award);
        void Delete(int id);
        IEnumerable<Award> GetList();
        void Edit(Award awardForEdit);
    }
}
