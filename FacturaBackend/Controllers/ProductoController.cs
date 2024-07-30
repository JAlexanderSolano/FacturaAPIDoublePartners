using Entities.Interfaces;
using FacturaBackend.EntryModels;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq.Expressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacturaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly Entities.Interfaces.IResult _IResult;

        public ProductoController(Entities.Interfaces.IResult result)
        {
            _IResult = result;
        }
        // POST api/<ProductoController>
        [HttpPost("[action]")]
        public IActionResult GuardarProducto([FromBody] RegistroProducto prod)
        {
            try
            {
                List<Entities.Result> result = new List<Entities.Result>();
                Bussnies.Productos _productos = new Bussnies.Productos();
                DataTable tblResult = _productos.Guardar_Producto(prod.nombreProducto, prod.ImagenProducto, prod.PrecioUnitario, prod.ext);
                result = _IResult.RetornarResultado(tblResult);
                return Ok(result);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message + ex.Source + ex.InnerException);
            }
        }
    }
}
