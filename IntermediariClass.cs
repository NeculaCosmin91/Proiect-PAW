using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class IntermediariClass
    {
        public long Id { get; set; }
        public int Position { get; set; }
        public string Intermadiary { get; set; }
        public int Value { get; set; }

        public IntermediariClass(long id, int position, string intermadiary, int value)
        {
            Id = id;
            Position = position;
            Intermadiary = intermadiary;
            Value = value;
        }
    }
}
