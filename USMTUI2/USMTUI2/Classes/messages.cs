using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Provides templates for various message boxes or prompts.

namespace USMTUI2.Classes
{
    public class Messages
    {
        public static void ErrorMessage(string errmsg)
        {
            //Display an error message
            MessageBox.Show(errmsg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void OKMessage(string okmsg)
        {
            //Display an 'OK' message
            MessageBox.Show(okmsg, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
