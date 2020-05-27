using MetroFramework;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NURESCADA.DB
{
    static class MSG
    {
        private static short height = 100;
        private static string header;
        public static DialogResult Show(IWin32Window owner, string text, MessageBoxButtons button, MessageBoxIcon icon, Logger logger)
        {
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    header = "Information";
                    logger.Info(text);
                    break;
                case MessageBoxIcon.Question:
                    header = "Question";
                    logger.Info(text);
                    break;
                case MessageBoxIcon.Warning:
                    header = "Warning";
                    logger.Warn(text);
                    break;
                case MessageBoxIcon.Error:
                    header = "Error";
                    logger.Error(text);
                    break;
                default:
                    header = "Message";
                    logger.Info("without status: " + text);
                    break;
            }
            MetroMessageBox.Show(owner, text, header, button, icon, height);

            if(button == MessageBoxButtons.YesNo)
            {
                return DialogResult.Yes;
            }
            else
                 return DialogResult.OK;
        }

        public static DialogResult Show(IWin32Window owner, string text, string logtext, MessageBoxButtons button, MessageBoxIcon icon, Logger logger)
        {
            Logger log = logger;

            switch (icon)
            {
                case MessageBoxIcon.Information:
                    header = "Information";
                    logger.Info(logtext);
                    break;
                case MessageBoxIcon.Question:
                    header = "Question";
                    logger.Info(logtext);
                    break;
                case MessageBoxIcon.Warning:
                    header = "Warning";
                    logger.Warn(logtext);
                    break;
                case MessageBoxIcon.Error:
                    header = "Error";
                    logger.Error(logtext);
                    break;
                default:
                    header = "Message";
                    logger.Info("without status: " + logtext);
                    break;
            }

            MetroMessageBox.Show(owner, text, header, button, icon, height);

            if (button == MessageBoxButtons.YesNo)
            {
                return DialogResult.Yes;
            }
            else
                return DialogResult.OK;
        }
    }
}
