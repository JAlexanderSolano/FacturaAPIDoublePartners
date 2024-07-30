using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Control
    {
        public DataTable ObetenerProducto()
        {
            string Query = String.Format("select * from CatProductos");
            DataTable tblReult = Conexion.Consultar(Query);
            return tblReult;
        }

        public DataTable ObtenerCliente()
        {
            string Query = String.Format("select id, RazonSocial from TblClientes");
            DataTable tblReult = Conexion.Consultar(Query);
            return tblReult;
        }

        public DataTable ObtenerTipoCliente() 
        {
            string Query = String.Format("select * from CatTipoCliente");
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
