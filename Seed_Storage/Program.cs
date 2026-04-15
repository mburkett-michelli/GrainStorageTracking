using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
namespace Seed_Storage
{
    static class Program
    {
       public static bool Restart=false;
       private static Mutex m_Mutex;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           bool createdNew;
           m_Mutex = new Mutex(true, "SeedStorage", out createdNew);
       RUNPROGRAM:
           if (createdNew)
           {
               Application.Run(new Form1());
               if (Restart)
               {
                   Restart = false;
                   goto RUNPROGRAM;
               }
           }
           else
           {
               MessageBox.Show("The Seed Storage is already running.", Application.ProductName,
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }


       }


    }
}



