using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Shared.Entites
{
    public class Resevation
    {
        public int Id { get; set; }

        /// <summary>
        ///  One to many realatioon
        /// </summary>
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        /// <summary>
        ///  One to many realatioon
        /// </summary>
        /// 
        public int TravalCompanyId { get; set; }
        public TravalCompany TravalCompany { get; set; }
        /// <summary>
        ///  One to many realatioon
        /// </summary>
        public int RoomId { get; set; } 
        public Room Room { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int Occupants { get; set; }
        /// <summary>
        /// one to one
        /// </summary>
        public Payment Payment { get; set; }
    }
}
