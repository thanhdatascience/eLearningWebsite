﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eLearningWebsite.Data.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICourseRepository Course { get; }
        void Save();
    }
}
