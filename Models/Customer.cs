using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace White.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }

        public String first_name { get; set; }

        public String last_name { get; set; }

        public String email { get; set; }

        public int active { get; set; }

        public DateTime create_date { get; set; }

        public DateTime last_update { get; set; }

        public int address_id { get; set; }

        public Address address { get; set; }

        //public int address_id { get; set; }

        //[InverseProperty("customer")]
        //public Address address { get; set; }


    }
}
