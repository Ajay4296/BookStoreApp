﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model.Model;
using Repository.Repository;

namespace Manager.Manager
{
    public class CartManager : ICartManager
    {
        private readonly ICartRepository cartRepository;

        public CartManager(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        public Task<int> AddCart(CartModel cartModel)
        {
            return cartRepository.AddCart(cartModel);
        }
    }
}
