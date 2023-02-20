using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskHardcode.Models
{
    public class CategoryToAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;

        [ForeignKey("Category")]

        public int CategoryId { get; set; }
        [ForeignKey("AttributeType")]
        public int AttributeTypeId { get; set; }

    }
}
