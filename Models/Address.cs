using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace White.Models
{
    public class Address
    {
        [Key]
        public int address_id { get; set; }

        public string address { get; set; }

        public string address2 { get; set; }

        public string district { get; set; }

        public string phone { get; set; }

        public DateTime last_update { get; set; }

        //[InverseProperty("address")]
        //public Customer customer { get; set; }

    }
}
