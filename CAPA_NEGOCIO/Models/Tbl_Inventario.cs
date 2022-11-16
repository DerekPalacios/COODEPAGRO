using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Inventario : EntityClass
    {
        public int? id_inventario { get; set; }
        public int? fk_articulo_inventario { get; set; }
        public int? cantidad { get; set; }
    }
}
