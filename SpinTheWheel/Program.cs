using SpinTheWheel.Data;
using SpinTheWheel.Forms;
using SpinTheWheel.Utility;
using SpinTheWheel.Utility.SettingsManager.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinTheWheel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // testing with random students, just comment this line out in prod.
            CreateRandomStudents();

            SettingsManager.Instance.AutoSave = true;
            SettingsManager.Instance.Load("settings.json");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void CreateRandomStudents()
        {
            var students = StudentLoader.Load();
            if (students != null && students.Count < 1)
            {
                students = new List<Student>();
                var random = new Random();
                for (int i = 0; i < 30; i++)
                {
                    students.Add(new Student()
                    {
                        FirstName = StringHelper.RandomFirstName(random),
                        LastName = StringHelper.RandomLastName(random),
                        Number = random.Next(1000, 9000)
                    });
                }

                StudentLoader.Save(students);
            }
        }
    }
}
