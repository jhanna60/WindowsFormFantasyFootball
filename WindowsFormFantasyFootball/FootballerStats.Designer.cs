namespace WindowsFormFantasyFootball
{
    partial class FootballerStats
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.lblFixture0 = new System.Windows.Forms.Label();
            this.lblFixture1 = new System.Windows.Forms.Label();
            this.lblFixture2 = new System.Windows.Forms.Label();
            this.lblFixture3 = new System.Windows.Forms.Label();
            this.lblFixture4 = new System.Windows.Forms.Label();
            this.lblFixtures = new System.Windows.Forms.Label();
            this.cboHistory = new System.Windows.Forms.ComboBox();
            this.lblHistory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(26, 23);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(138, 148);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 1;
            this.pbPlayer.TabStop = false;
            // 
            // lblFixture0
            // 
            this.lblFixture0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFixture0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixture0.Location = new System.Drawing.Point(36, 255);
            this.lblFixture0.Name = "lblFixture0";
            this.lblFixture0.Size = new System.Drawing.Size(130, 72);
            this.lblFixture0.TabIndex = 2;
            this.lblFixture0.Text = "label1";
            // 
            // lblFixture1
            // 
            this.lblFixture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFixture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixture1.Location = new System.Drawing.Point(172, 255);
            this.lblFixture1.Name = "lblFixture1";
            this.lblFixture1.Size = new System.Drawing.Size(130, 72);
            this.lblFixture1.TabIndex = 3;
            this.lblFixture1.Text = "label1";
            // 
            // lblFixture2
            // 
            this.lblFixture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFixture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixture2.Location = new System.Drawing.Point(308, 255);
            this.lblFixture2.Name = "lblFixture2";
            this.lblFixture2.Size = new System.Drawing.Size(130, 72);
            this.lblFixture2.TabIndex = 4;
            this.lblFixture2.Text = "label1";
            // 
            // lblFixture3
            // 
            this.lblFixture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFixture3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixture3.Location = new System.Drawing.Point(444, 255);
            this.lblFixture3.Name = "lblFixture3";
            this.lblFixture3.Size = new System.Drawing.Size(130, 72);
            this.lblFixture3.TabIndex = 5;
            this.lblFixture3.Text = "label1";
            // 
            // lblFixture4
            // 
            this.lblFixture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFixture4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixture4.Location = new System.Drawing.Point(580, 255);
            this.lblFixture4.Name = "lblFixture4";
            this.lblFixture4.Size = new System.Drawing.Size(130, 72);
            this.lblFixture4.TabIndex = 6;
            this.lblFixture4.Text = "label1";
            // 
            // lblFixtures
            // 
            this.lblFixtures.AutoSize = true;
            this.lblFixtures.Location = new System.Drawing.Point(33, 225);
            this.lblFixtures.Name = "lblFixtures";
            this.lblFixtures.Size = new System.Drawing.Size(43, 13);
            this.lblFixtures.TabIndex = 7;
            this.lblFixtures.Text = "Fixtures";
            // 
            // cboHistory
            // 
            this.cboHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHistory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboHistory.FormattingEnabled = true;
            this.cboHistory.Location = new System.Drawing.Point(36, 388);
            this.cboHistory.Name = "cboHistory";
            this.cboHistory.Size = new System.Drawing.Size(73, 21);
            this.cboHistory.TabIndex = 8;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(33, 358);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(39, 13);
            this.lblHistory.TabIndex = 9;
            this.lblHistory.Text = "History";
            // 
            // FootballerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 455);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cboHistory);
            this.Controls.Add(this.lblFixtures);
            this.Controls.Add(this.lblFixture4);
            this.Controls.Add(this.lblFixture3);
            this.Controls.Add(this.lblFixture2);
            this.Controls.Add(this.lblFixture1);
            this.Controls.Add(this.lblFixture0);
            this.Controls.Add(this.pbPlayer);
            this.Name = "FootballerStats";
            this.Text = "Footballer Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lblFixture0;
        private System.Windows.Forms.Label lblFixture1;
        private System.Windows.Forms.Label lblFixture2;
        private System.Windows.Forms.Label lblFixture3;
        private System.Windows.Forms.Label lblFixture4;
        private System.Windows.Forms.Label lblFixtures;
        private System.Windows.Forms.ComboBox cboHistory;
        private System.Windows.Forms.Label lblHistory;
    }
}