using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtVariosController : ControllerBase
    {
        public ArtVariosController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetArtVarios()
        {
            var obj = from Tbl_ArticulosVarios in new Tbl_ArticulosVarios().Get<Tbl_ArticulosVarios>()
                      select new
                      {
                          IdArtVarios = Tbl_ArticulosVarios.id_articulosvarios,
                          IdArticulo = Tbl_ArticulosVarios.fk_id_articulos_varios,
                          PresentacioArtVarios = Tbl_ArticulosVarios.presentacion_articulosvarios,
                          PrecioArtVarios = Tbl_ArticulosVarios.precio_articulosvarios,
                          UMedidaArtVarios = Tbl_ArticulosVarios.unidaddemedida_articulosvarios,
                          CaracteristicasArtVarios = Tbl_ArticulosVarios.caracteristicas_articulosvarios,
                          IdMarcaArtVarios = Tbl_ArticulosVarios.fk_id_marca_articulosvarios
                      };
            return obj;

        }

        [HttpPost]
        public object SaveArtVarios(Tbl_ArticulosVarios newArtVario)
        {
            return newArtVario.id_articulosvarios = (int)newArtVario.Save();
        }


    }
}
