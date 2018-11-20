using Entities;
using System.Collections.Generic;


namespace DAL
{
    public interface IAwardsDAO
    {
        void Add(Award award);
        void Delete(Award award);
        IEnumerable<Award> GetList();
    }
}
