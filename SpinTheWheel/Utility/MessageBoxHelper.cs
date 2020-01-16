using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinTheWheel.Utility
{
    public class MessageBoxHelper
    {
        private const string WARNING = "Warning";
        private const string ERROR = "Error";
        private const string INFO = "Info";

        public static void ShowWarning(string message) => ShowWarning(null, WARNING, message);
        public static void ShowWarning(IWin32Window owner, string message) => ShowWarning(owner, WARNING, message);
        public static void ShowWarning(IWin32Window owner, string title, string message)
        {
            if (owner != null)
                MessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static void ShowError(string message) => ShowError(ERROR, message);
        public static void ShowError(string title, string message) => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowError(IWin32Window owner, string message) => ShowError(owner, ERROR, message);
        public static void ShowError(IWin32Window owner, string title, string message) => MessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void ShowInfo(IWin32Window owner, string message) => ShowInfo(owner, message, INFO);
        public static void ShowInfo(IWin32Window owner, string title, string message) => MessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static DialogResult QuestionYesNo(IWin32Window owner, string title, string message, bool showCancel = false)
        {
            if (showCancel)
                return MessageBox.Show(owner, message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            else
                return MessageBox.Show(owner, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }

}
