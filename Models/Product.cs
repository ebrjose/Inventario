using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 100 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Tipo de Camiseta")]
        public _Category Category { get; set; }

        [Display(Name = "Talla")]
        public _Size Size { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Precio de Compra")]
        public float BuyingPrice { get; set; }

        [Display(Name = "Precio de Venta")]
        public float SellingPrice { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Size}, {Category}";
        }
    }
}