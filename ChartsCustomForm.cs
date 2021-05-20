using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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

            //get the drawing context
            Graphics graphics = pe.Graphics;
            //get the drawing area
            
            Rectangle clipRectangle = pe.ClipRectangle;

            //determine the width of the bars
            var barWidth = clipRectangle.Width / Data.Length;
            //compute the maximum bar height
            var maxBarHeight = clipRectangle.Height * 0.9;
            //compute the scaling factor based on the maximum value that we want to represent
            var scalingFactor = maxBarHeight / Data.Max(x => x.value);

            Brush redBrush = new SolidBrush(Color.Red);

            for (int i = 0; i < Data.Length; i++)
            {
                var barHeight = Data[i].value * scalingFactor;

                graphics.FillRectangle(
                    redBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);
            }
        }
    }
}
