using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacturaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlController : ControllerBase
    {
        private readonly IControl _IControl;
        public ControlController(IControl control)
        {
            _IControl = control;
        }
        [HttpGet]
        public IActionResult TipoCliente()
        {
            try
            {
                List<Entities.Control> lsControl = new List<Entities.Control>();
                Bussnies.Control _control = new Bussnies.Control();
                DataTable tblReult = _control.ObtenerTipoCliente();
                lsControl = _IControl.RetornarResultado(tblReult);
                return Ok(lsControl);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace + ex.Source);
            }
        }
    }
}
