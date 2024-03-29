﻿using Entities.DomainMadels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUI.Helpers
{
   public interface ICartSessionHelper
    {
        Cart GetCart(string key);
        void SetCart(string key,Cart cart);
        void Clear();
    }
}
