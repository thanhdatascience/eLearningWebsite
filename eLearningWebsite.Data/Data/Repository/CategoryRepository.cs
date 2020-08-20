﻿using eLearningWebsite.Data.Data.Repository.IRepository;
using eLearningWebsite.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace eLearningWebsite.Data.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.Category.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Category.FirstOrDefault(s => s.Id == category.Id);

            objFromDb.Name = category.Name;

            _db.SaveChanges();

        }
    }
}