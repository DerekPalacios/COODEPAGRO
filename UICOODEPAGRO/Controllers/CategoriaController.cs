using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        public CategoriaController()
        {

            //aca hay que insertar las validaciones de ussuarios 

            AuthNetCore.loginIN("admin", "admin");
        }
        [HttpGet]

        public object GetCategorias()
        {
            var tbl_categoria = new Tbl_Categoria().Get<Tbl_Categoria>();
            return tbl_categoria;
            
        }
        [HttpPost]
        public object SaveCategorias(Tbl_Categoria newCat)
        {
            return newCat.id_categoria = (int) newCat.Save();

        }


    }
}
