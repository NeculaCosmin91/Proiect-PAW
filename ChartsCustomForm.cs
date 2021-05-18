using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class ChartsCustomForm : Control
    {
        private Charts[] data;
        public Charts[] Data
        {
            get { return data; }
            set { data = value; }
        }
        public ChartsCustomForm()
        {
            ResizeRedraw = true;
            InitializeComponent();

            Data = new[]
            {
                new Charts("April", 30)
            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
