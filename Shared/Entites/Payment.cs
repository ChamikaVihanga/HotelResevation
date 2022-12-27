using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Shared.Entites
{
    public class Payment
    {
        public int Id { get; set; }
        public int OtherPay { get; set; }
        public string PayMethord { get; set; }

        public int ResevationId { get; set; }
        public Resevation Resevation { get; set; }
    }
}
