using System;
using System.Windows.Forms;
using System.Collections.Generic;
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
            string xmldir = svrName + "\\Filesx64";
            string configdir = svrName + "\\Filesx64";
            string filelogdir = svrName + "\\data\\" + folderName + "\\Logs";
            string logdir = svrName + "\\data\\" + folderName + "\\Logs";
            string args = svrName + "\\data\\" + folderName + " / i:" + xmldir + "\\migapp.xml / i:" + xmldir + "\\miguser.xml / i:" + xmldir + "\\custom.xml / config:" + configdir + "\\config.xml / uel:90 / c / v:13 / listfiles:" + filelogdir + "\\scan_files.txt / l:" + logdir + "\\scan_log.txt";
            string BackupRunPath = "cmd /c " + svrName + "\\Filesx64\\scanstate.exe " + args;

            //Debugbox
            Messages.OKMessage(BackupRunPath);
        }

        public void UsmtRestore(string svrName, string folderName)
        {
            //Generate the variables being passed to the executable
            string xmldir = svrName + "\\Filesx64";
            string configdir = svrName + "\\Filesx64";
            string filelogdir = svrName + "\\data\\" + folderName + "\\Logs";
            string logdir = svrName + "\\data\\" + folderName + "\\Logs";
            string args = svrName + "\\data\\" + folderName + " / i:" + xmldir + "\\migapp.xml / i:" + xmldir + "\\miguser.xml / i:" + xmldir + "\\custom.xml / config:" + configdir + "\\config.xml / uel:90 / c / v:13 / listfiles:" + filelogdir + "\\scan_files.txt / l:" + logdir + "\\scan_log.txt";
            string RestoreArgs = svrName + "\\data\\" + folderName + " / i:" + xmldir + "\\migapp.xml / i:" + xmldir + "\\miguser.xml / i:" + xmldir + "\\custom.xml / config:" + configdir + "\\config.xml / lac / uel:90 / v:13 / c / l:" + logdir + "\\load_log.txt";
            string RestoreRunPath = "cmd /c " + svrName + "\\Filesx64\\loadstate.exe " + RestoreArgs;

            //Debugbox
            Messages.OKMessage(RestoreRunPath);
        }
    }
}
