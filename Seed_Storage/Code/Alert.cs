using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Seed_Storage
{
    public static class Alert
    {


        /// <summary>
        /// Show an Alert Message Box on the screen
        /// </summary>
        /// <param name="Prompt">What do you want to show</param>
        /// <param name="ButtonStyle">The type of button to display</param>
        /// <returns></returns>
        public static DialogResult Show(string Prompt,frmAlert.enumButtonStyle ButtonStyle= frmAlert.enumButtonStyle.OkOnly )
        {
            using (frmAlert frm = new frmAlert(Prompt, ButtonStyle))
            {
                return frm.ShowDialog();
            }

        }

    }
}
