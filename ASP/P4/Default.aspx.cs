using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myLib;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       int n1 = Convert.ToInt32(TextBox1.Text);
        int n2 = Convert.ToInt32(TextBox2.Text);
        string str="";
        str += "Add Is " + Calc.add(n1, n2).ToString() + "<br/>";
        str += "Sub Is " + Calc.sub(n1, n2).ToString() + "<br/>";
        str += "Mul Is " + Calc.mul(n1, n2).ToString() + "<br/>";
        str += "Div Is " + Calc.div(n1, n2).ToString() + "<br/> ";

        Label1.Text = str;

    }
}