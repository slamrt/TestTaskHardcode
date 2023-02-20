using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Mvc;

 namespace TestTaskHardcode.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string? Name { get; set; } = "";
        public string? Description { get; set; } = "";
        public double Price { get; set;}
        
        [ForeignKey("Category")]
        public int CategoryId { get; set;}
        //в условиях задания было написано, что у Товара должна быть фотография
        //к сожалению, я не успел реализовать это в проекте из-за нехватки времени
        /*public List<Photo> Images { get; set;}

        [FromForm]
        [NotMapped]
        public IFormFileCollection Files { get; set; }*/

        /*public class Photo
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public byte[] Bytes { get; set; }
            public string Description { get; set; }
            public string FileExtension { get; set; }
            public decimal Size { get; set; }
            [ForeignKey("ProductId")]
            public int ProductId { get; set; }
            public Product Product { get; set; }
        }*/

    }
}
