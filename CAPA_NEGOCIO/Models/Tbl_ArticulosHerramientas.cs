using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_ArticulosHerramientas : EntityClass
    {
        public int? id_articulosherramientas { get; set; }
        public int? fk_id_articulos_herramientas { get; set; }
        public string presentacion_articulosherramientas { get; set; }
        public string? precio_articulosherramientas { get; set; }
        public string caracteristicas_articulosherramientas { get; set; }
        public int? fk_id_marca_articulosherramientas { get; set; }
    }

}
