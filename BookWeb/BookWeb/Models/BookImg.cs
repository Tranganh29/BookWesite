using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Models
{
    public class BookImg
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Data { get; set; }

        public string Description { get; set; }

        public bool Deleted { get; set; }
    }
}
