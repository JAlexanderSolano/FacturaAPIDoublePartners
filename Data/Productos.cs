using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Productos
    {
        public DataTable Guardar_Producto(string nombreProducto, string imagenProducto, string precioUnitatio, int ext)
        {
            string Query = String.Format("exec [dbo].[sp_GuardarProducto] '{0}', '{1}', '{2}', {3}", nombreProducto, imagenProducto, precioUnitatio, ext);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
