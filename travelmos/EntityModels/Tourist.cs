using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travelmos.EntityModels
{
    public class Tourist
    {
        public int TouristId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PrimaryLanguageId { get; set; }
        public Language PrimaryLanguage { get; set; }
        public int? SecondaryLanguageId { get; set; }
        public Language SecondaryLanguage { get; set; }
    }
}
