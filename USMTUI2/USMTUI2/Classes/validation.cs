using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USMTUI2.Classes;

//Handels the servername, executable, and data locations for the USMT tool.

namespace USMTUI2.Classes
{
    class Validation
    {
        public static void ValidateServername(string svrName)
        {
            if(Directory.Exists(svrName))
            {
                Messages.OKMessage("Server path OK!");
            }
            else
            {
                Messages.ErrorMessage("Nope!");
            }
        }
    }
}
