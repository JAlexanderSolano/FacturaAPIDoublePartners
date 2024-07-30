using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Cliente
    {
        public DataTable RegistrarCliente(int? parametro, int? idCliente, string razonSocial, int? idTipoCliente)
        {
            string Query = String.Format("exec [dbo].[sp_CrudClientes] {0}, {1}, '{2}', {3}", parametro, idCliente, razonSocial, idTipoCliente);
            DataTable tblResult = Conexion.Consultar(Query);
            return tblResult;
        }
    }
}
