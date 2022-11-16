using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        public ProveedorController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetProveedor()
        {
            var obj = from Tbl_Proveedores in new Tbl_Proveedores().Get<Tbl_Proveedores>()
                      select new
                      {
                          IdProveedor = Tbl_Proveedores.id_proveedor,
                          NombreProveedor = Tbl_Proveedores.nombre_proveedor,
                          TelefonoProveedor = Tbl_Proveedores.telefono_proveedor,
                          CorreoProveedor = Tbl_Proveedores.correo_proveedor
                      };
            return obj;
        }

        [HttpPost]
        public object SaveProveedor(Tbl_Proveedores newProveedor)
        {
            return newProveedor.id_proveedor = (int)newProveedor.Save();
        }
    }
}
