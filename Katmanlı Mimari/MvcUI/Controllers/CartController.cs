﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Helpers;
using MvcUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Controllers
{
    public class CartContoller : Controller
    {
        private ICartService _cartService;
        ICartSessionHelper _cartSessionHelper;
        IProductService _productService;

        public CartContoller(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }
        public IActionResult AddToCart(int productId)
        {
            //ürünü çek
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(cart, product);
            _cartSessionHelper.SetCart(key:"cart", cart);
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart(key:"cart")
            };

            return View(model);
        }
        public IActionResult RemoveFromCart(int productId)
        {
            Product product = _productService.GetById(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.RemoveFormCart(cart, productId);
            _cartSessionHelper.SetCart("cart", cart);
            return RedirectToAction("Index", "Product");
        }
    }
}
