using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Articulos : EntityClass
    {
        public int? id_articulos { get; set; }
        public string? nombre_articulo { get; set; }
        public string? descripcion_articulo { get; set; }
        public int? fk_id_categoria_articulo { get; set; }
    }
}
