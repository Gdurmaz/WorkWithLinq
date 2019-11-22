using Project.Core.Repository;
using Project.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Project.Core.BusinessServices
{
    public class ReportServices:RepositoryBase<Car>
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
                          Model = B.Name,
                          Brand = M.Name,
                          BodyName = I.BodyType.Name,
                          ColorName = I.ColorID.Name,
                          YearName = I.Years.Value.Year,
                          I.SalePrice,
                          I.IsRental
                      }).ToList();
            return cr;
        }
        public decimal MonthlyIncome()
        {
            var rprt = (from I in _connDb.GetCars
                        where I.Years.Value.Month == DateTime.Now.Month
                        select new {
                            ToplamKazanıc=I.SalePrice
                        }.ToplamKazanıc).ToList().Sum();
            return rprt;
        }
        public object SelectYears(DateTime year)
        {
            var rprt = (from I in _connDb.GetCars
                        where I.Years.Value.Year == year.Year
                        select I.SalePrice).Sum();
            return rprt;
        }
        public decimal SelectBrand(int ID)
        {
            var rprt = (from I in _connDb.GetCars
                        join X in _connDb.GetModels on
                        I.Model_ID equals X.ID
                        join B in _connDb.GetBrands on
                        X.Brand_ID equals B.ID
                        where B.ID == ID
                        select I.SalePrice).Sum();
            return rprt;
        }
        public decimal SelectModel(int ID)
        {
            var rprt = (from I in _connDb.GetCars
                        join X in _connDb.GetModels on
                        I.Model_ID equals X.ID
                        where X.ID== ID
                        select I.SalePrice).Sum();
            return rprt;
        }
        public object SelectColor(Core.Entities.Color color)
        {
            var rprt = (from I in _connDb.GetCars
                        where I.ColorID.ID == color.ID
                        select I.SalePrice).Sum();
            return rprt;
        }
        public object SelectVehicles(VehicleBody vehicleBody)
        {
            var rprt = (from I in _connDb.GetCars
                        where I.BodyType.ID == vehicleBody.ID
                        select I.SalePrice).Sum();
            return rprt;
        }
        public object SelectIsRental(bool check)
        {
            var rprt = (from I in _connDb.GetCars
                        where I.IsRental ==check
                        select I.SalePrice).Sum();
            return rprt;
        }
    }
}
