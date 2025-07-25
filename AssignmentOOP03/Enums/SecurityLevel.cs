using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03.Enums
{
    [Flags]
    public enum SecurityLevel:byte
    {
        guest=1,
        Developer=2,
        secretary=4 ,
        DBA=8
    }
}
