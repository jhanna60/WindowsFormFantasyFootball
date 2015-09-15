﻿namespace WindowsFormFantasyFootball
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pBLogo = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotals = new System.Windows.Forms.Label();
            this.lblGoalie = new System.Windows.Forms.Label();
            this.lblTotGK = new System.Windows.Forms.Label();
            this.lblDefender = new System.Windows.Forms.Label();
            this.lblTotDef = new System.Windows.Forms.Label();
            this.lblMidfielder = new System.Windows.Forms.Label();
            this.lblTotMids = new System.Windows.Forms.Label();
            this.lblForwards = new System.Windows.Forms.Label();
            this.lblTotFwds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
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
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dbgPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dbgPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbgPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dbgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgPlayers.DefaultCellStyle = dataGridViewCellStyle14;
            this.dbgPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dbgPlayers.Location = new System.Drawing.Point(12, 159);
            this.dbgPlayers.Name = "dbgPlayers";
            this.dbgPlayers.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dbgPlayers.RowHeadersVisible = false;
            this.dbgPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gainsboro;
            this.dbgPlayers.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dbgPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgPlayers.ShowCellToolTips = false;
            this.dbgPlayers.Size = new System.Drawing.Size(1111, 368);
            this.dbgPlayers.TabIndex = 4;
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
            // pBLogo
            // 
            this.pBLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBLogo.Image")));
            this.pBLogo.Location = new System.Drawing.Point(993, 30);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new System.Drawing.Size(130, 117);
            this.pBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLogo.TabIndex = 11;
            this.pBLogo.TabStop = false;
            this.ttHelper.SetToolTip(this.pBLogo, "F**k off this does nothing");
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(12, 127);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(121, 20);
            this.tbSearch.TabIndex = 13;
            this.ttHelper.SetToolTip(this.tbSearch, "Allows you to search on Firstname or Surname");
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(1091, 533);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(32, 13);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "V 1.5";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lblTotals
            // 
            this.lblTotals.AutoSize = true;
            this.lblTotals.Location = new System.Drawing.Point(12, 533);
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(36, 13);
            this.lblTotals.TabIndex = 15;
            this.lblTotals.Text = "Totals";
            // 
            // lblGoalie
            // 
            this.lblGoalie.AutoSize = true;
            this.lblGoalie.Location = new System.Drawing.Point(60, 533);
            this.lblGoalie.Name = "lblGoalie";
            this.lblGoalie.Size = new System.Drawing.Size(73, 13);
            this.lblGoalie.TabIndex = 16;
            this.lblGoalie.Text = "Goalkeepers :";
            // 
            // lblTotGK
            // 
            this.lblTotGK.AutoSize = true;
            this.lblTotGK.Location = new System.Drawing.Point(133, 533);
            this.lblTotGK.Name = "lblTotGK";
            this.lblTotGK.Size = new System.Drawing.Size(0, 13);
            this.lblTotGK.TabIndex = 17;
            // 
            // lblDefender
            // 
            this.lblDefender.AutoSize = true;
            this.lblDefender.Location = new System.Drawing.Point(172, 533);
            this.lblDefender.Name = "lblDefender";
            this.lblDefender.Size = new System.Drawing.Size(62, 13);
            this.lblDefender.TabIndex = 18;
            this.lblDefender.Text = "Defenders :";
            // 
            // lblTotDef
            // 
            this.lblTotDef.AutoSize = true;
            this.lblTotDef.Location = new System.Drawing.Point(234, 532);
            this.lblTotDef.Name = "lblTotDef";
            this.lblTotDef.Size = new System.Drawing.Size(0, 13);
            this.lblTotDef.TabIndex = 19;
            // 
            // lblMidfielder
            // 
            this.lblMidfielder.AutoSize = true;
            this.lblMidfielder.Location = new System.Drawing.Point(282, 533);
            this.lblMidfielder.Name = "lblMidfielder";
            this.lblMidfielder.Size = new System.Drawing.Size(63, 13);
            this.lblMidfielder.TabIndex = 20;
            this.lblMidfielder.Text = "Midfielders :";
            // 
            // lblTotMids
            // 
            this.lblTotMids.AutoSize = true;
            this.lblTotMids.Location = new System.Drawing.Point(345, 532);
            this.lblTotMids.Name = "lblTotMids";
            this.lblTotMids.Size = new System.Drawing.Size(0, 13);
            this.lblTotMids.TabIndex = 21;
            // 
            // lblForwards
            // 
            this.lblForwards.AutoSize = true;
            this.lblForwards.Location = new System.Drawing.Point(393, 533);
            this.lblForwards.Name = "lblForwards";
            this.lblForwards.Size = new System.Drawing.Size(56, 13);
            this.lblForwards.TabIndex = 22;
            this.lblForwards.Text = "Forwards :";
            // 
            // lblTotFwds
            // 
            this.lblTotFwds.AutoSize = true;
            this.lblTotFwds.Location = new System.Drawing.Point(449, 533);
            this.lblTotFwds.Name = "lblTotFwds";
            this.lblTotFwds.Size = new System.Drawing.Size(0, 13);
            this.lblTotFwds.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1135, 555);
            this.Controls.Add(this.lblTotFwds);
            this.Controls.Add(this.lblForwards);
            this.Controls.Add(this.lblTotMids);
            this.Controls.Add(this.lblMidfielder);
            this.Controls.Add(this.lblTotDef);
            this.Controls.Add(this.lblDefender);
            this.Controls.Add(this.lblTotGK);
            this.Controls.Add(this.lblGoalie);
            this.Controls.Add(this.lblTotals);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pBLogo);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pBLogo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblTotals;
        private System.Windows.Forms.Label lblGoalie;
        private System.Windows.Forms.Label lblTotGK;
        private System.Windows.Forms.Label lblDefender;
        private System.Windows.Forms.Label lblTotDef;
        private System.Windows.Forms.Label lblMidfielder;
        private System.Windows.Forms.Label lblTotMids;
        private System.Windows.Forms.Label lblForwards;
        private System.Windows.Forms.Label lblTotFwds;
    }
}

