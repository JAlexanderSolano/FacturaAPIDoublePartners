using Entities;
using FacturaBackend.EntryModels;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacturaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Entities.Interfaces.IResult _IResult;
        public ClienteController(Entities.Interfaces.IResult IResult) 
        {
            _IResult = IResult;
        }

        [HttpPost("[action]")]
        public IActionResult RegistraCliente([FromBody] RegistroCliente reg) 
        {
            try
            {
                List<Entities.Result> results= new List<Entities.Result>();
                Bussnies.Cliente _cliente = new Bussnies.Cliente();
                DataTable tblResult = _cliente.RegistrarCliente(reg.Parametro, reg.IdCliente, reg.RazonSocial, reg.idTipoCliente);
                results = _IResult.RetornarResultado(tblResult);

                return Ok(results);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace + ex.InnerException + ex.Source);
            }
        }
       
    }
}
