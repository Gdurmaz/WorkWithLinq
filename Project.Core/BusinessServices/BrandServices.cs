using Project.Core.Repository;
using Project.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.BusinessServices
{
    public class BrandServices:RepositoryBase<Brand>
    {
        public List<Brand> Select()
        {
            var brnd = (from I in _connDb.GetBrands
                       orderby I.ID descending
                       select I).ToList();
            return brnd;
        }
        public Brand Find(int id)
        {
            var brnd = (from I in _connDb.GetBrands
                        where I.ID == id
                        select I).FirstOrDefault();
            return brnd;
        }
        public int Count(string name)
        {
            var brnd = (from I in _connDb.GetBrands
                        where I.Name==name
                        select I).Count();
            return brnd;
        }
    }
}
