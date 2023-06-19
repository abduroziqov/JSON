using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace JSON
{
    internal class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

       public List<Car> Cars { get; set; }
    }
}
