using System.Windows.Forms;
using System.Xml.Linq;

namespace PariuriSportive
{
    partial class BetFilterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            numMinimumStake = new NumericUpDown();
            btnFilter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numMinimumOdds = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numMinimumStake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinimumOdds).BeginInit();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(166, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(73, 23);
            dtpFrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(166, 26);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(73, 23);
            dtpTo.TabIndex = 2;
            // 
            // numMinimumStake
            // 
            numMinimumStake.Location = new Point(65, 24);
            numMinimumStake.Name = "numMinimumStake";
            numMinimumStake.Size = new Size(29, 23);
            numMinimumStake.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.ForestGreen;
            btnFilter.Location = new Point(100, 21);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(42, 24);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "Min Odds";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 26);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Min Stake";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 3);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Date from";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 26);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 8;
            label4.Text = "To";
            // 
            // numMinimumOdds
            // 
            numMinimumOdds.Location = new Point(65, -2);
            numMinimumOdds.Name = "numMinimumOdds";
            numMinimumOdds.Size = new Size(29, 23);
            numMinimumOdds.TabIndex = 9;
            // 
            // BetFilterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numMinimumOdds);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFilter);
            Controls.Add(numMinimumStake);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Name = "BetFilterControl";
            Size = new Size(244, 50);
            ((System.ComponentModel.ISupportInitialize)numMinimumStake).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinimumOdds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private NumericUpDown numMinimumStake;
        private Button btnFilter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numMinimumOdds;
    }
}
