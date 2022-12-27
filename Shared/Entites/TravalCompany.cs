using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Shared.Entites
{
    public class TravalCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfTourists { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }

        public List<Resevation> Resevations { get; set; }

    }
}
