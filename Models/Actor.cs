using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace White.Models
{
    public class Actor
    {
        [Key]
        public int actor_id { get; set; }

        public String first_name { get; set; }

        public String last_name { get; set; }

        public DateTime last_update { get; set; }
    }
}
