using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_ArticulosAgroquimicos : EntityClass
    {
        public int? id_articulosagroquimicos { get; set; }
        public int? fk_id_articulos_agroquimicos { get; set; }
        public string presentacion_articulosagroquimicos { get; set; }
        public string unidaddemedida_articulosagroquimicos { get; set; }
        public string? precio_articulosagroquimicos { get; set; }
        public string caracteristicas_articulosagroquimicos { get; set; }
        public DateTime? fechavencimiento_articulosagroquimicos { get; set; }
        public int? fk_id_marca_articulosagroquimicos { get; set; }
    }
}
