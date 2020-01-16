namespace SpinTheWheel.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSelectedStudent = new System.Windows.Forms.Label();
            this.spinnerWheel = new SpinTheWheel.Controls.SpinnerWheel();
            this.labelClassName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileSettings});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dosyaToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemFileSettings
            // 
            this.toolStripMenuItemFileSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFileSettings.Image")));
            this.toolStripMenuItemFileSettings.Name = "toolStripMenuItemFileSettings";
            this.toolStripMenuItemFileSettings.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFileSettings.Text = "Ayarlar";
            this.toolStripMenuItemFileSettings.Click += new System.EventHandler(this.toolStripMenuItemFileSettings_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelpAbout});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.yardımToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItemHelpAbout
            // 
            this.toolStripMenuItemHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemHelpAbout.Image")));
            this.toolStripMenuItemHelpAbout.Name = "toolStripMenuItemHelpAbout";
            this.toolStripMenuItemHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemHelpAbout.Text = "Help";
            this.toolStripMenuItemHelpAbout.Click += new System.EventHandler(this.toolStripMenuItemHelpAbout_Click);
            // 
            // labelSelectedStudent
            // 
            this.labelSelectedStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSelectedStudent.Location = new System.Drawing.Point(598, 85);
            this.labelSelectedStudent.Name = "labelSelectedStudent";
            this.labelSelectedStudent.Size = new System.Drawing.Size(482, 543);
            this.labelSelectedStudent.TabIndex = 2;
            this.labelSelectedStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spinnerWheel
            // 
            this.spinnerWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerWheel.AnimationDuration = 1800;
            this.spinnerWheel.AnimationEnabled = true;
            this.spinnerWheel.AnimationEndWaitDuration = 2500;
            this.spinnerWheel.FontSize = 9;
            this.spinnerWheel.Location = new System.Drawing.Point(12, 27);
            this.spinnerWheel.Name = "spinnerWheel";
            this.spinnerWheel.Size = new System.Drawing.Size(580, 601);
            this.spinnerWheel.Students = null;
            this.spinnerWheel.TabIndex = 1;
            // 
            // labelClassName
            // 
            this.labelClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelClassName.Location = new System.Drawing.Point(598, 27);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(482, 58);
            this.labelClassName.TabIndex = 3;
            this.labelClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 646);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.labelSelectedStudent);
            this.Controls.Add(this.spinnerWheel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 520);
            this.Name = "FormMain";
            this.Text = "Spin the Wheel";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileSettings;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelpAbout;
        private Controls.SpinnerWheel spinnerWheel;
        private System.Windows.Forms.Label labelSelectedStudent;
        private System.Windows.Forms.Label labelClassName;
    }
}

