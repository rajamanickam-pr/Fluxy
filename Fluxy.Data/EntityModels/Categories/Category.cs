using Fluxy.Data.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Data.EntityModels.Categories
{
    public class Category:AuditableEntity<long>
    {
        [Required]
        public string Name { get; set; }    

        public virtual IEnumerable<SubCategory> SubCategories { get; set; }
    }
}
