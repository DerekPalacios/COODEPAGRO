using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        public InventarioController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetInventario()
        {
            var obj = from Tbl_Inventario in new Tbl_Inventario().Get<Tbl_Inventario>()
                      select new
                      {
                          IdInventario = Tbl_Inventario.id_inventario,
                          IdArticulo = Tbl_Inventario.fk_articulo_inventario,
                          CantidadInventario = Tbl_Inventario.cantidad
                      };
            return obj;
        }
        [HttpPost]
        public object SaveInventario(Tbl_Inventario newInventario)
        {
            return newInventario.id_inventario = (int)newInventario.Save();
        }
    }
}
