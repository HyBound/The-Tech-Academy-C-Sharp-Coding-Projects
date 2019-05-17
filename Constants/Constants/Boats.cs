using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Boats
    {
        public int _boatId { get; set; }
        public string _name { get; set; }

        public Boats(int BoatId) : this(BoatId, "")
        {

        }
        public Boats(int BoatId, string Name)
        {
            _boatId = BoatId;
            _name = Name;
        }
    }
}
