using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary_for_home_Desk_ver.C.Models
{
    public class StoredProcedure3
    {
        public int IdTypeStock { get; set; }
        public string TypeStockName { get; set; } = null!;


        public override string ToString()
        {
            return $"{TypeStockName}";
        }
    }
}
