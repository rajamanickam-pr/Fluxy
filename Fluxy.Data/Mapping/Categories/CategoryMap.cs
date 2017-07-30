using Fluxy.Data.EntityModels.Categories;
using Fluxy.Data.Model.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Data.Mapping.Categories
{
    public partial class CategoryMap: FluxyEntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.ToTable("Category");
            this.HasKey(sc => sc.Id);
            this.Property(sc => sc.Name).IsRequired().HasMaxLength(200);
        }
    }
}
