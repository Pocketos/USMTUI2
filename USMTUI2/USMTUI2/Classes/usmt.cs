using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USMTUI2.Classes;

//Parameters for scanstate.exe and loadstate.exe

namespace USMTUI2.Classes
{
    class Usmt
    {
        public void UsmtBackup(string svrName, string folderName)
        {
            //Create static varaibles


            //Generate the variables being passed to the executable
            string xmldir = svrName + ConfigurationManager.AppSettings.Get("FilesPath");
            string configdir = svrName + ConfigurationManager.AppSettings.Get("FilesPath");
            string filelogdir = svrName + ConfigurationManager.AppSettings.Get("dataPath") + folderName + "\\Logs";
            string logdir = svrName + ConfigurationManager.AppSettings.Get("dataPath") + folderName + "\\Logs";
            string args = svrName + ConfigurationManager.AppSettings.Get("dataPath") + folderName + " / i:" + xmldir + "\\migapp.xml / i:" + xmldir + "\\miguser.xml / i:" + xmldir + "\\custom.xml / config:" + configdir + "\\config.xml / uel:90 / c / v:13 / listfiles:" + filelogdir + "\\scan_files.txt / l:" + logdir + "\\scan_log.txt";
            string BackupRunPath = "cmd /c " + svrName + ConfigurationManager.AppSettings.Get("scanstatePath") + args;

            //Debugbox
            Messages.OKMessage(BackupRunPath);
        }

        public void UsmtRestore(string svrName, string folderName)
        {
            //Generate the variables being passed to the executable
            string xmldir = svrName + ConfigurationManager.AppSettings.Get("FilesPath");
            string configdir = svrName + ConfigurationManager.AppSettings.Get("FilesPath");
            string filelogdir = svrName + ConfigurationManager.AppSettings.Get("dataPath") + folderName + "\\Logs";
            string logdir = svrName + ConfigurationManager.AppSettings.Get("dataPath") + folderName + "\\Logs";
            string RestoreArgs = svrName + ConfigurationManager.AppSettings.Get("dataPath") + folderName + " / i:" + xmldir + "\\migapp.xml / i:" + xmldir + "\\miguser.xml / i:" + xmldir + "\\custom.xml / config:" + configdir + "\\config.xml / lac / uel:90 / v:13 / c / l:" + logdir + "\\load_log.txt";
            string RestoreRunPath = "cmd /c " + svrName + ConfigurationManager.AppSettings.Get("loadstatePath") + RestoreArgs;

            //Debugbox
            Messages.OKMessage(RestoreRunPath);
        }
    }
}
