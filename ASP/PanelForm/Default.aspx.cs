using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        SignupPanel.Visible = false;
        LoginPanel.Visible = true;
        titleText.Text = "Login";
    }
    protected void signupButton_Click(object sender, EventArgs e)
    {
        LoginPanel.Visible = false;
        SignupPanel.Visible = true;
        titleText.Text = "Sign-up";
    }
}