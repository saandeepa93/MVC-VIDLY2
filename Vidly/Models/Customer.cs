using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Display(Name = "Is Subscribed to News Letter?")]

        public bool isSubscribedToNewsLetter { get; set; }

        public MembershipType memberShipType { get; set; }

        [Display(Name ="Membership Type")]
        public byte memberShipTypeId { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime? birthDate { get; set; }

    }
}