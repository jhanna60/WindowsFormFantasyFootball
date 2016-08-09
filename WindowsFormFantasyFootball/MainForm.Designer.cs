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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.rdoTeam = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.lblTotP = new System.Windows.Forms.Label();
            this.lblTotPlayers = new System.Windows.Forms.Label();
            this.rdoDream = new System.Windows.Forms.RadioButton();
            this.lblRoundDesc = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblDeadlineDesc = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).BeginInit();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(469, 60);
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
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dbgPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dbgPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbgPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbgPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dbgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgPlayers.DefaultCellStyle = dataGridViewCellStyle10;
            this.dbgPlayers.Location = new System.Drawing.Point(0, 159);
            this.dbgPlayers.Name = "dbgPlayers";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dbgPlayers.RowHeadersVisible = false;
            this.dbgPlayers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
            this.dbgPlayers.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dbgPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgPlayers.ShowCellToolTips = false;
            this.dbgPlayers.Size = new System.Drawing.Size(1135, 368);
            this.dbgPlayers.TabIndex = 4;
            this.dbgPlayers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbgPlayers_ColumnHeaderMouseClick);
            // 
            // cboTeams
            // 
            this.cboTeams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(12, 62);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 5;
            this.ttHelper.SetToolTip(this.cboTeams, "Allows you to sort the output based on Team");
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.TeamComboBox_SelectedIndexChanged);
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(12, 43);
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
            this.cboPositions.Location = new System.Drawing.Point(165, 62);
            this.cboPositions.Name = "cboPositions";
            this.cboPositions.Size = new System.Drawing.Size(121, 21);
            this.cboPositions.TabIndex = 7;
            this.ttHelper.SetToolTip(this.cboPositions, "Allows you to sort the output based on Position");
            this.cboPositions.SelectedIndexChanged += new System.EventHandler(this.PositionComboBox_SelectedIndexChanged);
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.Location = new System.Drawing.Point(162, 43);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(49, 13);
            this.lblPositions.TabIndex = 8;
            this.lblPositions.Text = "Positions";
            this.ttHelper.SetToolTip(this.lblPositions, "Allows you to sort the output based on Position");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(314, 43);
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
            this.cboPrice.Location = new System.Drawing.Point(317, 62);
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
            this.tbSearch.Location = new System.Drawing.Point(12, 129);
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
            this.lblVersion.Text = "V 2.0";
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
            this.lblTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotals.AutoSize = true;
            this.lblTotals.Location = new System.Drawing.Point(12, 533);
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(36, 13);
            this.lblTotals.TabIndex = 15;
            this.lblTotals.Text = "Totals";
            // 
            // lblGoalie
            // 
            this.lblGoalie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGoalie.AutoSize = true;
            this.lblGoalie.Location = new System.Drawing.Point(60, 533);
            this.lblGoalie.Name = "lblGoalie";
            this.lblGoalie.Size = new System.Drawing.Size(73, 13);
            this.lblGoalie.TabIndex = 16;
            this.lblGoalie.Text = "Goalkeepers :";
            // 
            // lblTotGK
            // 
            this.lblTotGK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotGK.AutoSize = true;
            this.lblTotGK.Location = new System.Drawing.Point(133, 533);
            this.lblTotGK.Name = "lblTotGK";
            this.lblTotGK.Size = new System.Drawing.Size(0, 13);
            this.lblTotGK.TabIndex = 17;
            // 
            // lblDefender
            // 
            this.lblDefender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDefender.AutoSize = true;
            this.lblDefender.Location = new System.Drawing.Point(172, 533);
            this.lblDefender.Name = "lblDefender";
            this.lblDefender.Size = new System.Drawing.Size(62, 13);
            this.lblDefender.TabIndex = 18;
            this.lblDefender.Text = "Defenders :";
            // 
            // lblTotDef
            // 
            this.lblTotDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotDef.AutoSize = true;
            this.lblTotDef.Location = new System.Drawing.Point(234, 532);
            this.lblTotDef.Name = "lblTotDef";
            this.lblTotDef.Size = new System.Drawing.Size(0, 13);
            this.lblTotDef.TabIndex = 19;
            // 
            // lblMidfielder
            // 
            this.lblMidfielder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMidfielder.AutoSize = true;
            this.lblMidfielder.Location = new System.Drawing.Point(282, 533);
            this.lblMidfielder.Name = "lblMidfielder";
            this.lblMidfielder.Size = new System.Drawing.Size(63, 13);
            this.lblMidfielder.TabIndex = 20;
            this.lblMidfielder.Text = "Midfielders :";
            // 
            // lblTotMids
            // 
            this.lblTotMids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotMids.AutoSize = true;
            this.lblTotMids.Location = new System.Drawing.Point(345, 532);
            this.lblTotMids.Name = "lblTotMids";
            this.lblTotMids.Size = new System.Drawing.Size(0, 13);
            this.lblTotMids.TabIndex = 21;
            // 
            // lblForwards
            // 
            this.lblForwards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblForwards.AutoSize = true;
            this.lblForwards.Location = new System.Drawing.Point(393, 533);
            this.lblForwards.Name = "lblForwards";
            this.lblForwards.Size = new System.Drawing.Size(56, 13);
            this.lblForwards.TabIndex = 22;
            this.lblForwards.Text = "Forwards :";
            // 
            // lblTotFwds
            // 
            this.lblTotFwds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotFwds.AutoSize = true;
            this.lblTotFwds.Location = new System.Drawing.Point(449, 533);
            this.lblTotFwds.Name = "lblTotFwds";
            this.lblTotFwds.Size = new System.Drawing.Size(0, 13);
            this.lblTotFwds.TabIndex = 23;
            // 
            // rdoTeam
            // 
            this.rdoTeam.AutoSize = true;
            this.rdoTeam.Location = new System.Drawing.Point(297, 132);
            this.rdoTeam.Name = "rdoTeam";
            this.rdoTeam.Size = new System.Drawing.Size(69, 17);
            this.rdoTeam.TabIndex = 24;
            this.rdoTeam.TabStop = true;
            this.rdoTeam.Text = "My Team";
            this.rdoTeam.UseVisualStyleBackColor = true;
            this.rdoTeam.CheckedChanged += new System.EventHandler(this.rdoTeam_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(202, 132);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(73, 17);
            this.rdoAll.TabIndex = 25;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All Players";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // lblTotP
            // 
            this.lblTotP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotP.AutoSize = true;
            this.lblTotP.Location = new System.Drawing.Point(499, 533);
            this.lblTotP.Name = "lblTotP";
            this.lblTotP.Size = new System.Drawing.Size(74, 13);
            this.lblTotP.TabIndex = 26;
            this.lblTotP.Text = "Total Players :";
            // 
            // lblTotPlayers
            // 
            this.lblTotPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotPlayers.AutoSize = true;
            this.lblTotPlayers.Location = new System.Drawing.Point(573, 533);
            this.lblTotPlayers.Name = "lblTotPlayers";
            this.lblTotPlayers.Size = new System.Drawing.Size(0, 13);
            this.lblTotPlayers.TabIndex = 27;
            // 
            // rdoDream
            // 
            this.rdoDream.AutoSize = true;
            this.rdoDream.Location = new System.Drawing.Point(382, 132);
            this.rdoDream.Name = "rdoDream";
            this.rdoDream.Size = new System.Drawing.Size(86, 17);
            this.rdoDream.TabIndex = 28;
            this.rdoDream.TabStop = true;
            this.rdoDream.Text = "Dream Team";
            this.rdoDream.UseVisualStyleBackColor = true;
            this.rdoDream.CheckedChanged += new System.EventHandler(this.rdoDream_CheckedChanged);
            // 
            // lblRoundDesc
            // 
            this.lblRoundDesc.AutoSize = true;
            this.lblRoundDesc.Location = new System.Drawing.Point(739, 43);
            this.lblRoundDesc.Name = "lblRoundDesc";
            this.lblRoundDesc.Size = new System.Drawing.Size(82, 13);
            this.lblRoundDesc.TabIndex = 29;
            this.lblRoundDesc.Text = "Current Round :";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRound.Location = new System.Drawing.Point(827, 23);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(0, 73);
            this.lblCurrentRound.TabIndex = 30;
            // 
            // lblDeadlineDesc
            // 
            this.lblDeadlineDesc.AutoSize = true;
            this.lblDeadlineDesc.Location = new System.Drawing.Point(743, 110);
            this.lblDeadlineDesc.Name = "lblDeadlineDesc";
            this.lblDeadlineDesc.Size = new System.Drawing.Size(78, 13);
            this.lblDeadlineDesc.TabIndex = 31;
            this.lblDeadlineDesc.Text = "Tips Deadline :";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(837, 110);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(0, 13);
            this.lblDeadline.TabIndex = 32;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(139, 119);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(34, 34);
            this.pbSearch.TabIndex = 33;
            this.pbSearch.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1135, 555);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblDeadlineDesc);
            this.Controls.Add(this.lblCurrentRound);
            this.Controls.Add(this.lblRoundDesc);
            this.Controls.Add(this.rdoDream);
            this.Controls.Add(this.lblTotPlayers);
            this.Controls.Add(this.lblTotP);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.rdoTeam);
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
            this.Controls.Add(this.mnuStrip);
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.Text = "Fantasy Football Stats";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogo)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.RadioButton rdoTeam;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Label lblTotP;
        private System.Windows.Forms.Label lblTotPlayers;
        private System.Windows.Forms.RadioButton rdoDream;
        private System.Windows.Forms.Label lblRoundDesc;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblDeadlineDesc;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.PictureBox pbSearch;
    }
}

