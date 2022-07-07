﻿using Dapper;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
       public ProductRepository(IDbConnection conn )
        {
            _conn = conn;
        }
        private readonly IDbConnection _conn;
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }

    }
}