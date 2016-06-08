using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameEngine
{
    class Brand
    {
        public Guid PartnerId { get; set; }
        public Guid BrandId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
