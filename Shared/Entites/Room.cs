using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Shared.Entites
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Price { get; set; }
        public string Facility { get; set; }

        public List<Resevation> Resevations { get; set; }
    }
}
