using CAPA_NEGOCIO.Models;
using CAPA_NEGOCIO.security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UICOODEPAGRO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        public CargoController()
        {
            AuthNetCore.loginIN("admin", "admin");
            //aca hay que insertar las validaciones de ussuarios 
        }

        [HttpGet]
        public object GetCargos()
        {
            var tbl_cargo = new Tbl_Cargo().Get<Tbl_Cargo>();
            return tbl_cargo;
        }

        [HttpPost]
        public object SaveCargo(Tbl_Cargo newCargo)
        {
            return newCargo.id_cargo = (int)newCargo.Save();
        }

    }
}
