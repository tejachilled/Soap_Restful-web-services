using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.IO;
using System.Web;
using System.Net;
using Google.API.Search;

namespace WebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(String zipcode)
        {
            try
            {
                //Creating proxy for the web reference
                
                ServiceReference1.USZipSoapClient prox = new ServiceReference1.USZipSoapClient(); ;

                //Creating XmlReader object to read
                XmlReader xreaderobj = XmlReader.Create(new StringReader(prox.ValidateZip(zipcode)));
                string result = "";
                xreaderobj.ReadToFollowing("item");
                result = result + "ZIP CODE-" + xreaderobj.GetAttribute("zip") + "\n";
                result = result + "STATE-" + xreaderobj.GetAttribute("state") + "\n";
                string state = xreaderobj.GetAttribute("state");
                string capital = "";
                //To retrieve the capital of the particular state
                switch (state)
                {
                    case "AL": capital = "Montgomery"; break;
                    case "AK": capital = "Juneau"; break;
                    case "AR": capital = "Little Rock"; break;
                    case "AZ": capital = "Phoenix"; break;
                    case "CA": capital = "Sacramento"; break;
                    case "CO": capital = "Denver"; break;
                    case "CT": capital = "Hartford"; break;
                    case "DE": capital = "Dover"; break;
                    case "FL": capital = "Tallahassee"; break;
                    case "GA": capital = "Atlanta"; break;
                    case "HI": capital = "Honolulu"; break;
                    case "ID": capital = "Boise"; break;
                    case "IL": capital = "Springfield"; break;
                    case "IN": capital = "Indianapolis"; break;
                    case "IA": capital = "Des Moines"; break;
                    case "KS": capital = "Topeka"; break;
                    case "KY": capital = "Frankfort"; break;
                    case "LA": capital = "Baton Rouge"; break;
                    case "ME": capital = "Augusta"; break;
                    case "MD": capital = "Annapolis"; break;
                    case "MA": capital = "Boston"; break;
                    case "MI": capital = "Lansing"; break;
                    case "MN": capital = "Saint Paul"; break;
                    case "MS": capital = "Jackson"; break;
                    case "MO": capital = "Jefferson City"; break;
                    case "MT": capital = "Helena"; break;
                    case "NE": capital = "Lincoln"; break;
                    case "NV": capital = "Carson City"; break;
                    case "NH": capital = "Concord"; break;
                    case "NJ": capital = "Trenton"; break;
                    case "NM": capital = "Santa Fe"; break;
                    case "NY": capital = "Albany"; break;
                    case "NC": capital = "Raleigh"; break;
                    case "ND": capital = "Bismarck"; break;
                    case "OH": capital = "Columbus"; break;
                    case "OK": capital = "Oklahoma City"; break;
                    case "OR": capital = "Salem"; break;
                    case "PA": capital = "Harrisburg"; break;
                    case "RI": capital = "Providence"; break;
                    case "SC": capital = "Columbia"; break;
                    case "SD": capital = "Pierre"; break;
                    case "TN": capital = "Nashville"; break;
                    case "TX": capital = "Austin"; break;
                    case "UT": capital = "Salt Lake City"; break;
                    case "VT": capital = "Montpelier"; break;
                    case "VA": capital = "Richmond"; break;
                    case "WA": capital = "Olympia"; break;
                    case "WV": capital = "Charleston"; break;
                    case "WI": capital = "Madison"; break;
                    case "WY": capital = "Cheyenne"; break;

                }
                result = result + "CAPITAL-" + capital + "\n";
                result = result + "LATITUDE-" + xreaderobj.GetAttribute("latitude") + "\n";
                result = result + "LONGITUDE-" + xreaderobj.GetAttribute("longitude") + "\n";
                return result;
            }

                //Catching the exception
            catch (Exception e)
            {
                return e.Message.ToString();

            }
        }

        public String[] getLinks(String zipcode)
        {
            int counter = 0;

            String[] topics = new String[100];
            String[] input = { zipcode };
            for (int i = 0; i < input.Length; i++)
            {
                GnewsSearchClient gnews = new GnewsSearchClient(input[i]);

                var newslist = gnews.Search(input[i], 10);
                topics[counter] = input[i];
                counter++;
                foreach (var list in newslist)
                {
                    topics[counter] = list.Url;
                    counter++;
                }

            }

            return topics;

        }

    }
}
