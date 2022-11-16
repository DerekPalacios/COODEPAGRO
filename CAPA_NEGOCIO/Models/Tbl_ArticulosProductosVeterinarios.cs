using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_ArticulosProductosVeterinarios : EntityClass
    {
        public int? id_articulosveterinarios { get; set; }
        public int? fk_id_articulos_veterinarios { get; set; }
        public string presentacion_articulosveterinarios { get; set; }
        public string? precio_articulosveterinarios { get; set; }
        public DateTime? fecha_vencimiento { get; set; }
        public string caracteristicas_articulosveterinarios { get; set; }
        public int? fk_id_marca_articulosveterinarios { get; set; }
    }
}
