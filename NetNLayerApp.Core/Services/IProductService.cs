﻿using NetNLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetNLayerApp.Core.Services
{
    interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);

        //bool ControlInnerBarcode(Product product); 
    }
}
