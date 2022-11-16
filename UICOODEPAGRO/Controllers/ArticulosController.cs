using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        public ArticulosController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetArticulos()
        {
            var obj = from Tbl_Articulos in new Tbl_Articulos().Get<Tbl_Articulos>()
                      select new
                      {
                          IdArticulo = Tbl_Articulos.id_articulos,
                          NombreArtiiculo = Tbl_Articulos.nombre_articulo,
                          DescripcionArticulo = Tbl_Articulos.descripcion_articulo,
                          IdCategoriaArticulo = Tbl_Articulos.fk_id_categoria_articulo
                      };
            return obj;
                    
            
        }
        [HttpPost]
        public object SaveArticulo(Tbl_Articulos newArt)
        {
            return newArt.id_articulos = (int)newArt.Save();
        }

    }
}
