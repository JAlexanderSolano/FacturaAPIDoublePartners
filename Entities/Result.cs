using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Result:IResult
    {
        public string result { get; set; }
        public Result() { }

        public Result(string result)
        {
            this.result = result;
        }

        public List<Result> RetornarResultado(DataTable tbl)
        {
            List<Result> list = new List<Result>();
            string _result = "";
            if (tbl.Rows.Count > 0)
            {
                foreach (DataRow fila in tbl.Rows)
                {
                    _result = fila["result"].ToString();
                    list.Add(new Result(_result) { });
                }
            }
            return list;
        }
    }
}
