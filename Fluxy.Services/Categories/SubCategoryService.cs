using Fluxy.Data.EntityModels.Categories;
using Fluxy.Repositories.Categories;
using Fluxy.Repositories.Common;
using Fluxy.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Services.Categories
{
    public class SubCategoryService : EntityService<SubCategory>, ISubCategoryService
    {
        IUnitOfWork _unitOfWork;
        ISubCategoryRepository _subCategoryRepository;

        public SubCategoryService(IUnitOfWork unitOfWork, ISubCategoryRepository subCategoryRepository)
            : base(unitOfWork, subCategoryRepository)
        {
            _unitOfWork = unitOfWork;
            _subCategoryRepository = subCategoryRepository;
        }

        public SubCategory GetById(long Id)
        {
            return _subCategoryRepository.GetSingle(Id);
        }
    }
}
