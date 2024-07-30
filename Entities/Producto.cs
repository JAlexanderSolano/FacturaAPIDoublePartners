using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Producto:IProducto
    {
        public string Id { get; set; }
        public string NombreProducto { get; set; }

        public Producto() { }

        public Producto(string id, string nombreProducto)
        {
            Id = id;
            NombreProducto = nombreProducto;
        }

        public List<Producto> RetornarResultadoProducto(DataTable tbl)
        {
            List<Producto> list = new List<Producto>();
            string _id = "", _nombreProducto = "";
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow fila in tbl.Rows)
                {
                    _id = fila["Id"].ToString();
                    _nombreProducto = fila["NombreProducto"].ToString();
                    list.Add(new Producto(_id, _nombreProducto) { });
                }
            }
            return list;
        }
    }
}
