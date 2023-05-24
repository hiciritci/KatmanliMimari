using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.ViewComponents
{
    public class CategoryListViewComponent: ViewComponent
    {

        private ICategoryService _categoryService;

        public int Currentcategory { get; private set; }

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                Currentcategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };

            return View(model);

        }

    }
}
