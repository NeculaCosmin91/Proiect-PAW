using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Consultanti
    {
        public long id { get; set; }
        public string Institution { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Consultanti(long id, string institution, string name, string surname, int phone, string email)
        {
            this.id = id;
            Institution = institution;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
        }
    }
}
