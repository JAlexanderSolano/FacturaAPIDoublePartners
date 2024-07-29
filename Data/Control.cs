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
        public DataTable ObtenerTipoCliente() 
        {
            string Query = String.Format("select * from CatTipoCliente");
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
