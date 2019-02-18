using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.EntityModels
{
    public class UserUserType
    {
        public int UserUserTypeId { get; set; }
        public Guide Guide { get; set; }
        public int? GuideId { get; set; }
        public Tourist Tourist { get; set; }
        public int? TouristId { get; set; }
    }
}
