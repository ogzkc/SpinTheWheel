namespace SpinTheWheel.Controls
{
    partial class SpinnerWheel
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
            this.nonFlickerPanel = new SpinTheWheel.Utility.Components.NonFlickerPanel();
            this.buttonSpinWheel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nonFlickerPanel
            // 
            this.nonFlickerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonFlickerPanel.Location = new System.Drawing.Point(0, 0);
            this.nonFlickerPanel.Name = "nonFlickerPanel";
            this.nonFlickerPanel.Size = new System.Drawing.Size(500, 500);
            this.nonFlickerPanel.TabIndex = 0;
            this.nonFlickerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.nonFlickerPanel_Paint);
            // 
            // buttonSpinWheel
            // 
            this.buttonSpinWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpinWheel.Location = new System.Drawing.Point(287, 522);
            this.buttonSpinWheel.Name = "buttonSpinWheel";
            this.buttonSpinWheel.Size = new System.Drawing.Size(210, 25);
            this.buttonSpinWheel.TabIndex = 1;
            this.buttonSpinWheel.Text = "Spin the Wheel!";
            this.buttonSpinWheel.UseVisualStyleBackColor = true;
            this.buttonSpinWheel.Click += new System.EventHandler(this.buttonSpinWheel_Click);
            // 
            // SpinnerWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSpinWheel);
            this.Controls.Add(this.nonFlickerPanel);
            this.Name = "SpinnerWheel";
            this.Size = new System.Drawing.Size(500, 550);
            this.Load += new System.EventHandler(this.SpinnerWheel_Load);
            this.Resize += new System.EventHandler(this.SpinnerWheel_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.Components.NonFlickerPanel nonFlickerPanel;
        private System.Windows.Forms.Button buttonSpinWheel;
    }
}
