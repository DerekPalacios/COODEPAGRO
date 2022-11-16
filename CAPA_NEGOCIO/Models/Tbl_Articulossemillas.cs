using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Articulossemillas : EntityClass
    {
        public int? id_articulossemillas { get; set; }
        public int? fk_id_articulos_semillas { get; set; }
        public string presentacion_articulossemillas { get; set; }
        public string unidaddemedida_articulossemillas { get; set; }
        public string? precio_articulossemillas { get; set; }
        public string caracteristicas_articulossemillas { get; set; }
        public int? fk_id_marca_articulossemillas { get; set; }
    }

}
