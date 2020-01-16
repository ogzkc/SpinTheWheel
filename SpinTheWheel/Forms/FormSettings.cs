using SpinTheWheel.Data;
using SpinTheWheel.Enum;
using SpinTheWheel.Utility.SettingsManager.Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpinTheWheel.Forms
{
    public partial class FormSettings : Form
    {
        public bool StudentsChanged { get; private set; }
        public List<Student> Students { get; set; }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            checkBoxPickAgain.Checked = SettingsManager.Instance.Get(SettingName.PICK_STUDENT_AGAIN, true);
            numericUpDownPickStudentCount.Value = SettingsManager.Instance.Get(SettingName.PICK_STUDENT_COUNT, 0);

            checkBoxAnimationActive.Checked = SettingsManager.Instance.Get(SettingName.ANIMATION_ENABLED, true);

            textBoxClassName.Text = SettingsManager.Instance.Get(SettingName.CLASS_NAME, "Name of classroom");

            numericUpDownAnimationWaitDuration.Value = SettingsManager.Instance.Get(SettingName.ANIMATION_WAIT_DURATION, (int)2500);

            numericUpDownFontSize.Value = SettingsManager.Instance.Get(SettingName.FONT_SIZE, (int)9);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SettingsManager.Instance.Set(SettingName.PICK_STUDENT_AGAIN, checkBoxPickAgain.Checked);
            SettingsManager.Instance.Set(SettingName.PICK_STUDENT_COUNT, (int)numericUpDownPickStudentCount.Value);

            SettingsManager.Instance.Set(SettingName.ANIMATION_ENABLED, checkBoxAnimationActive.Checked);

            SettingsManager.Instance.Set(SettingName.ANIMATION_WAIT_DURATION, (int)numericUpDownAnimationWaitDuration.Value);
            SettingsManager.Instance.Set(SettingName.FONT_SIZE, (int)numericUpDownFontSize.Value);

            SettingsManager.Instance.Set(SettingName.CLASS_NAME, textBoxClassName.Text);

            DialogResult = DialogResult.OK;
        }

        private void buttonEditStudentList_Click(object sender, EventArgs e)
        {
            var formStudents = new FormStudents()
            {
                Students = Students
            };

            if (formStudents.ShowDialog(this) == DialogResult.OK)
            {
                StudentsChanged = true;
                Students = formStudents.Students;
            }
        }

        private void checkBoxPickAgain_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownPickStudentCount.Enabled = !checkBoxPickAgain.Checked;
        }
    }
}
