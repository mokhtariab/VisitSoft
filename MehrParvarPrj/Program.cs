using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MehrParvarPrj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Global_Cls.IsAnyInstanceExist("MehrParvarPrj"))
                Global_Cls.Message_MehrGostar(0, Global_Cls.MessageType.SWarning, false, "برنامه در حال کار می باشد");
            else
                Application.Run(new StartRC_frm());
        }
    }
}