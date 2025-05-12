using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Domain
{
    public class Cattleman
    {
        public required Guid ID { get; set; }
        public required string Name { get; set; }
    }
}
