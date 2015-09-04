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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblLoadedSuccessMessage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dbgPlayers = new System.Windows.Forms.DataGridView();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.cboPositions = new System.Windows.Forms.ComboBox();
            this.lblPositions = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.ttHelper = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnuStrip.SuspendLayout();
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(469, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset All";
            this.ttHelper.SetToolTip(this.btnReset, "Will reset all filters and the search box");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dbgPlayers
            // 
            this.dbgPlayers.AllowUserToAddRows = false;
            this.dbgPlayers.AllowUserToDeleteRows = false;
            this.dbgPlayers.AllowUserToOrderColumns = true;
            this.dbgPlayers.AllowUserToResizeColumns = false;
            this.dbgPlayers.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.dbgPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dbgPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbgPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dbgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgPlayers.DefaultCellStyle = dataGridViewCellStyle22;
            this.dbgPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dbgPlayers.Location = new System.Drawing.Point(12, 159);
            this.dbgPlayers.Name = "dbgPlayers";
            this.dbgPlayers.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dbgPlayers.RowHeadersVisible = false;
            this.dbgPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Gainsboro;
            this.dbgPlayers.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dbgPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgPlayers.ShowCellToolTips = false;
            this.dbgPlayers.Size = new System.Drawing.Size(1111, 368);
            this.dbgPlayers.TabIndex = 4;
            this.ttHelper.SetToolTip(this.dbgPlayers, "If you right click the column headers you can hide/show Columns");
            this.dbgPlayers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbgPlayers_ColumnHeaderMouseClick);
            // 
            // cboTeams
            // 
            this.cboTeams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(12, 77);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 5;
            this.ttHelper.SetToolTip(this.cboTeams, "Allows you to sort the output based on Team");
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(12, 58);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(39, 13);
            this.lblTeams.TabIndex = 6;
            this.lblTeams.Text = "Teams";
            this.ttHelper.SetToolTip(this.lblTeams, "Allows you to sort the output based on Team");
            // 
            // cboPositions
            // 
            this.cboPositions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPositions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPositions.FormattingEnabled = true;
            this.cboPositions.Location = new System.Drawing.Point(165, 77);
            this.cboPositions.Name = "cboPositions";
            this.cboPositions.Size = new System.Drawing.Size(121, 21);
            this.cboPositions.TabIndex = 7;
            this.ttHelper.SetToolTip(this.cboPositions, "Allows you to sort the output based on Position");
            this.cboPositions.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.Location = new System.Drawing.Point(162, 58);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(49, 13);
            this.lblPositions.TabIndex = 8;
            this.lblPositions.Text = "Positions";
            this.ttHelper.SetToolTip(this.lblPositions, "Allows you to sort the output based on Position");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(314, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            this.ttHelper.SetToolTip(this.lblPrice, "Displays all footballers up to value selected");
            // 
            // cboPrice
            // 
            this.cboPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(317, 77);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(121, 21);
            this.cboPrice.TabIndex = 9;
            this.ttHelper.SetToolTip(this.cboPrice, "Displays all footballers up to value selected");
            this.cboPrice.SelectedIndexChanged += new System.EventHandler(this.cboPrice_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(993, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.ttHelper.SetToolTip(this.pictureBox1, "F**k off this does nothing");
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1091, 533);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(32, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "V 1.4";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 127);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(121, 20);
            this.tbSearch.TabIndex = 13;
            this.ttHelper.SetToolTip(this.tbSearch, "Allows you to search on Firstname or Surname");
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.Color.Silver;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(1135, 24);
            this.mnuStrip.TabIndex = 14;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1135, 555);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cboPrice);
            this.Controls.Add(this.lblPositions);
            this.Controls.Add(this.cboPositions);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.dbgPlayers);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblLoadedSuccessMessage);
            this.Controls.Add(this.mnuStrip);
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.Text = "Fantasy Football Stats";
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoadedSuccessMessage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dbgPlayers;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.ComboBox cboPositions;
        private System.Windows.Forms.Label lblPositions;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.ToolTip ttHelper;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

