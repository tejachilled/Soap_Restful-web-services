using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Xml;
using System.IO;
using System.Web;
using System.Net;
using Newtonsoft.Json.Linq;

namespace GetServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public String[] Weather_Forecast1(String Zip)
        {

            String[] Weatherforecast = new String[6];   //defining string to store the output data
            try
            {
                gov.weather.graphical.ndfdXML ob = new gov.weather.graphical.ndfdXML();  //creating an object
                DateTime date = DateTime.Now;  //getting system time

                //getting the data into xml document
                XmlDocument document = new XmlDocument();  //creating an instance of XML document
                document.LoadXml(ob.LatLonListZipCode(Zip)); //loading into XML document
                XmlNodeList L_values = document.SelectNodes("/dwml"); //nodes that end with '/dwml'
                String lat_lon = L_values[0].InnerText; //getting latitude and longitude values from innerXml basing on Zip code
                String[] temp = lat_lon.Split(','); //latitude and longitude are split by ','
                String latitude = temp[0]; //assigning 1st element as latitude
                String longitude = temp[1];  //assigning 2nd element as longitude
                document.LoadXml(ob.NDFDgenByDay(Convert.ToDecimal(latitude), Convert.ToDecimal(longitude), DateTime.Today.Date, "6", "e", "24 hourly")); //getting the weather data based upon the web document

                XmlNodeList node = document.DocumentElement.SelectNodes("/dwml/data/parameters"); // getting the maximum and minimum temperatures of a particular day
                XmlNodeList max = node[0].ChildNodes;
                String[] maxtemp = new String[10];
                String[] mintemp = new String[10];

                int l_count = 0;
                for (int i = 0; i < max.Count; i++)
                {
                    int var = 0;
                    if (max[i].Name == "temperature" && l_count == 0)
                    {
                        XmlNodeList maxval = max[i].ChildNodes;
                        for (int j = 1; j < 6; j++)
                        {
                            maxtemp[var] = maxval[j].InnerText;
                            var++;
                        }
                        l_count = 1;
                    }
                    else if (max[i].Name == "temperature" && l_count == 1)
                    {
                        XmlNodeList minval = max[i].ChildNodes;
                        for (int j = 1; j < 6; j++)
                        {
                            mintemp[var] = minval[j].InnerText;
                            var++;
                        }
                    }

                }
                for (int i = 0; i < 5; i++)
                {

                    Weatherforecast[i] = "Date: " + date.ToString("d") + " ||  " + "Day: " + date.DayOfWeek + " ||  " + "@Maximum Temperature: " + "  || " + maxtemp[i] + "@Minimum Temperature: " + " ||  " + mintemp[i] + "@Latitude: " + latitude;  //storing the values
                    Weatherforecast[i] = Weatherforecast[i].Replace("@", System.Environment.NewLine);
                    date = date.AddDays(1);
                }
                return Weatherforecast;
            }
            catch (Exception)
            {
                String[] wro = new String[1];
                wro[0] = "Given ZipCode is  not correct"; //if the zipcode entered is incorrect
                return wro;
            }


        }


        public string GetElevation(string lat, string lon)
        {
            string url = "https://maps.googleapis.com/maps/api/elevation/json?locations=" + lat + "," + lon + "&key=AIzaSyAEeRSXGRfHLFCWavKTxwsdAqZbrlQaOYk";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();

            dynamic result = JObject.Parse(responsereader);
            string elevation = result.results[0].elevation;

            return elevation;

        }

        public string Averagewindspeed(string lat, string lon)
        {
            string url = "https://api.forecast.io/forecast/db96b6748ec168468f8292d0cf6acefd/" + lat + "," + lon;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            dynamic result = JObject.Parse(responsereader);
            string windspeed = result.currently.windSpeed;
            return windspeed;
        }
    }
}
