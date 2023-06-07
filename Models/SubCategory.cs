using System.ComponentModel.DataAnnotations;

namespace SnackisAPI.Models
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
    }
}
