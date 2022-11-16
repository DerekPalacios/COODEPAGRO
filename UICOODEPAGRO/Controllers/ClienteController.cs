using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetCliente()
        {
            var obj = from Tbl_Cliente in new Tbl_Cliente().Get<Tbl_Cliente>()
                      select new
                      {
                          IdCliente = Tbl_Cliente.id_cliente,
                          NombreCliente = Tbl_Cliente.nombre_cliente,
                          ApellidoCliente = Tbl_Cliente.apellido_cliente,
                          NumeroCliente = Tbl_Cliente.numero_celular,
                          CorreoCliente = Tbl_Cliente.correo_clientes
                      };
            return obj;
        }
        [HttpPost]
        public object SaveCliente(Tbl_Cliente newCliente)
        {
            return newCliente.id_cliente = (int)newCliente.Save();
        }

    }
}
