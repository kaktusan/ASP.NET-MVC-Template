using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data.Common.Models
{
    public abstract class DomainObject
    {
        [Key]
        public int Id { get; set; }
    }
}
