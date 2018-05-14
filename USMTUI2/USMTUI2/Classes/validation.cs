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
        public static int ValidateServername(string svrName)
        {
            string shareName = svrName + "\\Filesx64";
            if(Directory.Exists(shareName))
            {
                Messages.OKMessage("Server path OK!");
                return 1;
            }
            else
            {
                Messages.ErrorMessage("Server path invalid!");
                return 0;
            }
        }

        public bool GetArch()
        {
            //Get the computer's architecture so we know hwat version of USMT to run
            bool is64bit = !string.IsNullOrEmpty(
                Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            return is64bit;
        }
    }
}
