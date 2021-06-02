using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tapshiriq_uni_3.Database
{
    public class CityUniversity
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public int UniversityID { get; set; }
        public City City { get; set; }
        public University University { get; set; }
    }
}
