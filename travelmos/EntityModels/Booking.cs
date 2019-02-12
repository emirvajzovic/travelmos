using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.EntityModels
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Offer Offer { get; set; }
        public int OfferId { get; set; }
        public Tourist Tourist { get; set; }
        public int TouristId { get; set; }
        public int ReservedSeats { get; set; }
    }
}
