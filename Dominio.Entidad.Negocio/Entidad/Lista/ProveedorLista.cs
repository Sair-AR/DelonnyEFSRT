using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidad.Negocio.Entidad.Lista
{
    public class ProveedorLista
    {
        [Display(Name = "Cod Prov"), Required]
        public string codigo { get; set; }
        [Display(Name = "Nombre"), Required] public string nombre { get; set; }

        [Display(Name = "Distrito"), Required]
        public string codDistrito { get; set; }
        [Display(Name = "Telefóno"), Required] public string fono { get; set; }
    }
}
