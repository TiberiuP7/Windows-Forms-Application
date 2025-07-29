using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PariuriSportive.Model;

namespace PariuriSportiveLibrary
{
    public partial class BetFilter : System.Windows.Forms.UserControl
    {
        /* //public List<Pariuri> pariuri = new();

         public ScatterChart()
         {
             InitializeComponent();

             this.DoubleBuffered = true;
             this.ResizeRedraw = true;
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

             foreach (var pariu in pariuri)
             {
                 float xRatio = (float)(pariu.SumaPariata / maxSuma);
                 float yRatio = (float)(pariu.PosibilCastig / maxProfit);

                 int x = margin + (int)(xRatio * chartWidth);
                 int y = Height - margin - (int)(yRatio * chartHeight);

                 g.FillEllipse(Brushes.Red, x - 4, y - 4, 8, 8);
             }

             // Labels  
             g.DrawString("Miza (SumaPariata)", Font, Brushes.Black, new PointF(Width / 2 - 40, Height - 30));
             g.TranslateTransform(10, Height / 2);
             g.RotateTransform(-90);
             g.DrawString("Profit (PosibilCastig)", Font, Brushes.Black, new PointF(0, 0));
             g.ResetTransform();
         }
     }*/
    }

}
