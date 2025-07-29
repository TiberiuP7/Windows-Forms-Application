using PariuriSportive.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PariuriSportive
{
    public partial class AdaugaMeciForm : Form
    {
        private List<Meciuri> meciuri;
        private const string ConnectionString = "Data Source=database.db"; // Connection string for SQLite database
        public AdaugaMeciForm()
        {
            meciuri = new List<Meciuri>();
            InitializeComponent();
            cbStareMeci.Items.Add(StareMeciEnum.InDesfasurare);
            cbStareMeci.Items.Add(StareMeciEnum.Finalizat);
            cbStareMeci.Items.Add(StareMeciEnum.Anulat);
        }

        private void AddMatch(Meciuri meci)
        {
            var query = "INSERT INTO Meciuri " +
                        "(NumeEchipa1, NumeEchipa2, DataMeciului, Locatie, Competitie, StareMeci) VALUES (@NumeEchipa1, @NumeEchipa2, @DataMeciului, @Locatie, @Competitie, @StareMeci); " +
                        "SELECT last_insert_rowid()";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeEchipa1", meci.NumeEchipa1);
                    command.Parameters.AddWithValue("@NumeEchipa2", meci.NumeEchipa2);
                    command.Parameters.AddWithValue("@DataMeciului", meci.dataMeciului);
                    command.Parameters.AddWithValue("@Locatie", meci.Locatie);
                    command.Parameters.AddWithValue("@Competitie", meci.Competitie);
                    command.Parameters.AddWithValue("@StareMeci", meci.StareMeci);

                    connection.Open();
                    //command.ExecuteNonQuery(); //query care nu intoarce date
                    meci.Id = (long)command.ExecuteScalar(); // Executa comanda si returneaza ID-ul ultimului pariu inserat
                    //command.ExecuteNonQuery();
                    meciuri.Add(meci);
                }
            }
        }

        private void btnAdaugaMeci_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    string numeEchipa1 = tbGazda.Text.Trim();
                    string numeEchipa2 = tbOaspeti.Text.Trim();
                    DateTime dataMeciului = dtData.Value;
                    string locatie = tbStadion.Text.Trim();
                    string competitie = tbCompetitie.Text.Trim();

                    // Explicitly cast the selected item to StareMeciEnum
                    if (cbStareMeci.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a match status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string stareMeci = cbStareMeci.Text;

                    var meci = new Meciuri(numeEchipa2, numeEchipa1, dataMeciului, locatie, competitie, stareMeci)
                    {
                        NumeEchipa1 = numeEchipa1,
                        NumeEchipa2 = numeEchipa2,
                        dataMeciului = dataMeciului,
                        Locatie = locatie,
                        Competitie = competitie,
                        StareMeci = stareMeci
                    };
                    AddMatch(meci);

                    this.DialogResult = DialogResult.OK; // Set the dialog result to OK
                    this.Close(); // Close the form after successful addition
                }
                else
                {
                    MessageBox.Show(
                        "Please fill in all required fields correctly.",
                        "Eroare la adaugarea meciului",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (InvalidKickoffTimeException ex)
            {
                MessageBox.Show(string.Format("The kick off time {0} can't be in the past.", ex.Kickoff));
            }
            catch (SQLiteException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*catch (Exception)
            {
                // Unexpected exception
                MessageBox.Show("An exception has been encountered! Please contact the technical support.");
            }*/
            catch (Exception ex)
            {
                // Handle unexpected exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Debug.WriteLine("Always executed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); // Close the form without saving
        }
    }
}