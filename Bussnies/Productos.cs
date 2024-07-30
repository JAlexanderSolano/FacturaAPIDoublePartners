using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class Productos
    {
        public DataTable Guardar_Producto(string nombreProducto, string imagenProducto, string precioUnitatio, int ext)
        {
            Data.Productos _productos = new Data.Productos();
            DataTable tblResult = _productos.Guardar_Producto(nombreProducto, imagenProducto, precioUnitatio, ext);
            return tblResult;
        }
    }
}
