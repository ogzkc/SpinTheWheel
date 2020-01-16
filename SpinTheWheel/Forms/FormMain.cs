using SpinTheWheel.Data;
using SpinTheWheel.Enum;
using SpinTheWheel.Utility;
using SpinTheWheel.Utility.SettingsManager.Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpinTheWheel.Forms
{
    public partial class FormMain : Form
    {
        private List<Student> students;

        public FormMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            students = StudentLoader.Load();

            spinnerWheel.Students = students;
            spinnerWheel.AnimationEnabled = SettingsManager.Instance.Get(SettingName.ANIMATION_ENABLED, true);
            spinnerWheel.AnimationEndWaitDuration = SettingsManager.Instance.Get(SettingName.ANIMATION_WAIT_DURATION, 2500);
            spinnerWheel.FontSize = SettingsManager.Instance.Get(SettingName.FONT_SIZE, 9);

            spinnerWheel.RefreshSpinner();

            spinnerWheel.OnStudentSelected += SpinnerWheel_OnStudentSelected;

            labelClassName.Text = SettingsManager.Instance.Get(SettingName.CLASS_NAME, "Name of Classroom");

            labelClassName.Font = FontHelper.GetFont(labelClassName.Font.Size);
            labelSelectedStudent.Font = FontHelper.GetFont(labelSelectedStudent.Font.Size);
        }

        private void SpinnerWheel_OnStudentSelected(object sender, Controls.Events.StudentSelectedEventArgs e)
        {
            labelSelectedStudent.Text = e.Student.FirstName + " " + e.Student.LastName + Environment.NewLine + "No: " + e.Student.Number;
        }

        private void toolStripMenuItemFileSettings_Click(object sender, EventArgs e)
        {
            var formSettings = new FormSettings()
            {
                Students = students
            };
            if (formSettings.ShowDialog(this) == DialogResult.OK)
            {
                labelClassName.Text = SettingsManager.Instance.Get(SettingName.CLASS_NAME, string.Empty);
                spinnerWheel.AnimationEndWaitDuration = SettingsManager.Instance.Get(SettingName.ANIMATION_WAIT_DURATION, 2500);

                if (formSettings.StudentsChanged)
                {
                    students = formSettings.Students;
                    StudentLoader.Save(students);
                }

                spinnerWheel.Students = students;
                spinnerWheel.FontSize = SettingsManager.Instance.Get(SettingName.FONT_SIZE, 9);
                spinnerWheel.RefreshSpinner();
            }

        }

        private void toolStripMenuItemHelpAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }
    }
}
