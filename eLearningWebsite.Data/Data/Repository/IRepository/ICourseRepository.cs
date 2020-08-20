using eLearningWebsite.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLearningWebsite.Data.Data.Repository.IRepository
{
    public interface ICourseRepository : IRepository<Course>
    {
        void Update(Course course);

    }
}
