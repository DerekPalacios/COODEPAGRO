using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CAPA_NEGOCIO.Models;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtAgroController : ControllerBase
    {
        public ArtAgroController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }
        [HttpGet]
        public object GetArtAgro()
        {
            var obj = from Tbl_ArticulosAgroquimicos in new Tbl_ArticulosAgroquimicos().Get<Tbl_ArticulosAgroquimicos>()
                      select new
                      {
                          IdArtAgro = Tbl_ArticulosAgroquimicos.id_articulosagroquimicos,
                          IdArticulo = Tbl_ArticulosAgroquimicos.fk_id_articulos_agroquimicos,
                          PresentacionArtAgro = Tbl_ArticulosAgroquimicos.presentacion_articulosagroquimicos,
                          UMedidaArtAgro = Tbl_ArticulosAgroquimicos.unidaddemedida_articulosagroquimicos,
                          PrecioArtAgro = Tbl_ArticulosAgroquimicos.precio_articulosagroquimicos,
                          CaracteristicasArtAgro = Tbl_ArticulosAgroquimicos.caracteristicas_articulosagroquimicos,
                          FechaArtAgro = Tbl_ArticulosAgroquimicos.fechavencimiento_articulosagroquimicos,
                          IdMarcaArtAgro = Tbl_ArticulosAgroquimicos.fk_id_marca_articulosagroquimicos
                      };
            return obj;
        }

        [HttpPost]
        public object SaveArtAgro(Tbl_ArticulosAgroquimicos newArtAgro)
        {
            return newArtAgro.id_articulosagroquimicos = (int)newArtAgro.Save();
        }

    }
}
