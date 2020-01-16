using SpinTheWheel.Data;
using SpinTheWheel.Properties;
using SpinTheWheel.Utility;
using SpinTheWheel.Utility.Data;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SpinTheWheel.Forms
{
    public partial class FormStudents : Form
    {
        #region Constants

        private const string FIRST_NAME = "FirstName";
        private const string LAST_NAME = "LastName";
        private const string NUMBER = "Number";

        #endregion

        #region Private Variables

        private BindingSource bindingSource;
        private List<Student> students;

        #endregion

        #region Properties

        public List<Student> Students { get; set; }

        #endregion

        public FormStudents()
        {
            InitializeComponent();
        }


        private void FormStudents_Load(object sender, EventArgs e)
        {
            students = new List<Student>();
            foreach (var student in Students)
                students.Add(student.Clone());

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = CreateDataTable();
            bindingSource.CurrentChanged += BindingSource_CurrentChanged;

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = FIRST_NAME,
                DataPropertyName = "FirstName",
                HeaderText = "First Name",
                Tag = FIRST_NAME
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = LAST_NAME,
                DataPropertyName = "LastName",
                HeaderText = "Last Name",
                Tag = LAST_NAME
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = NUMBER,
                DataPropertyName = "Number",
                HeaderText = "No",
                Tag = NUMBER
            });

            dataGridView.DataSource = bindingSource;
        }


        #region DataGridView Functions

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private System.Data.DataTable CreateDataTable()
        {
            var table = new CustomDataTable();
            bool isFirst = true;

            // without Linq
            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                if (isFirst)
                {
                    table.Columns.Add(FIRST_NAME);
                    table.Columns.Add(LAST_NAME);
                    table.Columns.Add(NUMBER);
                    isFirst = false;
                }

                var dataRow = (CustomDataRow)table.NewRow();
                dataRow.ItemArray = new string[] { student.FirstName, student.LastName, student.Number.ToString() };
                dataRow.Tag = student;

                table.Rows.Add(dataRow);
            }

            return table;
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                var propertyName = (string)dataGridView.Columns[e.ColumnIndex].Tag;
                var dataView = (DataRowView)bindingSource.Current;
                var dataRow = (CustomDataRow)dataView.Row;
                var newValue = dataView.Row.Field<string>(propertyName);
                var student = (Student)dataRow.Tag;

                student.GetType().GetProperty(propertyName).SetValue(student, newValue, null);
            }
        }

        private void dataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            dataGridView.CurrentCell = dataGridView[e.ColumnIndex, e.RowIndex];
            e.ContextMenuStrip = new ContextMenuStrip();
            e.ContextMenuStrip.Items.Add("Remove", Resources.delete, dataGridView_ContextMenuDeleteClicked);
            e.ContextMenuStrip.Show(Cursor.Position);
        }

        private void dataGridView_ContextMenuDeleteClicked(object sender, EventArgs e)
        {
            if (bindingSource?.Current != null)
            {
                if (MessageBoxHelper.QuestionYesNo(this, "Warning", "Are you sure about to remove selected student?") == DialogResult.Yes)
                {
                    var dataView = (DataRowView)bindingSource.Current;
                    var dataRow = (CustomDataRow)dataView.Row;
                    var student = (Student)dataRow.Tag;

                    students.Remove(student);
                    dataView.Delete();
                }
            }
        }


        #endregion

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void AddStudent()
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxSurname.Text) ||
                string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBoxHelper.ShowWarning(this, "Please fill all the blanks.");

                if (string.IsNullOrEmpty(textBoxName.Text))
                    textBoxName.Focus();
                else if (string.IsNullOrEmpty(textBoxSurname.Text))
                    textBoxSurname.Focus();
                else if (string.IsNullOrEmpty(textBoxNumber.Text))
                    textBoxNumber.Focus();
            }
            else
            {
                var number = 0;
                if (int.TryParse(textBoxNumber.Text, out number))
                {
                    students.Add(new Student()
                    {
                        FirstName = textBoxName.Text,
                        LastName = textBoxSurname.Text,
                        Number = number
                    });

                    RefreshDataGridView();

                    textBoxName.Text = string.Empty;
                    textBoxSurname.Text = string.Empty;
                    textBoxNumber.Text = string.Empty;

                    textBoxName.Focus();
                }
                else
                    MessageBoxHelper.ShowError(this, "Please enter student number.");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Students = students;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddStudent();
                e.Handled = true;
            }
        }
    }
}
