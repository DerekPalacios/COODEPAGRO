using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Personal : EntityClass
    {
        public int? id_personal { get; set; }
        public string primernombre_personal { get; set; }
        public string sergundonombre_personal { get; set; }
        public string primerapellido_personal { get; set; }
        public string segundoapellido_personal { get; set; }
        public int? fk_id_cargo_personal { get; set; }
        public string telefono_personal { get; set; }
        public string correo_personal { get; set; }
        public string usuario_personal { get; set; }
        public string contraseña_personal { get; set; }
    }
}
