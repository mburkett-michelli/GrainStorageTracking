using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using WebSite;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        var manager = new UserManager();
        var user = new ApplicationUser() { UserName = UserName.Text };
        IdentityResult result = manager.Create(user, Password.Text);
        if (result.Succeeded == false)
        {
            ErrorMessage.Text = result.Errors.FirstOrDefault();
        }
        
        else

        {
            var currentUser = manager.FindByName(user.UserName);

            var roleresult = manager.AddToRole(currentUser.Id, "User");

            if (roleresult.Succeeded == false)
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }

            else
            {
                ErrorMessage.Text = user + " has been added.";
                Response.Redirect("~/Home/LoginHome.aspx");
            }
        }
    
    }
}