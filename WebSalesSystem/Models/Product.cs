using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSalesSystem.Models
{

    [Table("Produtos")]
    public class Product
    {
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
    }
}
