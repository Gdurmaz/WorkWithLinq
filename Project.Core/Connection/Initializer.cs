using System;
using System.Collections.Generic;
using System.Data.Entity;
using Project.Core.Entities;

namespace Project.Core.Connection
{
    public class Initializer : CreateDatabaseIfNotExists<ConnectionDb>
    {
        protected override void Seed(ConnectionDb context)
        {
            string[] marka = { "Mercedes", "BMw", "Audi", "Opel" };
            string[] mercedes = { "A-Serisi", "C-Serisi", "B-Serisi", "S-Serisi" };
            string[] bmw = { "2-Serisi", "3-Serisi", "4-Serisi", "5-Serisi" };
            string[] Audi = { "A3", "S3", "a4", "a5", "a6" };
            string[] Opel = { "Astra", "Corsa", "Insignia" };
            for (int i = 0; i < marka.Length; i++)
            {
                Brand brand = new Brand()
                {
                    Name = marka[i].ToUpper()
                };
                context.GetBrands.Add(brand);
            }
            context.SaveChanges();
            for (int j = 0; j < mercedes.Length; j++)
            {
                Model models = new Model()
                {
                    Name = mercedes[j].ToUpper(),
                    Brand_ID = 1
                };
                context.GetModels.Add(models);
            }
            context.SaveChanges();

            for (int j = 0; j < bmw.Length; j++)
            {
                Model models = new Model()
                {
                    Name = bmw[j].ToUpper(),
                    Brand_ID = 2
                };
                context.GetModels.Add(models);
            }
            context.SaveChanges();
            for (int j = 0; j < Audi.Length; j++)
            {
                Model models = new Model()
                {
                    Name = Audi[j].ToUpper(),
                    Brand_ID = 3
                };
                context.GetModels.Add(models);
            }
            for (int j = 0; j < Opel.Length; j++)
            {
                Model models = new Model()
                {
                    Name = Opel[j].ToUpper(),
                    Brand_ID = 4
                };
                context.GetModels.Add(models);
            }
            context.SaveChanges();
        }

    }
}
