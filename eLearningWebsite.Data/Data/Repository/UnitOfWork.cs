using eLearningWebsite.Data.Data.Repository.IRepository;
using eLearningWebsite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLearningWebsite.Data.Data.Repository
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Course = new CourseRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICourseRepository Course { get; set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
