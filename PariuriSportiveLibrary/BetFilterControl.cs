using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PariuriSportiveLibrary
{
    public partial class BetFilterControl : UserControl
    {
        public class BetFilter
        {
            public decimal Cota { get; set; }
            public DateTime DeLa { get; set; }
            public DateTime PanaLa { get; set; }
            public decimal SumaMinima { get; set; }
        }
        public event Action<BetFilter>? FilterApplied;
        public event Action? FilterCleared;

        /*public void LoadMatches(List<Meciuri> meciuri)
        {
            cbMeci.Items.Clear();
            cbMeci.Items.Add("All");
            cbMeci.DataSource = meciuri;

            cbMeci.SelectedIndex = 0; // Select "All" by default
        }*/

        public BetFilterControl()
        {
            InitializeComponent();
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filter = new BetFilter
            {
                Cota = numMinimumOdds.Value,
                DeLa = dtpFrom.Value,
                PanaLa = dtpTo.Value,
                SumaMinima = numMinimumStake.Value
            };

            FilterApplied?.Invoke(filter);
        }
    }
}
