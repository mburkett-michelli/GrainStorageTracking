using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventory_Inventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.lblTime.Text = "Last Update " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
    }
}