using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Relationships
{
    public class Department
    {
    }

    /// <summary>
    /// Aggregation
    /// weak
    /// has a
    /// </summary>
    public class university
    {
        public List<Department> Departments { get; set; }
    }
}
