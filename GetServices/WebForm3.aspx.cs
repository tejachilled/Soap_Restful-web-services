using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetServices
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["zipcode"] != null)
            {
                TextBox1.Text = Session["latitude"].ToString();
                TextBox2.Text = Session["longitude"].ToString();
                Label1.Text = "For zipcode: " + Session["zipcode"].ToString() + " corresponding - ";
                Session.RemoveAll();
            }
        }
        ServiceReference2.Service1Client reff = new ServiceReference2.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (TextBox1.Text.Length > 1 && TextBox2.Text.Length > 1)
            {
                HttpCookie myCookies = new HttpCookie("elevationCookie");
                myCookies["LABEL3"] = reff.GetElevation(TextBox1.Text.ToString(), TextBox2.Text.ToString());
                myCookies["LABEL1"] = TextBox1.Text;
                myCookies["LABEL2"] = TextBox2.Text;
                myCookies.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(myCookies);
                Response.Redirect("WebForm6.aspx");

            }
            else
            {
                Label1.Text = "Please enter valid ";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 1 && TextBox2.Text.Length > 1)
            {
                HttpCookie myCookies = new HttpCookie("potentialCookie");
                myCookies["LABEL3"] = reff.Averagewindspeed(TextBox1.Text, TextBox2.Text);
                myCookies["LABEL1"] = TextBox1.Text;
                myCookies["LABEL2"] = TextBox2.Text;
                myCookies.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(myCookies);
                Response.Redirect("WebForm7.aspx");

            }
            else
            {
                Label1.Text = "Please enter valid ";
            }
        }
    }
}