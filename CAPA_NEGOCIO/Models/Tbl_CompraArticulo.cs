using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_CompraArticulo : EntityClass
    {
        public int? id_compraarticulo { get; set; }
        public int? fk_id_proveedor_compraarticulo { get; set; }
        public DateTime? fecha_compraarticulo { get; set; }
        public string? subtotal_compraarticulo { get; set; }
        public string? iva_compraarticulo { get; set; }
        public string? total_compraarticulo { get; set; }
    }
}
