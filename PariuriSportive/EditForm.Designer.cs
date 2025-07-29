namespace PariuriSportive
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbMeci = new ComboBox();
            label5 = new Label();
            tbCota = new TextBox();
            tbSumaPariata = new TextBox();
            label4 = new Label();
            tbOra = new DateTimePicker();
            label3 = new Label();
            tbSelectie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cbMeci
            // 
            cbMeci.FormattingEnabled = true;
            cbMeci.Location = new Point(112, 12);
            cbMeci.Name = "cbMeci";
            cbMeci.Size = new Size(184, 23);
            cbMeci.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 90);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 22;
            label5.Text = "Cota";
            // 
            // tbCota
            // 
            tbCota.Location = new Point(112, 86);
            tbCota.Name = "tbCota";
            tbCota.Size = new Size(184, 23);
            tbCota.TabIndex = 21;
            tbCota.KeyPress += tbCota_KeyPress;
            // 
            // tbSumaPariata
            // 
            tbSumaPariata.Location = new Point(112, 169);
            tbSumaPariata.Name = "tbSumaPariata";
            tbSumaPariata.Size = new Size(184, 23);
            tbSumaPariata.TabIndex = 20;
            tbSumaPariata.KeyPress += tbSumaPariata_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 173);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 19;
            label4.Text = "Suma Pariata";
            // 
            // tbOra
            // 
            tbOra.Format = DateTimePickerFormat.Short;
            tbOra.Location = new Point(112, 130);
            tbOra.Name = "tbOra";
            tbOra.Size = new Size(184, 23);
            tbOra.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 134);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "Data si ora";
            // 
            // tbSelectie
            // 
            tbSelectie.Location = new Point(112, 48);
            tbSelectie.Name = "tbSelectie";
            tbSelectie.Size = new Size(184, 23);
            tbSelectie.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 16);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 14;
            label1.Text = "Meci";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 52);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 15;
            label2.Text = "Selectie";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(140, 198);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 24;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(221, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 225);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cbMeci);
            Controls.Add(label5);
            Controls.Add(tbCota);
            Controls.Add(tbSumaPariata);
            Controls.Add(label4);
            Controls.Add(tbOra);
            Controls.Add(label3);
            Controls.Add(tbSelectie);
            Controls.Add(label1);
            Controls.Add(label2);
            MaximumSize = new Size(324, 264);
            MinimumSize = new Size(324, 264);
            Name = "EditForm";
            Text = "Edit Pariu";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMeci;
        private Label label5;
        private TextBox tbCota;
        private TextBox tbSumaPariata;
        private Label label4;
        private DateTimePicker tbOra;
        private Label label3;
        private TextBox tbSelectie;
        private Label label1;
        private Label label2;
        private Button btnOk;
        private Button btnCancel;
    }
}