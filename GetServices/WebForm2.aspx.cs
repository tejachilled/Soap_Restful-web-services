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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String zipcode = TextBox1.Text.ToString();
            //creating a url for to get data from given Zip Code
            String URL = "http://localhost:50881/Service1.svc/GetData/" + zipcode;
            HttpWebRequest httpProductRequest;
            HttpWebResponse httpProductResponse;
            StreamReader streamReader;
            string xmldata = "";
            try
            {
                //creating a webrequest for the productURL to get the data
                httpProductRequest = (HttpWebRequest)WebRequest.Create(URL);

                //fetching the web data and storing it in httpProductResponse
                httpProductResponse = (HttpWebResponse)httpProductRequest.GetResponse();

                //converting the httpProductResponse to a stream of data
                streamReader = new System.IO.StreamReader(httpProductResponse.GetResponseStream());
                xmldata = streamReader.ReadToEnd();
            }
            catch (WebException ex)
            {
                using (WebResponse response = ex.Response)
                {
                    httpProductResponse = (HttpWebResponse)response;
                    streamReader = new System.IO.StreamReader(httpProductResponse.GetResponseStream());
                    //storing the stream in XML string
                    xmldata = streamReader.ReadToEnd();
                }
            }


            //creating an xmlreader for parsing
            XmlReader xread = XmlReader.Create(new StringReader(xmldata));
            String output = "";
            while (xread.Read())
            {
                output = output + xread.ReadString();

            }
            // dsiplaying output
            Label1.Text = output;     
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.Service1Client reference = new ServiceReference2.Service1Client();
            String[] Forecast = new String[10];
            String LABEL1, LABEL2, LABEL3, LABEL4, LABEL5, LABEL6;
            if (TextBox1.Text != null)
            {
                if (TextBox1.Text.Length > 0)
                {
                    Forecast = reference.Weather_Forecast1(TextBox1.Text.ToString());

                    LABEL1 = Forecast[0];
                    LABEL2 = Forecast[1];
                    LABEL3 = Forecast[2];
                    LABEL4 = Forecast[3];
                    LABEL5 = Forecast[4];
                    LABEL6 = TextBox1.Text;
                    HttpCookie myCookies = new HttpCookie("myCookieId");
                    myCookies["LABEL1"] = LABEL1;
                    myCookies["LABEL2"] = LABEL2;
                    myCookies["LABEL3"] = LABEL3;
                    myCookies["LABEL4"] = LABEL4;
                    myCookies["LABEL5"] = LABEL5;
                    myCookies["LABEL6"] = LABEL6;
                    myCookies.Expires = DateTime.Now.AddMonths(6);
                    Response.Cookies.Add(myCookies);
                    Response.Redirect("WebForm4.aspx");
                }
                else
                {
                    Label1.Text = "Please enter a valid Zipcode";
                }

            }
            else
            {
                Label1.Text = "Please enter a valid Zipcode";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                HttpCookie myCookies = new HttpCookie("myCookie");
                myCookies["LABEL1"] = TextBox1.Text;
                myCookies.Expires = DateTime.Now.AddMonths(6);
                Response.Cookies.Add(myCookies);
                Response.Redirect("WebForm5.aspx");
            }
            else
            {
                Label1.Text = "Please enter a valid Zipcode";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                gov.weather.graphical.ndfdXML ob = new gov.weather.graphical.ndfdXML();  //creating an object
                DateTime date = DateTime.Now;  //getting system time
                String[] Weatherforecast = new String[6];   //defining string to store the output data
                //getting the data into xml document
                XmlDocument document = new XmlDocument();  //creating an instance of XML document
                document.LoadXml(ob.LatLonListZipCode(TextBox1.Text)); //loading into XML document
                XmlNodeList L_values = document.SelectNodes("/dwml"); //nodes that end with '/dwml'
                String lat_lon = L_values[0].InnerText; //getting latitude and longitude values from innerXml basing on Zip code
                String[] temp = lat_lon.Split(','); //latitude and longitude are split by ','
                String latitude = temp[0]; //assigning 1st element as latitude
                String longitude = temp[1];
                Session["latitude"] = latitude;
                Session["longitude"] = longitude;
                Session["zipcode"] = TextBox1.Text;
                Response.Redirect("WebForm3.aspx");

            }
            else
            {
                Label1.Text = "Please enter a valid Zipcode";
            }

        }
    }
}