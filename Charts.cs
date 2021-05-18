using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
     public class Charts
    {
        public string label { get; set; }
        public int value { get; set; }
        

        public Charts(string label, int value)
        {
            this.label = label;
            this.value = value;
        }
    }

}
