using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_DetalleFactura : EntityClass
    {
        public int? id_detallefactura { get; set; }
        public int? fk_id_factura_detallefactura { get; set; }
        public int? fk_id_articulo_detallefactura { get; set; }
        public int? cantidad_detallefactura { get; set; }
    }

}
