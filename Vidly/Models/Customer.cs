using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isSubscribedToNewsLetter { get; set; }
        public MembershipType memberShipType { get; set; }
        public byte memberShipTypeId { get; set; }

    }
}