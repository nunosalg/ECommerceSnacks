﻿using ApiECommerce.Context;
using ApiECommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiECommerce.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Product>> GetBestSellerProductsAsync()
        {
            return await _appDbContext.Products.Where(p => p.BestSeller).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetPopularProductsAsync()
        {
            return await _appDbContext.Products.Where(p => p.Popular).ToListAsync();
        }

        public async Task<Product> GetProductDetailsAsync(int id)
        {
            var productDetail = await _appDbContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            //if (productDetail is null) throw new InvalidOperationException("The searched product doesn't exist.");

            return productDetail!;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _appDbContext.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
