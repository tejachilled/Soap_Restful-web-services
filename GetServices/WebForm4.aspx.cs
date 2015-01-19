using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetServices
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if (myCookies != null)
            {
                Label1.Text = myCookies["LABEL1"];
                Label2.Text = myCookies["LABEL2"];
                Label3.Text = myCookies["LABEL3"];
                Label4.Text = myCookies["LABEL4"];
                Label5.Text = myCookies["LABEL5"];
                Label6.Text = myCookies["LABEL6"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}