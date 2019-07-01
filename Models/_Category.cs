using System.ComponentModel;

namespace Inventario.Models
{
    public enum _Category
    {
        Club,
        [Description("Selección")]
        Selection,
        [Description("Other")]
        Other
    }
}