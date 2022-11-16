using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_DetalleCompraArticulo : EntityClass
    {
        public int? id_detallecompra { get; set; }
        public int? fk_id_compraarticulo_detalle { get; set; }
        public int? fk_id_articulo_detalle { get; set; }
        public int? cantidad_detalle { get; set; }
    }
}
