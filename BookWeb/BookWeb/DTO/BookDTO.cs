using BookWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }

        public string NameBook { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public int Quantity { get; set; }

        public bool Deleted { get; set; }

        public virtual Category Category { get; set; }

        public virtual IList<BookImg> BookImg { get; set; }

        public UserDTO CreatedUser { get; set; }

        public UserDTO UpdateUser { get; set; }


    }
}
