using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighborhoodBuilder
{
    public class NeighborhoodInfo<T>
    {
        public T NumberOfHouses { get; set; }
        public T ConditionOfHouses { get; set; }
        public T ModernityOfHouses { get; set; }
        public string isThereASchool { get; set; }
        public T ConditionOfRoad { get; set; }
        public T TransportAvailability { get; set; }
        public T CrimeRates { get; set; }
    }
}
