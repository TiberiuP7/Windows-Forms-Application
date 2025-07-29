namespace PariuriSportive
{
    partial class AdaugaMeciForm
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
            tbStadion = new TextBox();
            tbGazda = new TextBox();
            tbOaspeti = new TextBox();
            tbCompetitie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbStareMeci = new ComboBox();
            dtData = new DateTimePicker();
            btnAdaugaMeci = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbStadion
            // 
            tbStadion.Location = new Point(86, 100);
            tbStadion.Name = "tbStadion";
            tbStadion.Size = new Size(119, 23);
            tbStadion.TabIndex = 0;
            // 
            // tbGazda
            // 
            tbGazda.Location = new Point(86, 31);
            tbGazda.Name = "tbGazda";
            tbGazda.Size = new Size(119, 23);
            tbGazda.TabIndex = 1;
            // 
            // tbOaspeti
            // 
            tbOaspeti.Location = new Point(86, 63);
            tbOaspeti.Name = "tbOaspeti";
            tbOaspeti.Size = new Size(119, 23);
            tbOaspeti.TabIndex = 2;
            // 
            // tbCompetitie
            // 
            tbCompetitie.Location = new Point(303, 63);
            tbCompetitie.Name = "tbCompetitie";
            tbCompetitie.Size = new Size(147, 23);
            tbCompetitie.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Gazda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 66);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Oaspeti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 103);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Stadion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 34);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 8;
            label4.Text = "Data si ora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 103);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 9;
            label5.Text = "Stare Meci";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 68);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Competitie";
            // 
            // cbStareMeci
            // 
            cbStareMeci.FormattingEnabled = true;
            cbStareMeci.Location = new Point(303, 100);
            cbStareMeci.Name = "cbStareMeci";
            cbStareMeci.Size = new Size(100, 23);
            cbStareMeci.TabIndex = 11;
            // 
            // dtData
            // 
            dtData.Location = new Point(303, 31);
            dtData.Name = "dtData";
            dtData.Size = new Size(147, 23);
            dtData.TabIndex = 12;
            // 
            // btnAdaugaMeci
            // 
            btnAdaugaMeci.BackColor = Color.FromArgb(0, 192, 0);
            btnAdaugaMeci.Location = new Point(294, 144);
            btnAdaugaMeci.Name = "btnAdaugaMeci";
            btnAdaugaMeci.Size = new Size(75, 23);
            btnAdaugaMeci.TabIndex = 13;
            btnAdaugaMeci.Text = "Adauga Meci";
            btnAdaugaMeci.UseVisualStyleBackColor = false;
            btnAdaugaMeci.Click += btnAdaugaMeci_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(375, 144);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AdaugaMeciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 197);
            Controls.Add(btnCancel);
            Controls.Add(btnAdaugaMeci);
            Controls.Add(dtData);
            Controls.Add(cbStareMeci);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCompetitie);
            Controls.Add(tbOaspeti);
            Controls.Add(tbGazda);
            Controls.Add(tbStadion);
            Name = "AdaugaMeciForm";
            Text = "Adauga Meci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbStadion;
        private TextBox tbGazda;
        private TextBox tbOaspeti;
        private TextBox tbCompetitie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbStareMeci;
        private DateTimePicker dtData;
        private Button btnAdaugaMeci;
        private Button btnCancel;
    }
}