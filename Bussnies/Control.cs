using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class Control
    {
        public DataTable ObtenerTipoCliente()
        {
            Data.Control _control = new Data.Control();
            DataTable tblResult = _control.ObtenerTipoCliente();
            return tblResult;
        }
    }
}
