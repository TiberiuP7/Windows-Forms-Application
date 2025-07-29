namespace PariuriSportive
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnPaste = new Button();
            btnCopy = new Button();
            cbMeci = new ComboBox();
            label5 = new Label();
            tbCota = new TextBox();
            tbSumaPariata = new TextBox();
            label4 = new Label();
            btnAddBet = new Button();
            tbOra = new DateTimePicker();
            label3 = new Label();
            tbSelectie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbMeci = new TextBox();
            lvPariuri = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            contextMenuStrip = new ContextMenuStrip(components);
            editToolStripMenu = new ToolStripMenuItem();
            deleteToolStripMenu = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            btnEdit = new Button();
            btnDelete = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printDialog = new PrintDialog();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            btnAdaugaMeci = new Button();
            panel1 = new Panel();
            xMLSerializationToolStripMenuItem = new ToolStripMenuItem();
            btnSerializeXML = new ToolStripMenuItem();
            btnDeserializeXML = new ToolStripMenuItem();
            btnExportToCSV = new ToolStripMenuItem();
            btnStatistics = new ToolStripMenuItem();
            btnPrint = new ToolStripMenuItem();
            menuStrip = new MenuStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStrip = new ToolStrip();
            btnReload = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnPaste);
            groupBox1.Controls.Add(btnCopy);
            groupBox1.Controls.Add(cbMeci);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbCota);
            groupBox1.Controls.Add(tbSumaPariata);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAddBet);
            groupBox1.Controls.Add(tbOra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbSelectie);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 165);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Bet";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images;
            pictureBox2.Location = new Point(348, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images_1;
            pictureBox1.Location = new Point(348, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(387, 72);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(59, 23);
            btnPaste.TabIndex = 14;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(319, 72);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(62, 23);
            btnCopy.TabIndex = 13;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // cbMeci
            // 
            cbMeci.FormattingEnabled = true;
            cbMeci.Location = new Point(129, 34);
            cbMeci.Name = "cbMeci";
            cbMeci.Size = new Size(184, 23);
            cbMeci.TabIndex = 13;
            cbMeci.SelectedIndexChanged += cbMeci_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 116);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 12;
            label5.Text = "Cota";
            // 
            // tbCota
            // 
            tbCota.Location = new Point(129, 112);
            tbCota.Name = "tbCota";
            tbCota.Size = new Size(184, 23);
            tbCota.TabIndex = 11;
            tbCota.TextChanged += textBox1_TextChanged;
            tbCota.KeyPress += tbCota_KeyPress;
            tbCota.Validating += tbCota_Validating;
            tbCota.Validated += tbCota_Validated;
            // 
            // tbSumaPariata
            // 
            tbSumaPariata.Location = new Point(570, 73);
            tbSumaPariata.Name = "tbSumaPariata";
            tbSumaPariata.Size = new Size(200, 23);
            tbSumaPariata.TabIndex = 10;
            tbSumaPariata.KeyPress += tbSumaPariata_KeyPress;
            tbSumaPariata.Validating += tbSumaPariata_Validating;
            tbSumaPariata.Validated += tbSumaPariata_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 77);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 9;
            label4.Text = "Suma Pariata";
            // 
            // btnAddBet
            // 
            btnAddBet.BackColor = Color.FromArgb(255, 128, 0);
            btnAddBet.ForeColor = Color.White;
            btnAddBet.Location = new Point(570, 125);
            btnAddBet.Name = "btnAddBet";
            btnAddBet.Size = new Size(157, 23);
            btnAddBet.TabIndex = 8;
            btnAddBet.Text = "Add Bet";
            btnAddBet.UseVisualStyleBackColor = false;
            btnAddBet.Click += btnAddBet_Click;
            // 
            // tbOra
            // 
            tbOra.Location = new Point(570, 34);
            tbOra.Name = "tbOra";
            tbOra.Size = new Size(200, 23);
            tbOra.TabIndex = 7;
            tbOra.ValueChanged += tbOra_ValueChanged;
            tbOra.Validating += tbOra_Validating;
            tbOra.Validated += tbOra_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 34);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "Data si ora";
            // 
            // tbSelectie
            // 
            tbSelectie.Location = new Point(129, 70);
            tbSelectie.Name = "tbSelectie";
            tbSelectie.Size = new Size(184, 23);
            tbSelectie.TabIndex = 5;
            tbSelectie.Validating += tbSelectie_Validating;
            tbSelectie.Validated += tbSelectie_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Meci";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Selectie";
            // 
            // tbMeci
            // 
            tbMeci.Location = new Point(431, 294);
            tbMeci.Name = "tbMeci";
            tbMeci.Size = new Size(184, 23);
            tbMeci.TabIndex = 4;
            // 
            // lvPariuri
            // 
            lvPariuri.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvPariuri.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader3 });
            lvPariuri.ContextMenuStrip = contextMenuStrip;
            lvPariuri.FullRowSelect = true;
            lvPariuri.GridLines = true;
            lvPariuri.Location = new Point(12, 223);
            lvPariuri.Name = "lvPariuri";
            lvPariuri.Size = new Size(776, 167);
            lvPariuri.TabIndex = 9;
            lvPariuri.UseCompatibleStateImageBehavior = false;
            lvPariuri.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Selectie";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "Data";
            columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "Cota";
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 4;
            columnHeader5.Text = "Suma Pariata";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 5;
            columnHeader6.Text = "Posibil Castig";
            columnHeader6.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Meci";
            columnHeader3.Width = 150;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenu, deleteToolStripMenu });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(181, 70);
            // 
            // editToolStripMenu
            // 
            editToolStripMenu.Name = "editToolStripMenu";
            editToolStripMenu.Size = new Size(180, 22);
            editToolStripMenu.Text = "Edit";
            editToolStripMenu.Click += btnEdit_Click;
            // 
            // deleteToolStripMenu
            // 
            deleteToolStripMenu.Name = "deleteToolStripMenu";
            deleteToolStripMenu.Size = new Size(180, 22);
            deleteToolStripMenu.Text = "Delete";
            deleteToolStripMenu.Click += btnDelete_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(615, 396);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "&Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printDialog
            // 
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 13;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(99, 17);
            toolStripStatusLabel1.Text = "Program meciuri:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(149, 17);
            toolStripStatusLabel2.Text = "https://www.flashscore.ro/";
            toolStripStatusLabel2.Click += toolStripStatusLabel2_Click;
            // 
            // btnAdaugaMeci
            // 
            btnAdaugaMeci.Location = new Point(101, 396);
            btnAdaugaMeci.Name = "btnAdaugaMeci";
            btnAdaugaMeci.Size = new Size(98, 23);
            btnAdaugaMeci.TabIndex = 14;
            btnAdaugaMeci.Text = "Adauga Meci";
            btnAdaugaMeci.UseVisualStyleBackColor = true;
            btnAdaugaMeci.Click += btnAdaugaMeci_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(265, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 54);
            panel1.TabIndex = 17;
            // 
            // xMLSerializationToolStripMenuItem
            // 
            xMLSerializationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnSerializeXML, btnDeserializeXML });
            xMLSerializationToolStripMenuItem.Name = "xMLSerializationToolStripMenuItem";
            xMLSerializationToolStripMenuItem.Size = new Size(111, 20);
            xMLSerializationToolStripMenuItem.Text = "&XML_Serialization";
            // 
            // btnSerializeXML
            // 
            btnSerializeXML.Name = "btnSerializeXML";
            btnSerializeXML.Size = new Size(129, 22);
            btnSerializeXML.Text = "Serialize";
            btnSerializeXML.Click += btnSerializeXML_Click;
            // 
            // btnDeserializeXML
            // 
            btnDeserializeXML.Name = "btnDeserializeXML";
            btnDeserializeXML.Size = new Size(129, 22);
            btnDeserializeXML.Text = "Deserialize";
            btnDeserializeXML.Click += btnDeserializeXML_Click;
            // 
            // btnExportToCSV
            // 
            btnExportToCSV.Name = "btnExportToCSV";
            btnExportToCSV.Size = new Size(91, 20);
            btnExportToCSV.Text = "&Export to CSV";
            btnExportToCSV.Click += btnExportToCSV_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(65, 20);
            btnStatistics.Text = "Statistics";
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnPrint
            // 
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(44, 20);
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { xMLSerializationToolStripMenuItem, btnExportToCSV, btnStatistics, btnPrint });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(202, 22);
            toolStripLabel1.Text = "Site oficial UEFA Champions League: ";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.IsLink = true;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(254, 22);
            toolStripLabel2.Text = "https://www.uefa.com/uefachampionsleague/";
            toolStripLabel2.ToolTipText = "UEFA\r\nCHampiona LEague\r\n";
            toolStripLabel2.Click += toolStripLabel2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripLabel1, toolStripLabel2, toolStripSeparator2 });
            toolStrip.Location = new Point(0, 24);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 15;
            toolStrip.Text = "toolStrip1";
            // 
            // btnReload
            // 
            btnReload.BackgroundImage = (Image)resources.GetObject("btnReload.BackgroundImage");
            btnReload.BackgroundImageLayout = ImageLayout.Zoom;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.Location = new Point(512, 402);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(26, 23);
            btnReload.TabIndex = 18;
            btnReload.TextAlign = ContentAlignment.BottomLeft;
            btnReload.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReload);
            Controls.Add(panel1);
            Controls.Add(toolStrip);
            Controls.Add(btnAdaugaMeci);
            Controls.Add(statusStrip);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lvPariuri);
            Controls.Add(groupBox1);
            Controls.Add(tbMeci);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Text = "Pariuri Sportive";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox tbSelectie;
        private TextBox tbMeci;
        private Button btnAddBet;
        private DateTimePicker tbOra;
        private Label label3;
        private ListView lvPariuri;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ErrorProvider errorProvider;
        private Label label5;
        private TextBox tbCota;
        private TextBox tbSumaPariata;
        private Label label4;
        private ComboBox cbMeci;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnDelete;
        private Button btnEdit;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editToolStripMenu;
        private ToolStripMenuItem deleteToolStripMenu;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private Button btnCopy;
        private Button btnPaste;
        private ToolStripButton tsbtnAdaugaMeci;
        private Button btnAdaugaMeci;
        private StatusStrip statusStrip;
        private ColumnHeader columnHeader3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Panel panel1;
        private ToolStrip toolStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem xMLSerializationToolStripMenuItem;
        private ToolStripMenuItem btnSerializeXML;
        private ToolStripMenuItem btnDeserializeXML;
        private ToolStripMenuItem btnExportToCSV;
        private ToolStripMenuItem btnStatistics;
        private ToolStripMenuItem btnPrint;
        private Button btnReload;
    }
}
