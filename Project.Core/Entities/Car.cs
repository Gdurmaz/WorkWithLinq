using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    public class Car
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public Color ColorID { get; set; }
        public VehicleBody BodyType { get; set; }
        public DateTime? Years { get; set; }
        public decimal SalePrice { get; set; }
        public bool  IsRental { get; set; }
        public int Model_ID { get; set; }
        public List<Model> Models { get; set; }
    }
}
