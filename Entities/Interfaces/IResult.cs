﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IResult
    {
        List<Entities.Result> RetornarResultado(DataTable tbl);
    }
}
