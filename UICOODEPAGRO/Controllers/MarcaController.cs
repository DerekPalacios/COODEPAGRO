using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        public MarcaController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetMarca()
        {
            var tbl_marca = new Tbl_Marca().Get<Tbl_Marca>();
            return tbl_marca;
        }
        [HttpPost]
        public object SaveMarca(Tbl_Marca newMarca)
        {
            return newMarca.id_marca = (int)newMarca.Save();
        }
    }
}
