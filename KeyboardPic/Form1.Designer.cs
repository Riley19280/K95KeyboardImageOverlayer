namespace KeyboardPic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAvgColor = new System.Windows.Forms.ToolStripMenuItem();
            this.colorModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostOftenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightingOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertBWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TEMPLATE = new System.Windows.Forms.PictureBox();
            this.lblBrightnessInc = new System.Windows.Forms.Label();
            this.txtBrightness = new System.Windows.Forms.MaskedTextBox();
            this.chkMaxBrightness = new System.Windows.Forms.CheckBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMPLATE)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuAvgColor,
            this.startToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1429, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuAvgColor
            // 
            this.mnuAvgColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorModeToolStripMenuItem,
            this.outputModeToolStripMenuItem,
            this.invertBWToolStripMenuItem,
            this.realColorToolStripMenuItem});
            this.mnuAvgColor.Name = "mnuAvgColor";
            this.mnuAvgColor.Size = new System.Drawing.Size(61, 20);
            this.mnuAvgColor.Text = "Options";
            // 
            // colorModeToolStripMenuItem
            // 
            this.colorModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostOftenToolStripMenuItem,
            this.avergeToolStripMenuItem,
            this.brightestToolStripMenuItem});
            this.colorModeToolStripMenuItem.Name = "colorModeToolStripMenuItem";
            this.colorModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorModeToolStripMenuItem.Text = "Color Mode";
            // 
            // mostOftenToolStripMenuItem
            // 
            this.mostOftenToolStripMenuItem.Checked = true;
            this.mostOftenToolStripMenuItem.CheckOnClick = true;
            this.mostOftenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostOftenToolStripMenuItem.Name = "mostOftenToolStripMenuItem";
            this.mostOftenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mostOftenToolStripMenuItem.Text = "Most Often";
            this.mostOftenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.mostOftenToolStripMenuItem_CheckedChanged);
            // 
            // avergeToolStripMenuItem
            // 
            this.avergeToolStripMenuItem.CheckOnClick = true;
            this.avergeToolStripMenuItem.Name = "avergeToolStripMenuItem";
            this.avergeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avergeToolStripMenuItem.Text = "Averge";
            this.avergeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.avergeToolStripMenuItem_CheckedChanged);
            // 
            // brightestToolStripMenuItem
            // 
            this.brightestToolStripMenuItem.CheckOnClick = true;
            this.brightestToolStripMenuItem.Name = "brightestToolStripMenuItem";
            this.brightestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brightestToolStripMenuItem.Text = "Brightest";
            this.brightestToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.brightestToolStripMenuItem_CheckedChanged);
            // 
            // outputModeToolStripMenuItem
            // 
            this.outputModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullProfileToolStripMenuItem,
            this.lightingOnlyToolStripMenuItem});
            this.outputModeToolStripMenuItem.Name = "outputModeToolStripMenuItem";
            this.outputModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.outputModeToolStripMenuItem.Text = "Output Mode";
            // 
            // fullProfileToolStripMenuItem
            // 
            this.fullProfileToolStripMenuItem.Checked = true;
            this.fullProfileToolStripMenuItem.CheckOnClick = true;
            this.fullProfileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullProfileToolStripMenuItem.Name = "fullProfileToolStripMenuItem";
            this.fullProfileToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.fullProfileToolStripMenuItem.Text = "Full Profile";
            this.fullProfileToolStripMenuItem.CheckedChanged += new System.EventHandler(this.fullProfileToolStripMenuItem_CheckedChanged);
            // 
            // lightingOnlyToolStripMenuItem
            // 
            this.lightingOnlyToolStripMenuItem.CheckOnClick = true;
            this.lightingOnlyToolStripMenuItem.Name = "lightingOnlyToolStripMenuItem";
            this.lightingOnlyToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.lightingOnlyToolStripMenuItem.Text = "Lighting Only";
            this.lightingOnlyToolStripMenuItem.CheckedChanged += new System.EventHandler(this.lightingOnlyToolStripMenuItem_CheckedChanged);
            // 
            // invertBWToolStripMenuItem
            // 
            this.invertBWToolStripMenuItem.CheckOnClick = true;
            this.invertBWToolStripMenuItem.Name = "invertBWToolStripMenuItem";
            this.invertBWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.invertBWToolStripMenuItem.Text = "Invert B/W";
            this.invertBWToolStripMenuItem.DoubleClick += new System.EventHandler(this.invertBWToolStripMenuItem_DoubleClick);
            // 
            // realColorToolStripMenuItem
            // 
            this.realColorToolStripMenuItem.CheckOnClick = true;
            this.realColorToolStripMenuItem.Name = "realColorToolStripMenuItem";
            this.realColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.realColorToolStripMenuItem.Text = "Real Color";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.startToolStripMenuItem.Text = "Start!";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 311);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1080, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // TEMPLATE
            // 
            this.TEMPLATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TEMPLATE.Image = ((System.Drawing.Image)(resources.GetObject("TEMPLATE.Image")));
            this.TEMPLATE.Location = new System.Drawing.Point(1419, 27);
            this.TEMPLATE.Name = "TEMPLATE";
            this.TEMPLATE.Size = new System.Drawing.Size(10, 10);
            this.TEMPLATE.TabIndex = 3;
            this.TEMPLATE.TabStop = false;
            this.TEMPLATE.Visible = false;
            // 
            // lblBrightnessInc
            // 
            this.lblBrightnessInc.AutoSize = true;
            this.lblBrightnessInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightnessInc.Location = new System.Drawing.Point(1130, 52);
            this.lblBrightnessInc.Name = "lblBrightnessInc";
            this.lblBrightnessInc.Size = new System.Drawing.Size(177, 17);
            this.lblBrightnessInc.TabIndex = 5;
            this.lblBrightnessInc.Text = "Brightnes Increase (0-255)";
            // 
            // txtBrightness
            // 
            this.txtBrightness.AllowPromptAsInput = false;
            this.txtBrightness.Location = new System.Drawing.Point(1313, 52);
            this.txtBrightness.Mask = "000";
            this.txtBrightness.Name = "txtBrightness";
            this.txtBrightness.PromptChar = ' ';
            this.txtBrightness.ShortcutsEnabled = false;
            this.txtBrightness.Size = new System.Drawing.Size(100, 20);
            this.txtBrightness.TabIndex = 6;
            this.txtBrightness.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // chkMaxBrightness
            // 
            this.chkMaxBrightness.AutoSize = true;
            this.chkMaxBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaxBrightness.Location = new System.Drawing.Point(1133, 81);
            this.chkMaxBrightness.Name = "chkMaxBrightness";
            this.chkMaxBrightness.Size = new System.Drawing.Size(123, 21);
            this.chkMaxBrightness.TabIndex = 7;
            this.chkMaxBrightness.Text = "Max Brightness";
            this.chkMaxBrightness.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 580);
            this.Controls.Add(this.chkMaxBrightness);
            this.Controls.Add(this.txtBrightness);
            this.Controls.Add(this.lblBrightnessInc);
            this.Controls.Add(this.TEMPLATE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "K95 Imager Overlayer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(216)))));
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMPLATE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAvgColor;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox TEMPLATE;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostOftenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightingOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertBWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realColorToolStripMenuItem;
        private System.Windows.Forms.Label lblBrightnessInc;
        private System.Windows.Forms.ToolStripMenuItem brightestToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtBrightness;
        private System.Windows.Forms.CheckBox chkMaxBrightness;
    }
}

