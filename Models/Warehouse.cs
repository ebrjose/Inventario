using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Name { get; set; }
        [Display(Name = "Departamento")]
        public _Department Department { get; set; }
        public string Address { get; set; }

    }
}