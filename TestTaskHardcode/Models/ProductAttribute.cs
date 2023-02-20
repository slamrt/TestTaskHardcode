using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestTaskHardcode.Models
{
    //этот класс был создан для того, чтобы добавлять атрибуты каждый товар
    // в моем понимании было использовать коллекцию атрибутов для добавления их в товар, которые были бы 
    //связано по полю ProductId с полем Id у объектов класса Product
    // к сожалению, не хватило времени реализовать данную задумку
    public class ProductAttribute
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string Value { get; set; } = "";
        [ForeignKey("CategoryToAttribute")]
        public int CategoryToAttributeId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

    }
}
