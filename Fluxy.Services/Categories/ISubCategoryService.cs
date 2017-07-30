using Fluxy.Data.EntityModels.Categories;
using Fluxy.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Services.Categories
{
    public interface ISubCategoryService : IEntityService<SubCategory>
    {
        SubCategory GetById(long Id);
    }
}
