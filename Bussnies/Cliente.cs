using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class Cliente
    {
        public DataTable RegistrarCliente(int? parametro, int? idCliente, string razonSocial, int? idTipoCliente)
        {
            Data.Cliente _cliente = new Data.Cliente();
            DataTable tblResult = _cliente.RegistrarCliente(parametro, idCliente, razonSocial, idTipoCliente);
            return tblResult;
        }
    }
}
