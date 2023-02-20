using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTaskHardcode.Models
{
    //поле типов атрибутов
    //связываются с полями таблицы CategoryToAttribute через поле Id с полем 
    //AttributeTypeId класса  CategoryToAttribute
    public class AttributeType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
    }
}
