using Entities;
using Entities.Interfaces;
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
        private readonly ICliente _ICliente;
        private readonly IProducto _IProducto;
        public ControlController(IControl control, ICliente cliente, IProducto producto)
        {
            _IControl = control;
            _ICliente = cliente;
            _IProducto = producto;
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

        [HttpGet("[action]")]
        public IActionResult Cliente()
        {
            try
            {

                List<Entities.Cliente> lsCliente = new List<Cliente>();
                Bussnies.Control control = new Bussnies.Control();
                DataTable tblResult = control.ObetenerCliente();
                lsCliente = _ICliente.RetornarResultadoCliente(tblResult);
                return Ok(lsCliente);



            }catch(Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace + ex.InnerException);
            }
        }

        [HttpGet("[action]")]
        public IActionResult Producto()
        {
            try
            {
                List<Entities.Producto> lsCliente = new List<Producto>();
                Bussnies.Control control = new Bussnies.Control();
                DataTable tblResult = control.ObetenerProducto();
                lsCliente = _IProducto.RetornarResultadoProducto(tblResult);
                return Ok(lsCliente);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message + ex.StackTrace + ex.InnerException);
            }
        }
    }
}
