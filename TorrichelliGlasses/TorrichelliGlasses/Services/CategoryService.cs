﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrichelliGlasses.Abstractions;
using TorrichelliGlasses.Data;
using TorrichelliGlasses.Domain;

namespace TorrichelliGlasses.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ApplicationDbContext _context;
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public List<Product> GetProductByCategory(int categoryId)
        {
            return _context.Products.Where(x => x.BrandId == categoryId)
                 .ToList();
        }
    }
}
