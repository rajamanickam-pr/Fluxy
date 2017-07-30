using Fluxy.Data.EntityModels.Categories;
using Fluxy.Data.Model.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Data.Mapping.Categories
{
    public partial class SubCategoryMap : FluxyEntityTypeConfiguration<SubCategory>
    {
        public SubCategoryMap()
        {
            this.ToTable("SubCategory");
            this.HasKey(sc => sc.Id);

            this.Property(sc => sc.Name).IsRequired().HasMaxLength(200);
            this.Property(sc => sc.CategoryId).IsRequired();
        }
    }
}
