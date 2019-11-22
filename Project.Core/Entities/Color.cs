using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    public class Color
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
