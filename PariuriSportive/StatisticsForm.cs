using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PariuriSportive.Model;

namespace PariuriSportive
{
    public partial class StatisticsForm : Form
    {
        private List<Pariuri> pariuri;
        private ScatterChartControl scatterChartControl;
        public StatisticsForm(List<Pariuri> pariuri)
        {
            InitializeComponent();

            var chart = new ScatterChartControl
            {
                Location = new Point(10, 10),
                Size = new Size(600, 400)
            };

            chart.UpdateData(pariuri);
            this.Controls.Add(chart);
        }

        private void StatisticsForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
