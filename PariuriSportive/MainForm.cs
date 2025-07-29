using PariuriSportive.Model;
using PariuriSportiveLibrary;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Xml.Serialization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PariuriSportive
{
    public partial class MainForm : Form
    {
        private List<Pariuri> pariuri;
        private List<Meciuri> meciuri = new List<Meciuri>();
        private static readonly string ConnectionString = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\database.db")}"; //"Data Source=database.db"; // Connection string for SQLite database

        private int currentY = 40;
        public MainForm()
        {
            pariuri = new List<Pariuri>();
            InitializeComponent();
            LoadMatches(); // Incarca meciurile din baza de date la deschiderea formularului
            //cbMeci.DisplayMember = "NumeEchipa1" + "-" + "NumeEchipa2"; // Seteaza ce sa afiseze ComboBox-ul pentru meciuri
            cbMeci.DataSource = null; // Reset the DataSource to avoid issues with ComboBox
            cbMeci.DataSource = meciuri; // Seteaza DataSource pentru ComboBox-ul cu meciuri


        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //DeserializeXML();
            LoadPariuri(); // Incarca pariurile din baza de date la deschiderea formularului
            DisplayPariuri(); // Afiseaza pariurile în ListView

            var filterControl = new BetFilterControl();
            filterControl.FilterApplied += ApplyBetFilter; // Aboneaza-te la evenimentul de aplicare a filtrului
            //filterControl.Dock = DockStyle.Bottom; // Other options: Bottom, Left, Right, Fill, None
            this.panel1.Controls.Add(filterControl);
        }


        private void ApplyBetFilter(BetFilterControl.BetFilter filter)
        {
            // Clear the current list of displayed bets
            lvPariuri.Items.Clear();

            // Filter the bets based on the criteria provided in the filter
            var filteredPariuri = pariuri.Where(pariu =>
                pariu.Cota >= filter.Cota &&
                pariu.OraPariu >= filter.DeLa &&
                pariu.OraPariu <= filter.PanaLa &&
                pariu.SumaPariata >= filter.SumaMinima).ToList();

            foreach (var pariu in filteredPariuri)
            {
                var listViewItem = new ListViewItem(pariu.Selectie);
                listViewItem.SubItems.Add(pariu.OraPariu.ToString());
                listViewItem.SubItems.Add(pariu.Cota.ToString());
                listViewItem.SubItems.Add(pariu.SumaPariata.ToString());
                listViewItem.SubItems.Add(pariu.PosibilCastig.ToString());
                listViewItem.SubItems.Add(pariu.Meci);

                listViewItem.Tag = pariu; // Set the tag to the Pariuri object for later reference
                lvPariuri.Items.Add(listViewItem);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddBet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {

                    string selectie = tbSelectie.Text;
                    DateTime oraPariu = tbOra.Value;
                    decimal sumaPariata = decimal.Parse(tbSumaPariata.Text);
                    decimal cota = decimal.Parse(tbCota.Text);

                    string meci = cbMeci.Text; // Presupunem ca meciul este selectat dintr-un ComboBox sau similar

                    var pariu = new Pariuri(selectie, oraPariu, sumaPariata, cota, meci); // ID-ul este 0 pentru ca nu este setat inca
                    AddPariuri(pariu); // Adaugam pariul in baza de date si in lista

                    //ListViewItem listviewitem = new ListViewItem(selectie);
                    //oraPariu.ToShortTimeString();
                    //lvPariuri.Items.Add(listviewitem);
                    DisplayPariuri();
                }
                else
                {
                    MessageBox.Show(
                        "Please fill in all required fields correctly.",
                        "Eroare la adaugarea pariului",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (InvalidKickoffTimeException ex)
            {
                MessageBox.Show(string.Format("The bet time {0} can't be in the past.", ex.Kickoff));
            }
            catch (SQLiteException ex)
            {
                // Handle database-related exceptions
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*catch (Exception)
            {
                //UnExpected exception
                MessageBox.Show("An exception has been encountered! Please contact the technical support.");
            }*/
            catch (Exception ex)
            {
                // Handle unexpected exceptions
                MessageBox.Show($"An unexpected error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Debug.WriteLine("Always executed");
            }
        }

        private void DisplayPariuri()
        {
            lvPariuri.Items.Clear();

            foreach (var pariu in pariuri)
            {
                var listViewItem = new ListViewItem(pariu.Selectie);
                listViewItem.SubItems.Add(pariu.OraPariu.ToString());
                listViewItem.SubItems.Add(pariu.Cota.ToString());
                listViewItem.SubItems.Add(pariu.SumaPariata.ToString());
                listViewItem.SubItems.Add(pariu.PosibilCastig.ToString());
                listViewItem.SubItems.Add(pariu.Meci);

                listViewItem.Tag = pariu;

                lvPariuri.Items.Add(listViewItem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbSelectie_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbSelectie.Text.Trim().Length < 3)
            {
                errorProvider.SetError(tbSelectie, "Selectia trebuie sa aiba cel putin 3 caractere.");
                e.Cancel = true; // Previi inchiderea formularului daca validarea esueaza
            }
        }

        private void tbSelectie_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbSelectie, string.Empty); // Stergi mesajul de eroare daca validarea a reusit
        }

        private void btnSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pariuri>));

            /*FileStream stream = File.Create("SerializedXML.xml");
            try
            {
                serializer.Serialize(stream, pariuri);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la serializare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                stream.Close();
            }
            */

            using (FileStream stream = File.Create("SerializedXML.xml"))
            {
                serializer.Serialize(stream, pariuri);
            }
        }

        private void btnDeserializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pariuri>));

            using (FileStream stream = File.OpenRead("SerializedXML.xml"))
            {
                pariuri = (List<Pariuri>)serializer.Deserialize(stream);
                DisplayPariuri(); // Actualizezi ListView-ul cu datele deserializate
            }
        }

        private void DeserializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pariuri>));

            using (FileStream stream = File.OpenRead("SerializedXML.xml"))
            {
                pariuri = (List<Pariuri>)serializer.Deserialize(stream);
                DisplayPariuri(); // Actualizezi ListView-ul cu datele deserializate
            }

        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Scriem header-ul CSV
                    writer.WriteLine("Selectie,OraPariu,Cota,SumaPariata,PosibilCastig");
                    // Scriem fiecare pariu in format CSV
                    foreach (var pariu in pariuri)
                    {
                        writer.WriteLine($"{pariu.Selectie},{pariu.OraPariu},{pariu.Cota},{pariu.SumaPariata},{pariu.PosibilCastig},{pariu.Meci}");
                    }
                }
                MessageBox.Show("Exportul a fost realizat cu succes!", "Export CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //saveFileDialog.FileName = "ExportedPariuri.csv";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvPariuri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Te rog sa selectezi un pariu pentru a-l sterge.", "Stergere Pariu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Esti sigur ca vrei sa stergi acest pariu?", "Stergere Pariu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvPariuri.SelectedItems[0];

                Pariuri pariu = (Pariuri)listViewItem.Tag; // Obtinerea obiectului Pariuri din ListViewItem
                DeletePariuri(pariu); // Sterge pariu din baza de date si din lista


                DisplayPariuri(); // Actualizeaza ListView-ul pentru a reflecta stergerea
                MessageBox.Show("Pariul a fost sters cu succes!", "Stergere Pariu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvPariuri.SelectedItems.Count == 0)
            {
                MessageBox.Show("Te rog sa selectezi un pariu pentru a-l edita.", "Editare Pariu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem listViewItem = lvPariuri.SelectedItems[0];
            Pariuri pariu = (Pariuri)listViewItem.Tag; // Obtinerea obiectului Pariuri din ListViewItem

            EditForm editForm = new EditForm(pariu); // Presupunem ca EditForm are un constructor care primeste un obiect Pariuri
            if (editForm.ShowDialog() == DialogResult.OK)
                EditPariuri(pariu); // Actualizeaza pariu in baza de date si in lista
            DisplayPariuri();
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

        private void tbSumaPariata_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits and one decimal separator
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || ((sender as TextBox).Text.Contains('.'))))
                e.Handled = true;
        }

        private void LoadPariuri()
        {
            var query = "SELECT * FROM Pariuri";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = (long)reader["Id"];
                            var selectie = (string)reader["Selectie"];
                            var meci = (string)reader["Meci"];
                            var cota = (decimal)reader["Cota"];
                            var oraPariu = DateTime.Parse((string)reader["Data"]);
                            var sumaPariata = (decimal)reader["SumaPariata"];
                            var posibilCastig = (decimal)reader["PosibilCastig"];

                            var pariu = new Pariuri(id, selectie, oraPariu, sumaPariata, cota, meci);
                            pariuri.Add(pariu);
                        }
                    }
                }
            }
        }

        private void AddPariuri(Pariuri pariu)
        {
            var query = "INSERT INTO Pariuri " +
                "(Selectie, Meci, Cota, Data, SumaPariata, PosibilCastig) VALUES (@Selectie, @Meci, @Cota, @OraPariu, @SumaPariata, @PosibilCastig); SELECT last_insert_rowid()";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Selectie", pariu.Selectie);
                    command.Parameters.AddWithValue("@Meci", pariu.Meci);
                    command.Parameters.AddWithValue("@Cota", pariu.Cota);
                    command.Parameters.AddWithValue("@OraPariu", pariu.OraPariu);
                    command.Parameters.AddWithValue("@SumaPariata", pariu.SumaPariata);
                    command.Parameters.AddWithValue("@PosibilCastig", pariu.PosibilCastig);
                    connection.Open();
                    //command.ExecuteNonQuery(); //query care nu intoarce date
                    pariu.Id = (long)command.ExecuteScalar(); // Executa comanda si returneaza ID-ul ultimului pariu inserat
                    pariuri.Add(pariu);
                }

            }
        }

        private void DeletePariuri(Pariuri pariu)
        {
            var query = "DELETE FROM Pariuri WHERE Id = @Id";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", pariu.Id);
                    connection.Open();
                    command.ExecuteNonQuery(); // Executa comanda pentru a sterge pariul
                    pariuri.Remove(pariu); // Sterge pariul din lista
                }
            }
        }

        private void EditPariuri(Pariuri pariu)
        {
            var query = "UPDATE Pariuri SET Selectie = @Selectie, Meci = @Meci, Cota = @Cota, Data = @OraPariu, SumaPariata = @SumaPariata, PosibilCastig = @PosibilCastig WHERE Id = @Id";
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", pariu.Id);
                    command.Parameters.AddWithValue("@Selectie", pariu.Selectie);
                    command.Parameters.AddWithValue("@Meci", pariu.Meci);
                    command.Parameters.AddWithValue("@Cota", pariu.Cota);
                    command.Parameters.AddWithValue("@OraPariu", pariu.OraPariu);
                    command.Parameters.AddWithValue("@SumaPariata", pariu.SumaPariata);
                    command.Parameters.AddWithValue("@PosibilCastig", pariu.PosibilCastig);
                    connection.Open();
                    command.ExecuteNonQuery(); // Executa comanda pentru a actualiza pariul
                }
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadPariuri(); // Asigura-te ca ai incarcat pariurile inainte de a deschide formularul de statistici
            StatisticsForm statisticsForm = new StatisticsForm(pariuri);
            statisticsForm.ShowDialog(); // Deschide formularul de statistici ca dialog modal
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hello, world!", new Font("Arial", 20), Brushes.Black, new PointF(100, 100));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            currentY = 40;
            var document = new PrintDocument();
            document.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("Selectie", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new PointF(20, 20));//coltul de sus al paginii e 0 0?
                ev.Graphics.DrawString("Cota", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new PointF(140, 20));
                ev.Graphics.DrawString("Meci", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new PointF(220, 20));
                ev.Graphics.DrawString("Data", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new PointF(420, 20));
                ev.Graphics.DrawString("Suma Pariata", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new PointF(630, 20));
                ev.Graphics.DrawString("Posibil Castig", new Font("Verdana", 10, FontStyle.Bold), Brushes.Black, new PointF(740, 20));

                foreach (var pariu in pariuri)
                {
                    PrintPariuCurent(ev, pariu);
                }

                ev.HasMorePages = false;
            };
            var dialog = new PrintPreviewDialog()
            {
                Document = document,
                Width = 800,
                Height = 1200
            };
            dialog.ShowDialog();
        }

        private void PrintPariuCurent(PrintPageEventArgs ev, Pariuri pariu)
        {
            ev.Graphics.DrawString(pariu.Selectie, new Font("Verdana", 10), Brushes.Black, new PointF(20, currentY));
            ev.Graphics.DrawString(pariu.Cota.ToString(), new Font("Verdana", 10), Brushes.Black, new PointF(140, currentY));
            ev.Graphics.DrawString(pariu.Meci, new Font("Verdana", 10), Brushes.Black, new PointF(220, currentY));
            ev.Graphics.DrawString(pariu.OraPariu.ToString(), new Font("Verdana", 10), Brushes.Black, new PointF(420, currentY));
            ev.Graphics.DrawString(pariu.SumaPariata.ToString(), new Font("Verdana", 10), Brushes.Black, new PointF(630, currentY));
            ev.Graphics.DrawString(pariu.PosibilCastig.ToString(), new Font("Verdana", 10), Brushes.Black, new PointF(740, currentY));

            currentY += 20;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSelectie.Text))
            {
                Clipboard.SetText(tbSelectie.Text); // Copiaza textul din tbSelectie in clipboard
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                tbSelectie.Text = Clipboard.GetText();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAdaugaMeci_Click(object sender, EventArgs e)
        {
            using (var adaugaMeciForm = new AdaugaMeciForm())
            {
                if (adaugaMeciForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMatches();
                    DisplayPariuri();
                }
                cbMeci.DataSource = null; // Reset the DataSource to avoid issues with ComboBox
                cbMeci.DataSource = meciuri; // Rebind the ComboBox to the updated list of matches
            }

        }

        private void LoadMatches()
        {
            var query = "SELECT * FROM Meciuri";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                using (var command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader["Id"];
                            var numeEchipa1 = (string)reader["NumeEchipa1"];
                            var numeEchipa2 = (string)reader["NumeEchipa2"];
                            var dataMeciului = DateTime.Parse((string)reader["DataMeciului"]);
                            var locatie = (string)reader["Locatie"];
                            var competitie = (string)reader["Competitie"];
                            var stareMeci = (string)reader["StareMeci"];
                            var meci = new Meciuri(id, numeEchipa1, numeEchipa2, dataMeciului, locatie, competitie, stareMeci);
                            meciuri.Add(meci);
                        }
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayPariuri(); // Reafiseaza pariurile in ListView
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://flashscore.ro/",
                UseShellExecute = true // Required for .NET Core and later
            });
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://uefa.com/uefachampionsleague/",
                UseShellExecute = true // Required for .NET Core and later
            });
        }

        private void tbCota_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbCota, string.Empty); // Stergi mesajul de eroare daca validarea a reusit
        }

        private void tbCota_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!decimal.TryParse(tbCota.Text, out decimal cota) || cota <= 0)
            {
                errorProvider.SetError(tbCota, "Introduceti o cota valida.");
                e.Cancel = true; // Previi inchiderea formularului daca validarea esueaza
            }
        }

        private void tbSumaPariata_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbSumaPariata, string.Empty);
        }

        private void tbSumaPariata_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!decimal.TryParse(tbSumaPariata.Text, out decimal suma) || suma <= 0)
            {
                errorProvider.SetError(tbSumaPariata, "Introduceti o suma pariata valida.");
                e.Cancel = true; // Previi inchiderea formularului daca validarea esueaza
            }
        }

        private void cbMeci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbOra_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tbOra.Value.Date < DateTime.Now.Date)
            {
                errorProvider.SetError(tbOra, "The bet time can't be in the past.");
                e.Cancel = true;
            }
        }

        private void tbOra_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbOra, string.Empty);
        }

    }
}