namespace SpinTheWheel.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPickAgain = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAnimationActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPickStudentCount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.buttonEditStudentList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownAnimationWaitDuration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickStudentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationWaitDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(200, 300);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(281, 300);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected student can be re-elected in during the day";
            // 
            // checkBoxPickAgain
            // 
            this.checkBoxPickAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPickAgain.AutoSize = true;
            this.checkBoxPickAgain.Checked = true;
            this.checkBoxPickAgain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPickAgain.Enabled = false;
            this.checkBoxPickAgain.Location = new System.Drawing.Point(341, 41);
            this.checkBoxPickAgain.Margin = new System.Windows.Forms.Padding(8);
            this.checkBoxPickAgain.Name = "checkBoxPickAgain";
            this.checkBoxPickAgain.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPickAgain.TabIndex = 3;
            this.checkBoxPickAgain.UseVisualStyleBackColor = true;
            this.checkBoxPickAgain.CheckedChanged += new System.EventHandler(this.checkBoxPickAgain_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Animation";
            // 
            // checkBoxAnimationActive
            // 
            this.checkBoxAnimationActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAnimationActive.AutoSize = true;
            this.checkBoxAnimationActive.Checked = true;
            this.checkBoxAnimationActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnimationActive.Location = new System.Drawing.Point(341, 241);
            this.checkBoxAnimationActive.Margin = new System.Windows.Forms.Padding(8);
            this.checkBoxAnimationActive.Name = "checkBoxAnimationActive";
            this.checkBoxAnimationActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnimationActive.TabIndex = 8;
            this.checkBoxAnimationActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selecting Student";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.Gray;
            this.panel.Location = new System.Drawing.Point(12, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 1);
            this.panel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Limit of selection of a student during the day (0 is unlimited)";
            // 
            // numericUpDownPickStudentCount
            // 
            this.numericUpDownPickStudentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPickStudentCount.Enabled = false;
            this.numericUpDownPickStudentCount.Location = new System.Drawing.Point(315, 64);
            this.numericUpDownPickStudentCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPickStudentCount.Name = "numericUpDownPickStudentCount";
            this.numericUpDownPickStudentCount.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownPickStudentCount.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 1);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "General";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Student List";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name of Classroom";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(242, 158);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(114, 20);
            this.textBoxClassName.TabIndex = 20;
            // 
            // buttonEditStudentList
            // 
            this.buttonEditStudentList.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditStudentList.Image")));
            this.buttonEditStudentList.Location = new System.Drawing.Point(332, 90);
            this.buttonEditStudentList.Name = "buttonEditStudentList";
            this.buttonEditStudentList.Size = new System.Drawing.Size(24, 24);
            this.buttonEditStudentList.TabIndex = 18;
            this.buttonEditStudentList.UseVisualStyleBackColor = true;
            this.buttonEditStudentList.Click += new System.EventHandler(this.buttonEditStudentList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Delay after animation (in ms.)";
            // 
            // numericUpDownAnimationWaitDuration
            // 
            this.numericUpDownAnimationWaitDuration.Location = new System.Drawing.Point(242, 184);
            this.numericUpDownAnimationWaitDuration.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownAnimationWaitDuration.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAnimationWaitDuration.Name = "numericUpDownAnimationWaitDuration";
            this.numericUpDownAnimationWaitDuration.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownAnimationWaitDuration.TabIndex = 22;
            this.numericUpDownAnimationWaitDuration.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.Location = new System.Drawing.Point(242, 210);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownFontSize.TabIndex = 24;
            this.numericUpDownFontSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Font Size";
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(368, 335);
            this.Controls.Add(this.numericUpDownFontSize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownAnimationWaitDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonEditStudentList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPickStudentCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxAnimationActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxPickAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPickStudentCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationWaitDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPickAgain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAnimationActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPickStudentCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEditStudentList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownAnimationWaitDuration;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.Label label9;
    }
}