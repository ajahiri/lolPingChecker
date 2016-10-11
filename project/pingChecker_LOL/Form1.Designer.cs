namespace pingChecker_LOL
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lolOceanicStart = new System.Windows.Forms.Button();
            this.lolOceanicStop = new System.Windows.Forms.Button();
            this.lolOceanicLabel = new System.Windows.Forms.Label();
            this.Server_Title = new System.Windows.Forms.Label();
            this.pingLabel = new System.Windows.Forms.Label();
            this.lolOceanicPing = new System.Windows.Forms.Label();
            this.lolOCETimer = new System.Windows.Forms.Timer(this.components);
            this.lolNAStart = new System.Windows.Forms.Button();
            this.lolNAStop = new System.Windows.Forms.Button();
            this.lolNALabel = new System.Windows.Forms.Label();
            this.lolNAPing = new System.Windows.Forms.Label();
            this.lolNATimer = new System.Windows.Forms.Timer(this.components);
            this.lolEUWStart = new System.Windows.Forms.Button();
            this.lolEUWStop = new System.Windows.Forms.Button();
            this.lolEUWLabel = new System.Windows.Forms.Label();
            this.lolEUWPing = new System.Windows.Forms.Label();
            this.lolEUWTimer = new System.Windows.Forms.Timer(this.components);
            this.lolEUNEStart = new System.Windows.Forms.Button();
            this.lolEUNEStop = new System.Windows.Forms.Button();
            this.lolEUNELabel = new System.Windows.Forms.Label();
            this.lolEUNEPing = new System.Windows.Forms.Label();
            this.lolEUNETimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.logOceanic = new System.Windows.Forms.RadioButton();
            this.logNA = new System.Windows.Forms.RadioButton();
            this.logEUW = new System.Windows.Forms.RadioButton();
            this.logEUNE = new System.Windows.Forms.RadioButton();
            this.logToggleLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.saveLogButton = new System.Windows.Forms.Button();
            this.pingLog = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lolOceanicStart
            // 
            this.lolOceanicStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolOceanicStart.Location = new System.Drawing.Point(292, 164);
            this.lolOceanicStart.Name = "lolOceanicStart";
            this.lolOceanicStart.Size = new System.Drawing.Size(75, 23);
            this.lolOceanicStart.TabIndex = 0;
            this.lolOceanicStart.Text = "Start Pinging";
            this.lolOceanicStart.UseVisualStyleBackColor = true;
            this.lolOceanicStart.Click += new System.EventHandler(this.lolOceanicStart_Click);
            // 
            // lolOceanicStop
            // 
            this.lolOceanicStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolOceanicStop.Location = new System.Drawing.Point(184, 164);
            this.lolOceanicStop.Name = "lolOceanicStop";
            this.lolOceanicStop.Size = new System.Drawing.Size(75, 23);
            this.lolOceanicStop.TabIndex = 1;
            this.lolOceanicStop.Text = "Stop Pinging";
            this.lolOceanicStop.UseVisualStyleBackColor = true;
            this.lolOceanicStop.Click += new System.EventHandler(this.lolOceanicStop_Click);
            // 
            // lolOceanicLabel
            // 
            this.lolOceanicLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolOceanicLabel.AutoSize = true;
            this.lolOceanicLabel.Location = new System.Drawing.Point(35, 169);
            this.lolOceanicLabel.Name = "lolOceanicLabel";
            this.lolOceanicLabel.Size = new System.Drawing.Size(102, 13);
            this.lolOceanicLabel.TabIndex = 2;
            this.lolOceanicLabel.Text = "LoL Oceanic Server";
            // 
            // Server_Title
            // 
            this.Server_Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Server_Title.AutoSize = true;
            this.Server_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_Title.Location = new System.Drawing.Point(35, 140);
            this.Server_Title.Name = "Server_Title";
            this.Server_Title.Size = new System.Drawing.Size(71, 13);
            this.Server_Title.TabIndex = 3;
            this.Server_Title.Text = "Riot Server";
            // 
            // pingLabel
            // 
            this.pingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pingLabel.AutoSize = true;
            this.pingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingLabel.Location = new System.Drawing.Point(496, 140);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(59, 13);
            this.pingLabel.TabIndex = 4;
            this.pingLabel.Text = "Ping (ms)";
            // 
            // lolOceanicPing
            // 
            this.lolOceanicPing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolOceanicPing.AutoSize = true;
            this.lolOceanicPing.Location = new System.Drawing.Point(509, 169);
            this.lolOceanicPing.Name = "lolOceanicPing";
            this.lolOceanicPing.Size = new System.Drawing.Size(32, 13);
            this.lolOceanicPing.TabIndex = 5;
            this.lolOceanicPing.Text = "--- ms";
            // 
            // lolOCETimer
            // 
            this.lolOCETimer.Interval = 1000;
            this.lolOCETimer.Tick += new System.EventHandler(this.lolOCETimer_Tick);
            // 
            // lolNAStart
            // 
            this.lolNAStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolNAStart.Location = new System.Drawing.Point(292, 198);
            this.lolNAStart.Name = "lolNAStart";
            this.lolNAStart.Size = new System.Drawing.Size(75, 23);
            this.lolNAStart.TabIndex = 0;
            this.lolNAStart.Text = "Start Pinging";
            this.lolNAStart.UseVisualStyleBackColor = true;
            this.lolNAStart.Click += new System.EventHandler(this.lolNAStart_Click);
            // 
            // lolNAStop
            // 
            this.lolNAStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolNAStop.Location = new System.Drawing.Point(184, 198);
            this.lolNAStop.Name = "lolNAStop";
            this.lolNAStop.Size = new System.Drawing.Size(75, 23);
            this.lolNAStop.TabIndex = 1;
            this.lolNAStop.Text = "Stop Pinging";
            this.lolNAStop.UseVisualStyleBackColor = true;
            this.lolNAStop.Click += new System.EventHandler(this.lolNAStop_Click);
            // 
            // lolNALabel
            // 
            this.lolNALabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolNALabel.AutoSize = true;
            this.lolNALabel.Location = new System.Drawing.Point(35, 203);
            this.lolNALabel.Name = "lolNALabel";
            this.lolNALabel.Size = new System.Drawing.Size(135, 13);
            this.lolNALabel.TabIndex = 2;
            this.lolNALabel.Text = "LoL North American Server";
            // 
            // lolNAPing
            // 
            this.lolNAPing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolNAPing.AutoSize = true;
            this.lolNAPing.Location = new System.Drawing.Point(509, 203);
            this.lolNAPing.Name = "lolNAPing";
            this.lolNAPing.Size = new System.Drawing.Size(32, 13);
            this.lolNAPing.TabIndex = 5;
            this.lolNAPing.Text = "--- ms";
            // 
            // lolNATimer
            // 
            this.lolNATimer.Interval = 1000;
            this.lolNATimer.Tick += new System.EventHandler(this.lolNATimer_Tick);
            // 
            // lolEUWStart
            // 
            this.lolEUWStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUWStart.Location = new System.Drawing.Point(292, 231);
            this.lolEUWStart.Name = "lolEUWStart";
            this.lolEUWStart.Size = new System.Drawing.Size(75, 23);
            this.lolEUWStart.TabIndex = 0;
            this.lolEUWStart.Text = "Start Pinging";
            this.lolEUWStart.UseVisualStyleBackColor = true;
            this.lolEUWStart.Click += new System.EventHandler(this.lolEUWStart_Click);
            // 
            // lolEUWStop
            // 
            this.lolEUWStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUWStop.Location = new System.Drawing.Point(184, 231);
            this.lolEUWStop.Name = "lolEUWStop";
            this.lolEUWStop.Size = new System.Drawing.Size(75, 23);
            this.lolEUWStop.TabIndex = 1;
            this.lolEUWStop.Text = "Stop Pinging";
            this.lolEUWStop.UseVisualStyleBackColor = true;
            this.lolEUWStop.Click += new System.EventHandler(this.lolEUWStop_Click);
            // 
            // lolEUWLabel
            // 
            this.lolEUWLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUWLabel.AutoSize = true;
            this.lolEUWLabel.Location = new System.Drawing.Point(35, 236);
            this.lolEUWLabel.Name = "lolEUWLabel";
            this.lolEUWLabel.Size = new System.Drawing.Size(105, 13);
            this.lolEUWLabel.TabIndex = 2;
            this.lolEUWLabel.Text = "LoL EU West Server";
            // 
            // lolEUWPing
            // 
            this.lolEUWPing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUWPing.AutoSize = true;
            this.lolEUWPing.Location = new System.Drawing.Point(509, 236);
            this.lolEUWPing.Name = "lolEUWPing";
            this.lolEUWPing.Size = new System.Drawing.Size(32, 13);
            this.lolEUWPing.TabIndex = 5;
            this.lolEUWPing.Text = "--- ms";
            // 
            // lolEUWTimer
            // 
            this.lolEUWTimer.Interval = 1000;
            this.lolEUWTimer.Tick += new System.EventHandler(this.lolEUWTimer_Tick);
            // 
            // lolEUNEStart
            // 
            this.lolEUNEStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUNEStart.Location = new System.Drawing.Point(292, 265);
            this.lolEUNEStart.Name = "lolEUNEStart";
            this.lolEUNEStart.Size = new System.Drawing.Size(75, 23);
            this.lolEUNEStart.TabIndex = 0;
            this.lolEUNEStart.Text = "Start Pinging";
            this.lolEUNEStart.UseVisualStyleBackColor = true;
            this.lolEUNEStart.Click += new System.EventHandler(this.lolEUNEStart_Click);
            // 
            // lolEUNEStop
            // 
            this.lolEUNEStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUNEStop.Location = new System.Drawing.Point(184, 265);
            this.lolEUNEStop.Name = "lolEUNEStop";
            this.lolEUNEStop.Size = new System.Drawing.Size(75, 23);
            this.lolEUNEStop.TabIndex = 1;
            this.lolEUNEStop.Text = "Stop Pinging";
            this.lolEUNEStop.UseVisualStyleBackColor = true;
            this.lolEUNEStop.Click += new System.EventHandler(this.lolEUNEStop_Click);
            // 
            // lolEUNELabel
            // 
            this.lolEUNELabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUNELabel.AutoSize = true;
            this.lolEUNELabel.Location = new System.Drawing.Point(35, 270);
            this.lolEUNELabel.Name = "lolEUNELabel";
            this.lolEUNELabel.Size = new System.Drawing.Size(130, 13);
            this.lolEUNELabel.TabIndex = 2;
            this.lolEUNELabel.Text = "LoL EU North-East Server";
            // 
            // lolEUNEPing
            // 
            this.lolEUNEPing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lolEUNEPing.AutoSize = true;
            this.lolEUNEPing.Location = new System.Drawing.Point(509, 270);
            this.lolEUNEPing.Name = "lolEUNEPing";
            this.lolEUNEPing.Size = new System.Drawing.Size(32, 13);
            this.lolEUNEPing.TabIndex = 5;
            this.lolEUNEPing.Text = "--- ms";
            // 
            // lolEUNETimer
            // 
            this.lolEUNETimer.Interval = 1000;
            this.lolEUNETimer.Tick += new System.EventHandler(this.lolEUNETimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(172, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Copyright
            // 
            this.Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(12, 406);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(144, 13);
            this.Copyright.TabIndex = 7;
            this.Copyright.TabStop = true;
            this.Copyright.Text = "Copyright Arian Jahiri © 2016";
            this.Copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(254, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(226, 40);
            this.Title.TabIndex = 9;
            this.Title.Text = "League of Legends Server \r\nPing Check Tool";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(640, 406);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(82, 13);
            this.Version.TabIndex = 10;
            this.Version.Text = "v1.0.1.0 (Alpha)";
            // 
            // logOceanic
            // 
            this.logOceanic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logOceanic.AutoSize = true;
            this.logOceanic.Location = new System.Drawing.Point(419, 168);
            this.logOceanic.Name = "logOceanic";
            this.logOceanic.Size = new System.Drawing.Size(43, 17);
            this.logOceanic.TabIndex = 11;
            this.logOceanic.TabStop = true;
            this.logOceanic.Text = "Log";
            this.logOceanic.UseVisualStyleBackColor = true;
            this.logOceanic.CheckedChanged += new System.EventHandler(this.logOceanic_CheckedChanged);
            // 
            // logNA
            // 
            this.logNA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logNA.AutoSize = true;
            this.logNA.Location = new System.Drawing.Point(419, 202);
            this.logNA.Name = "logNA";
            this.logNA.Size = new System.Drawing.Size(43, 17);
            this.logNA.TabIndex = 11;
            this.logNA.TabStop = true;
            this.logNA.Text = "Log";
            this.logNA.UseVisualStyleBackColor = true;
            this.logNA.CheckedChanged += new System.EventHandler(this.logNA_CheckedChanged);
            // 
            // logEUW
            // 
            this.logEUW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logEUW.AutoSize = true;
            this.logEUW.Location = new System.Drawing.Point(419, 235);
            this.logEUW.Name = "logEUW";
            this.logEUW.Size = new System.Drawing.Size(43, 17);
            this.logEUW.TabIndex = 11;
            this.logEUW.TabStop = true;
            this.logEUW.Text = "Log";
            this.logEUW.UseVisualStyleBackColor = true;
            this.logEUW.CheckedChanged += new System.EventHandler(this.logEUW_CheckedChanged);
            // 
            // logEUNE
            // 
            this.logEUNE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logEUNE.AutoSize = true;
            this.logEUNE.Location = new System.Drawing.Point(419, 269);
            this.logEUNE.Name = "logEUNE";
            this.logEUNE.Size = new System.Drawing.Size(43, 17);
            this.logEUNE.TabIndex = 11;
            this.logEUNE.TabStop = true;
            this.logEUNE.Text = "Log";
            this.logEUNE.UseVisualStyleBackColor = true;
            this.logEUNE.CheckedChanged += new System.EventHandler(this.logEUNE_CheckedChanged);
            // 
            // logToggleLabel
            // 
            this.logToggleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logToggleLabel.AutoSize = true;
            this.logToggleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logToggleLabel.Location = new System.Drawing.Point(426, 140);
            this.logToggleLabel.Name = "logToggleLabel";
            this.logToggleLabel.Size = new System.Drawing.Size(28, 13);
            this.logToggleLabel.TabIndex = 12;
            this.logToggleLabel.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.Location = new System.Drawing.Point(592, 64);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(130, 299);
            this.logBox.TabIndex = 13;
            // 
            // saveLogButton
            // 
            this.saveLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLogButton.Location = new System.Drawing.Point(620, 368);
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.Size = new System.Drawing.Size(75, 23);
            this.saveLogButton.TabIndex = 14;
            this.saveLogButton.Text = "Savelog";
            this.saveLogButton.UseVisualStyleBackColor = true;
            this.saveLogButton.Click += new System.EventHandler(this.saveLogButton_Click);
            // 
            // pingLog
            // 
            this.pingLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pingLog.AutoSize = true;
            this.pingLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingLog.Location = new System.Drawing.Point(629, 48);
            this.pingLog.Name = "pingLog";
            this.pingLog.Size = new System.Drawing.Size(57, 13);
            this.pingLog.TabIndex = 12;
            this.pingLog.Text = "Ping Log";
            // 
            // Form1
            // 
            this.AccessibleDescription = "Check League of Legends gameserver ping time before going into game.";
            this.AccessibleName = "League of Legends Ping Checker";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 428);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.pingLog);
            this.Controls.Add(this.logToggleLabel);
            this.Controls.Add(this.logEUNE);
            this.Controls.Add(this.logEUW);
            this.Controls.Add(this.logNA);
            this.Controls.Add(this.logOceanic);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lolEUNEPing);
            this.Controls.Add(this.lolEUWPing);
            this.Controls.Add(this.lolNAPing);
            this.Controls.Add(this.lolOceanicPing);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.Server_Title);
            this.Controls.Add(this.lolEUNELabel);
            this.Controls.Add(this.lolEUNEStop);
            this.Controls.Add(this.lolEUWLabel);
            this.Controls.Add(this.lolEUWStop);
            this.Controls.Add(this.lolNALabel);
            this.Controls.Add(this.lolEUNEStart);
            this.Controls.Add(this.lolNAStop);
            this.Controls.Add(this.lolEUWStart);
            this.Controls.Add(this.lolOceanicLabel);
            this.Controls.Add(this.lolNAStart);
            this.Controls.Add(this.lolOceanicStop);
            this.Controls.Add(this.lolOceanicStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 366);
            this.Name = "Form1";
            this.Text = "LoL Pre-game Ping Checker By: Arian Jahiri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lolOceanicStart;
        private System.Windows.Forms.Button lolOceanicStop;
        private System.Windows.Forms.Label lolOceanicLabel;
        private System.Windows.Forms.Label Server_Title;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label lolOceanicPing;
        private System.Windows.Forms.Timer lolOCETimer;
        private System.Windows.Forms.Button lolNAStart;
        private System.Windows.Forms.Button lolNAStop;
        private System.Windows.Forms.Label lolNALabel;
        private System.Windows.Forms.Label lolNAPing;
        private System.Windows.Forms.Timer lolNATimer;
        private System.Windows.Forms.Button lolEUWStart;
        private System.Windows.Forms.Button lolEUWStop;
        private System.Windows.Forms.Label lolEUWLabel;
        private System.Windows.Forms.Label lolEUWPing;
        private System.Windows.Forms.Timer lolEUWTimer;
        private System.Windows.Forms.Button lolEUNEStart;
        private System.Windows.Forms.Button lolEUNEStop;
        private System.Windows.Forms.Label lolEUNELabel;
        private System.Windows.Forms.Label lolEUNEPing;
        private System.Windows.Forms.Timer lolEUNETimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Copyright;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.RadioButton logOceanic;
        private System.Windows.Forms.RadioButton logNA;
        private System.Windows.Forms.RadioButton logEUW;
        private System.Windows.Forms.RadioButton logEUNE;
        private System.Windows.Forms.Label logToggleLabel;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button saveLogButton;
        private System.Windows.Forms.Label pingLog;
    }
}

