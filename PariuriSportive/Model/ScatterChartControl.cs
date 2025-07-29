using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PariuriSportive.Model
{
    public class ScatterChartControl : Control
    {
        public List<Pariuri> pariuri = new();

        public ScatterChartControl()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
        public void UpdateData(List<Pariuri> newPariuri)
        {
            pariuri = newPariuri;
            Invalidate(); // Trigger a repaint
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (pariuri == null || pariuri.Count == 0)
            {
                g.DrawString("No bet data available", Font, Brushes.Gray, new PointF(10, 10));
                return;
            }

            var margin = 50;
            var chartWidth = Width - 2 * margin;
            var chartHeight = Height - 2 * margin;

            var maxSuma = pariuri.Max(b => b.SumaPariata);
            var maxProfit = pariuri.Max(b => b.PosibilCastig);

            // Draw axes  
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, margin, Height - margin, Width - margin, Height - margin); // X-axis  
            g.DrawLine(axisPen, margin, Height - margin, margin, margin); // Y-axis  

            

            /*//Horinzontal grid lines
            for (int i = 0; i <= maxProfit; i += 50)
            {
                decimal scaleY = Width / maxSuma;
                float y = (float)(Height - i * scaleY);
                g.DrawLine(Pens.LightGray, margin, y - margin,  Width - margin, y - margin);
                g.DrawString(i.ToString(), this.Font, Brushes.Gray, 0, y - 10);
            }*/

            foreach (var pariu in pariuri)
            {
                float xRatio = (float)(pariu.SumaPariata / maxSuma);
                float yRatio = (float)(pariu.PosibilCastig / maxProfit);

                int x = margin + (int)(xRatio * chartWidth);
                int y = Height - margin - (int)(yRatio * chartHeight);

                //g.DrawLine(Pens.Red, margin, y, x, y);

                g.FillEllipse(Brushes.Red, x - 4, y - 4, 8, 8);
            }

            // Labels  
            g.DrawString("Miza (Suma pariata)", Font, Brushes.Black, new PointF(Width / 2 - 40, Height - 30));
            g.TranslateTransform(10, Height / 2);
            g.RotateTransform(-90);
            g.DrawString("Profit (Posibil castig)", Font, Brushes.Black, new PointF(0, 0));
            g.ResetTransform();
        }
    }

}
