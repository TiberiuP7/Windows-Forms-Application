namespace PariuriSportiveLibrary
{
    partial class BetFilter : System.Windows.Forms.UserControl
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
            button1 = new Button();
            domainUpDown1 = new DomainUpDown();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Location = new Point(168, 118);
            button1.Name = "button1";
            button1.Size = new Size(173, 78);
            button1.TabIndex = 0;
            button1.Text = "Enter the Sports Betting App";
            button1.UseVisualStyleBackColor = false;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(42, 148);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 1;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(347, 148);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 69);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Sports Betting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 118);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "How much ";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip.Location = new Point(0, 288);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(501, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.ForeColor = Color.FromArgb(192, 64, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(213, 17);
            toolStripStatusLabel1.Text = "Don't forget to gamble responsibly!!!";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // ScatterChart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Name = "ScatterChartProfits";
            Size = new Size(501, 310);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DomainUpDown domainUpDown1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}
