using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Seed_Storage
{
    class Wait
    {
        public static frmDelay Delay = new frmDelay();

        public static void ShowWait(string Prompt)
        {
            Delay.SetPrompt(Prompt);
            Delay.Show();
           // Application.DoEvents();
        }

        public static void Hide()
        {
            Delay.Hide();
        }


    }
}
