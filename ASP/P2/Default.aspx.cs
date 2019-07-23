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
    protected void Button1_Click(object sender, EventArgs e)
    {
        int n1 = Convert.ToInt32(TextBox1.Text);
        int n2 = Convert.ToInt32(TextBox2.Text);
        Label1.Text = Cal.add(n1, n2).ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int n1 = Convert.ToInt32(TextBox1.Text);
        int n2 = Convert.ToInt32(TextBox2.Text);
        Label1.Text = Cal.sub(n1, n2).ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int n1 = Convert.ToInt32(TextBox1.Text);
        int n2 = Convert.ToInt32(TextBox2.Text);
        Label1.Text = Cal.mul(n1, n2).ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int n1 = Convert.ToInt32(TextBox1.Text);
        int n2 = Convert.ToInt32(TextBox2.Text);
        Label1.Text = Cal.div(n1, n2).ToString();
    }
}