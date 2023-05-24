using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class CategoryController : Controller

    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;


        }
    }
}
               //CATEGORY LİSTELEMEK İÇİN KULLANDIĞIMIZ ACTİON
        //public IActionResult Index()
        //{
        //    var model = new CategoryListViewModel
        //    {
        //        Categories = _categoryService.GetAll()
        //    };

        //        return View(model);


        //}

        //}


    

