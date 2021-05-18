using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proiect_PAW
{
    [Serializable]
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Serial { get; set; }
        public int Number { get; set; }

        public Customer(string name, string surname, string serial, int number)
        {
            Name = name;
            Surname = surname;
            Serial = serial;
            Number = number;
        }

        public Customer(long id, string name, string surname, string serial, int number)
            :this(name, surname, serial, number)
        {
            Id = id;
        }
    }
}
