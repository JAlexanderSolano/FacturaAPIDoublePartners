﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IProducto
    {
        List<Entities.Producto> RetornarResultadoProducto(DataTable tbl);
    }
}
