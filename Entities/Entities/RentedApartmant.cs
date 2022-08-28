using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class RentedApartmant : CoreEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Confirmed { get; set; }
        public Guid UserId { get; set; }//FK
        public virtual User User { get; set; }
    }
}
