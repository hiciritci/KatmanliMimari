﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class ProductController: Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                //Products = _productService.GetAll()
                
                Products = category > 0 ? _productService.GetByCategory(category) : _productService.GetAll()
            };
            return View(model);
        }
        public  IActionResult Default()
        {
            
            
            
            return View();
        }
    }
}
