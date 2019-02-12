using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.EntityModels
{
    public class Guide
    {
        public int GuideId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Offer Offer { get; set; }
        public int OfferId { get; set; }
    }
}
