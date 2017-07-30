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
    public class CategoryService : EntityService<Category>, ICategoryService
    {
        IUnitOfWork _unitOfWork;
        ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository) 
            : base(unitOfWork, categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public Category GetById(long Id)
        {
            return _categoryRepository.GetById(Id);
        }
    }
}
