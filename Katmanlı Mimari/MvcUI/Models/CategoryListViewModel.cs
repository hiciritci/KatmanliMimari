using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }

        
        public int Currentcategory { get;  set; }
    }
}
