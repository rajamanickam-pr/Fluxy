﻿using Fluxy.Data.EntityModels.Categories;
using Fluxy.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Repositories.Categories
{
    public interface ISubCategoryRepository: IGenericRepository<SubCategory>
    {
        SubCategory GetSingle(long id);
    }
}
