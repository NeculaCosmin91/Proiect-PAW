using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{ 
    [Serializable]
    public class Shares
    {
        
        public long Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Company { get; set;}

        public Shares(string name, float price, string company)
        {
            Name = name;
            Price = price;
            Company = company;
        }

        public Shares(long id, string name, float price, string company)
            :this(name, price, company)
        {
            Id = id;

        }
    }


}

