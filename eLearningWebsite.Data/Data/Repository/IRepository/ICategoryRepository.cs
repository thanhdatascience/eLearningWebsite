using eLearningWebsite.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace eLearningWebsite.Data.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Category category);
    }
}
