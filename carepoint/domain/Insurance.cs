using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    public class Insurance
    {
        public int id { get; private set; }
        public string name { get; set; }

        public string address { get; set; }

        public Insurance(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
