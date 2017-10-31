using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTemplate.Data.Models
{
    using AspNetCoreTemplate.Data.Common.Models;

    public class Setting : BaseModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
}
