using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IControl
    {
        List<Entities.Control> RetornarResultado(DataTable tbl);
    }
}
