using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Xml;
using System.IO;

namespace GetServices
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookie"];
            if (myCookies != null)
            {
                Label1.Text = myCookies["LABEL1"];

                String URL = "http://localhost:50881/Service1.svc/getLinks/" + Label1.Text;
                HttpWebRequest httpProductRequest;
                HttpWebResponse httpProductResponse;
                StreamReader streamReader;
                string xmldata = "";

                //creating a webrequest for the productURL to get the data
                httpProductRequest = (HttpWebRequest)WebRequest.Create(URL);

                //fetching the web data and storing it in httpProductResponse
                httpProductResponse = (HttpWebResponse)httpProductRequest.GetResponse();

                //converting the httpProductResponse to a stream of data
                streamReader = new System.IO.StreamReader(httpProductResponse.GetResponseStream());
                xmldata = streamReader.ReadToEnd();




                //creating an xmlreader for parsing
                XmlReader xread = XmlReader.Create(new StringReader(xmldata));
                String output = "";
                while (xread.Read())
                {
                    output = output + xread.ReadString() + "\n\n";

                }
                TextBox1.Text = output; //output

            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}