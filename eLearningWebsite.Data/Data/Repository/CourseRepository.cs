using eLearningWebsite.Data.Data.Repository.IRepository;
using eLearningWebsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace eLearningWebsite.Data.Data.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Course course)
        {
            var objFromDb = _db.Course.FirstOrDefault(s => s.Id == course.Id);

            objFromDb.Name = course.Name;
            objFromDb.Price = course.Price;
            objFromDb.ImgUrl = course.ImgUrl;
            objFromDb.CategoryId = course.CategoryId;

            _db.SaveChanges();
        }
    }
}
