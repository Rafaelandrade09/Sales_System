using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSalesSystem.Models
{

    [Table("Produtos")]
    public class Product
    {
        [Display(Name ="ID")]
        public long Id { get; set; }


        [Column("Nome")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }


        [Column("Descrição")]
        [StringLength(500)]
        public string Description { get; set; }


        [Column("Preço")]
        [Required]
        [Range(1,100)]
        public decimal Price { get; set; }


        [Column("Imagem Url")]
        [StringLength(300)]
        public string ImageURL { get; set; }

        public Product(long id, string name, string description, decimal price, string imageURL)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageURL = imageURL;
        }
    }
}
