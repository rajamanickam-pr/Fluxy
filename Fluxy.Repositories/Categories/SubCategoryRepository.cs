using Fluxy.Data.EntityModels.Categories;
using Fluxy.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Fluxy.Repositories.Categories
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(DbContext context)
            : base(context)
        {
        }

        public SubCategory GetSingle(long id)
        {
            return  GetSingle(c => c.Id == id);
        }
    }
}
