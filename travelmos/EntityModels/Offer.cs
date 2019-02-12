using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.EntityModels
{
    public class Offer
    {
        public int OfferId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime FromTime { get; set; }
        [DataType(DataType.Time)]
        public string Location { get; set; }
        public bool IncludedTransport { get; set; }
        public string Description { get; set; }
        public int Seats { get; set; }
    }
}
