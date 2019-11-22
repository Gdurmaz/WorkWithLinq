using Project.Core.Repository;
using Project.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Project.Core.BusinessServices
{
    public class CarServices : RepositoryBase<Car>
    {
        public object Select()
        {
            var cr = (from I in _connDb.GetCars
                      join M in _connDb.GetModels on
                      I.Model_ID equals M.ID
                      join B in _connDb.GetBrands on
                      M.Brand_ID equals B.ID
                      select new
                      {
                          I.ID,
                          Model=B.Name,
                          Brand=M.Name,
                          BodyName= I.BodyType.Name,
                          ColorName=I.ColorID.Name,
                          YearName=I.Years.Value.Year,
                          I.SalePrice,
                          I.IsRental
                      }).ToList();
            return cr;
        }
        public Car Find(int ID)
        {
            var cr = (from I in _connDb.GetCars
                     where I.ID == ID
                     select I).FirstOrDefault();
            return cr;
        }
        public int Control(string Mname,string Bname,VehicleBody body,Color color,DateTime year)
        {
            var cr = (from I in _connDb.GetCars
                      join M in _connDb.GetModels on
                      I.Model_ID equals M.ID
                      join B in _connDb.GetBrands on
                      M.Brand_ID equals B.ID
                      where M.Name==Mname && B.Name==Bname && I.BodyType.ID==body.ID && I.ColorID.ID ==color.ID &&I.Years ==year
                      select I).Count();
            return cr;
        }
        public List<Model> SelectModelName()
        {
            var brnd = (from I in _connDb.GetModels
                        select I).ToList();
            return brnd;
        }
        public object SelectBrandName(int id)
        {
            var brnd = (from I in _connDb.GetBrands
                        where I.ID == id
                        select I.Name).FirstOrDefault();
            return brnd;
        }
    }
}
