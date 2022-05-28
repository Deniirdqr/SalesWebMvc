﻿using System;
using System.Linq;
using SalesWebMvc.Models;
using System.Collections.Generic;
using SalesWebMvc.Data;

namespace SalesWebMvc.Services

{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
