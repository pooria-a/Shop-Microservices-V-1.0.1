﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Products
{
    public interface IProductReadRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<List<Product>> GetAsync(int id);
    }
}
