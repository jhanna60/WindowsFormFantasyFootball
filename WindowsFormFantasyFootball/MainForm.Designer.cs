namespace WindowsFormFantasyFootball
{
    partial class MainForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblLoadedSuccessMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dbgPlayers = new System.Windows.Forms.DataGridView();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPositions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadedSuccessMessage
            // 
            this.lblLoadedSuccessMessage.AutoSize = true;
            this.lblLoadedSuccessMessage.Location = new System.Drawing.Point(9, 30);
            this.lblLoadedSuccessMessage.Name = "lblLoadedSuccessMessage";
            this.lblLoadedSuccessMessage.Size = new System.Drawing.Size(0, 13);
            this.lblLoadedSuccessMessage.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Analyse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dbgPlayers
            // 
            this.dbgPlayers.AllowUserToAddRows = false;
            this.dbgPlayers.AllowUserToDeleteRows = false;
            this.dbgPlayers.AllowUserToOrderColumns = true;
            this.dbgPlayers.AllowUserToResizeColumns = false;
            this.dbgPlayers.AllowUserToResizeRows = false;
            this.dbgPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgPlayers.Location = new System.Drawing.Point(12, 176);
            this.dbgPlayers.Name = "dbgPlayers";
            this.dbgPlayers.ReadOnly = true;
            this.dbgPlayers.Size = new System.Drawing.Size(1053, 296);
            this.dbgPlayers.TabIndex = 4;
            // 
            // cboTeams
            // 
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(12, 100);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 5;
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teams";
            // 
            // cboPositions
            // 
            this.cboPositions.FormattingEnabled = true;
            this.cboPositions.Location = new System.Drawing.Point(165, 100);
            this.cboPositions.Name = "cboPositions";
            this.cboPositions.Size = new System.Drawing.Size(121, 21);
            this.cboPositions.TabIndex = 7;
            this.cboPositions.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Positions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1077, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPositions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.dbgPlayers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLoadedSuccessMessage);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblLoadedSuccessMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dbgPlayers;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPositions;
        private System.Windows.Forms.Label label3;
    }
}

