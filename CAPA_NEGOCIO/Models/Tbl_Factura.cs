using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Factura : EntityClass
    {
        public int? id_factura { get; set; }
        public int? fk_id_cliente_factura { get; set; }
        public int? fk_id_personal_factura { get; set; }
        public DateTime? fecha_factura { get; set; }
        public string? subtotal_factura { get; set; }
        public string? iva_factura { get; set; }
        public string? total_factura { get; set; }
    }
}
