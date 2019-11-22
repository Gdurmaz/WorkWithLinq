using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Helper
{
    public class Method
    {

        public static List<Entities.Color> GetColors()
        {
            List<Entities.Color> _color = new List<Entities.Color>() {
                new Entities.Color{ID=1,Name="Kırmızı"},
                new Entities.Color{ID=2,Name="Beyaz"},
                new Entities.Color{ID=3,Name="Siyah"},
                new Entities.Color{ID=4,Name="Lacivert"},
                new Entities.Color{ID=5,Name="Metal Gri"},
            };
            return _color;
        }
        public static List<Entities.Year> GetYears() {
            List<Entities.Year> _year = new List<Entities.Year>() {
                new Entities.Year{ID=1,Years=DateTime.Now.AddYears(0)},
                new Entities.Year{ID=2,Years=DateTime.Now.AddYears(-1)},
                new Entities.Year{ID=3,Years=DateTime.Now.AddYears(-2)},
                new Entities.Year{ID=4,Years=DateTime.Now.AddYears(-3)},
                new Entities.Year{ID=5,Years=DateTime.Now.AddYears(-4)},
                new Entities.Year{ID=6,Years=DateTime.Now.AddYears(-5)},
                new Entities.Year{ID=7,Years=DateTime.Now.AddYears(-6)},
            };
            return _year;
        }
        public static List<Entities.VehicleBody> GetVehicleBodies() {
            List<Entities.VehicleBody> _vehicle = new List<Entities.VehicleBody>() {
                new Entities.VehicleBody{ID=1,Name="Sedan"},
                new Entities.VehicleBody{ID=2,Name="Hatchback"},
                new Entities.VehicleBody{ID=3,Name="Station Wagon"},
                new Entities.VehicleBody{ID=4,Name="Cabrio"},
                new Entities.VehicleBody{ID=5,Name="Coupe"},
                new Entities.VehicleBody{ID=6,Name="SUV"},
                new Entities.VehicleBody{ID=7,Name="Cross Over"}
            };
            return _vehicle;
        }
    }
}
