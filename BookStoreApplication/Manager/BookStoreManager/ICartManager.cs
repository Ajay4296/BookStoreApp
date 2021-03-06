﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Model;

namespace Manager.Manager
{
    public interface ICartManager
    {
        Task<int> AddCart(CartModel cartModel);
        CartModel DeleteCart(int id);
        int CountCart();
        IQueryable GetAllCartValue();
    }
}
