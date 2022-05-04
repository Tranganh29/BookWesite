using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Models
{
    public class OrderBook
    {
        [Key]
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public bool Deleted { get; set; }

        public double SalePrice { get; set; }

        public virtual Book Book { get; set; }

    }
}
