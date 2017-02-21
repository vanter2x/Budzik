namespace budzik
{
    partial class Budzik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budzik));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnH = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.trIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsStart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.cRem = new System.Windows.Forms.ToolStripMenuItem();
            this.cClose = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsMenu.SuspendLayout();
            this.cmsStart.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas:";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarm.Location = new System.Drawing.Point(219, 42);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(114, 23);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "--:--:--";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(219, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(114, 23);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextChanged += new System.EventHandler(this.Alarm);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alarm:";
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(20, 195);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(40, 36);
            this.btnH.TabIndex = 4;
            this.btnH.Text = "00";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.TextChanged += new System.EventHandler(this.btnChange);
            this.btnH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeChange);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(66, 195);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(40, 36);
            this.btnM.TabIndex = 5;
            this.btnM.Text = "00";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.TextChanged += new System.EventHandler(this.btnChange);
            this.btnM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeChange);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(112, 195);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(40, 36);
            this.btnS.TabIndex = 6;
            this.btnS.Text = "00";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.TextChanged += new System.EventHandler(this.btnChange);
            this.btnS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeChange);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(167, 195);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 36);
            this.btnStart.TabIndex = 7;
            this.btnStart.Tag = "1";
            this.btnStart.Text = "Alarm";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmcZmiana);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShow,
            this.mnuStop,
            this.mnuClose});
            this.cmsMenu.Name = "contextMenuStrip1";
            this.cmsMenu.Size = new System.Drawing.Size(167, 92);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(166, 22);
            this.mnuShow.Text = "Pokaż";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Enabled = false;
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.Size = new System.Drawing.Size(166, 22);
            this.mnuStop.Text = "Wyłącz alarm";
            this.mnuStop.Visible = false;
            this.mnuStop.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(166, 22);
            this.mnuClose.Text = "Zamknij program";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // trIcon
            // 
            this.trIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trIcon.Icon")));
            this.trIcon.Text = "Budzik";
            this.trIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowMenu);
            // 
            // cmsStart
            // 
            this.cmsStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAlarm,
            this.cRem,
            this.cClose});
            this.cmsStart.Name = "cmsStart";
            this.cmsStart.Size = new System.Drawing.Size(158, 70);
            // 
            // cAlarm
            // 
            this.cAlarm.Name = "cAlarm";
            this.cAlarm.Size = new System.Drawing.Size(157, 22);
            this.cAlarm.Text = "Alarm";
            this.cAlarm.Click += new System.EventHandler(this.procZmiana);
            // 
            // cRem
            // 
            this.cRem.Name = "cRem";
            this.cRem.Size = new System.Drawing.Size(157, 22);
            this.cRem.Text = "Przypomnienie";
            this.cRem.Click += new System.EventHandler(this.procZmiana);
            // 
            // cClose
            // 
            this.cClose.Name = "cClose";
            this.cClose.Size = new System.Drawing.Size(157, 22);
            this.cClose.Text = "Zamknij system";
            this.cClose.Click += new System.EventHandler(this.procZmiana);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zamknij system:";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(219, 88);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(114, 23);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "--:--:--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Przypomnienie:";
            // 
            // lblRem
            // 
            this.lblRem.AutoSize = true;
            this.lblRem.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRem.Location = new System.Drawing.Point(219, 65);
            this.lblRem.Name = "lblRem";
            this.lblRem.Size = new System.Drawing.Size(114, 23);
            this.lblRem.TabIndex = 12;
            this.lblRem.Text = "--:--:--";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 76);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tekst przypomnienia(max.90znaków):";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(13, 16);
            this.txtRem.MaxLength = 90;
            this.txtRem.Multiline = true;
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(293, 54);
            this.txtRem.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Masz ustawione przypomnienie!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Budzik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(351, 243);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Budzik";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.TrayIcon);
            this.cmsMenu.ResumeLayout(false);
            this.cmsStart.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.NotifyIcon trIcon;
        private System.Windows.Forms.ContextMenuStrip cmsStart;
        private System.Windows.Forms.ToolStripMenuItem cAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.ToolStripMenuItem cRem;
        private System.Windows.Forms.ToolStripMenuItem cClose;
        private System.Windows.Forms.Label label3;
    }
}

