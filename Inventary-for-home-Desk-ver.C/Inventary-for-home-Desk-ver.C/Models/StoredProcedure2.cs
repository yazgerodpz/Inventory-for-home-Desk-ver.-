using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary_for_home_Desk_ver.C.Models
{
    public class StoredProcedure2
    {
        public int IdTypePrioritary { get; set; }

        public string TypePrioritaryName { get; set; } = null!;

        public string Description { get; set; } = null!;

        //Conversion de objeto a texto para el listbox
        public override string ToString()
        {
            return $"{TypePrioritaryName}: {Description}";
        }
    }
}
