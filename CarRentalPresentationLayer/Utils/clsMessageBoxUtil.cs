using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Utils
{
    internal static class clsMessageBoxUtil
    {
        internal static void ShowError(string Message)
        {
            System.Windows.Forms.MessageBox.Show(
                Message, 
                "Error",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }

        internal static DialogResult ShowWarning(string Message, 
            MessageBoxButtons MBButtons = MessageBoxButtons.OKCancel)
        {
             return System.Windows.Forms.MessageBox.Show(
                Message,
                "Warning",
                MBButtons,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }

        internal static void ShowSuccesMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(
                Message,
                "Success!",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }

    }
}
