using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class Cliente: ICliente
    {
        public string IdCliente { get; set; }
        public string RazonSocial { get; set; }

        public Cliente() { }

        public Cliente(string idCliente, string razonSocial)
        {
            IdCliente = idCliente;
            RazonSocial = razonSocial;
        }

        public List<Cliente> RetornarResultadoCliente(DataTable tbl)
        {
            List<Cliente> list = new List<Cliente>();
            string _id = "", _razonSocial = "";
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow fila in tbl.Rows)
                {
                    _id = fila["id"].ToString();
                    _razonSocial = fila["RazonSocial"].ToString();
                    list.Add(new Cliente(_id, _razonSocial) { });
                }
            }
            return list;
        }

    }
}
