using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Control:IControl
    {
        public string Id { get; set; }
        public string TipoCliente { get; set; }

        public Control() { }

        public Control(string id, string tipoCliente)
        {
            Id = id;
            TipoCliente = tipoCliente;
        }


        public List<Control> RetornarResultado(DataTable tbl)
        {
            List<Control> list = new List<Control>();
            string _Id = "", _TipoCliente = "";
            if(tbl.Rows.Count > 0)
            {
                foreach(DataRow fila in tbl.Rows)
                {
                    _Id = fila["Id"].ToString();
                    _TipoCliente = fila["TipoCliente"].ToString();
                    list.Add(new Control(_Id, _TipoCliente) { });
                }
            }
            return list;
        }
    }
}
