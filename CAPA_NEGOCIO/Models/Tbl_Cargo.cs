using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO.Models
{
    public class Tbl_Cargo : EntityClass
    {
        public int? id_cargo { get; set; }
        public string nombre_cargo { get; set; }
    }
}
