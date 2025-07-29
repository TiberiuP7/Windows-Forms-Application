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
    public partial class EditForm : Form
    {
        private Pariuri pariu;
        public EditForm(Pariuri pariu)
        {
            InitializeComponent();

            this.pariu = pariu;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbSelectie.Text = pariu.Selectie;
            tbOra.Value = (DateTime)pariu.OraPariu;
            tbSumaPariata.Text = pariu.SumaPariata.ToString("F2"); // Formateaza suma ca numar cu 2 zecimale
            tbCota.Text = pariu.Cota.ToString("F2"); // Formateaza cota ca numar cu 2 zecimale
            cbMeci.Text = pariu.Meci; 
        }
        //tbSumaPariata si tbCota sa accepte doar valori numerice decimale
        private void tbSumaPariata_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits and one decimal separator
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || ((sender as TextBox).Text.Contains('.'))))
                e.Handled = true;
        }

        private void tbCota_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits and one decimal separator
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || ((sender as TextBox).Text.Contains('.'))))
                e.Handled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            pariu.Selectie = tbSelectie.Text;
            pariu.OraPariu = tbOra.Value;
            pariu.SumaPariata = decimal.Parse(tbSumaPariata.Text);
            pariu.Cota = decimal.Parse(tbCota.Text);
            pariu.Meci = cbMeci.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); // Inchide formularul fara a salva modificarile
        }
    }
}
