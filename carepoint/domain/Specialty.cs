using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    public class Specialty
    {
        public int id { get; private set; }
        public string name { get; private set; }

        public Specialty(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
