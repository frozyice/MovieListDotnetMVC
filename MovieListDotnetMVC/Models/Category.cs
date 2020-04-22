using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieListDotnetMVC.Models
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

        public virtual Movie Movie { get; set; }
        
        public Category()
        {
            CategoryId = Guid.NewGuid();
        }
    }
}