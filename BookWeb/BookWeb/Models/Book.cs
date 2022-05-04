using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string NameBook { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public int Quantity { get; set; }

        public bool Deleted { get; set; }

        public virtual Category Category { get; set; }

        //public virtual Unit Unit { get; set; }

        public virtual IList<BookImg> BookImg { get; set; }

        public virtual User CreatedUser { get; set; }

        public virtual User UpdateUser { get; set; }
    }
}
