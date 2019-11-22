using Project.Core.Repository;
using Project.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.BusinessServices
{
    public class ModelServices : RepositoryBase<Model>
    {
        public object Select()
        {
            var mdl = (from I in _connDb.GetModels
                       join X in _connDb.GetBrands on
                       I.Brand_ID equals X.ID
                       orderby I.ID descending
                       select new
                       {
                           I.ID,
                           I.Name,
                           BrandName = X.Name
                       }).ToList();
            return mdl;
        }
        public Model Find(int id)
        {
            var mdl = (from I in _connDb.GetModels
                       where I.ID == id
                       select I).FirstOrDefault();
            return mdl;
        }
        public int Count(string name, int id)
        {
            var mdl = (from I in _connDb.GetModels
                       where I.Name == name && I.Brand_ID == id
                       select I).Count();
            return mdl;
        }
        public List<Brand> SelectBrandName()
        {
            var brnd = (from I in _connDb.GetBrands
                        select I).ToList();
            return brnd;
        }
        public Brand FindBrandID(int id)
        {
            var mdl = (from I in _connDb.GetBrands
                       where I.ID == id
                       select I).FirstOrDefault();
            return mdl;
        }
    }
}
