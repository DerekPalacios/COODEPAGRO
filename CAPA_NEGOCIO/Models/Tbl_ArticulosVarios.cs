using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_ArticulosVarios : EntityClass
    {
        public int? id_articulosvarios { get; set; }
        public int? fk_id_articulos_varios { get; set; }
        public string presentacion_articulosvarios { get; set; }
        public string? precio_articulosvarios { get; set; }
        public string unidaddemedida_articulosvarios { get; set; }
        public string caracteristicas_articulosvarios { get; set; }
        public int? fk_id_marca_articulosvarios { get; set; }
    }
}
