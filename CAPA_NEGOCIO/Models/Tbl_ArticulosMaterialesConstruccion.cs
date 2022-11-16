using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_ArticulosMaterialesConstruccion : EntityClass
    {
        public int? id_articulosConstruccion { get; set; }
        public int? fk_id_articulos_Construccion { get; set; }
        public string presentacion_articulosConstruccion { get; set; }
        public string? precio_articulosConstruccion { get; set; }
        public DateTime? fecha_vencimiento { get; set; }
        public string caracteristicas_articulosConstruccion { get; set; }
        public int? fk_id_marca_articulosConstruccion { get; set; }
    }
}
