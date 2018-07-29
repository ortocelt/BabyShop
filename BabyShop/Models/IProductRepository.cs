﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyShop.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get;  }
    }
}
