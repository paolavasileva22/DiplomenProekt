﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrichelliGlasses.Domain;

namespace TorrichelliGlasses.Abstractions
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int brandId);
        List<Product> GetProductByBrand(int brandId);
    }
}
