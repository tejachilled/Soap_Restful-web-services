using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetServices
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["potentialCookie"];
            if (myCookies != null)
            {
                Label3.Text = myCookies["LABEL3"];
                Label1.Text = myCookies["LABEL1"];
                Label2.Text = myCookies["LABEL2"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}