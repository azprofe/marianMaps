/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 29/06/2015
 */
using System;
using System.IO;
using System.Net;
using System.Xml;

namespace mapas.Clases
{
	/// <summary>
	/// Description of Adress.
	/// </summary>
 public class Adress
    {
        public Adress()
        { 
        }
        //Properties
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }

        //The Geocoding here i.e getting the latt/long of address
        public void GeoCode()
        {
            //to Read the Stream
            StreamReader sr = null;
            
            //The Google Maps API Either return JSON or XML. We are using XML Here
            //Saving the url of the Google API 
            string url = String.Format("http://maps.googleapis.com/maps/api/geocode/xml?address=" + 
            this.Address + "&sensor=false");
            
            //to Send the request to Web Client 
            WebClient wc = new WebClient();
            try
            {
                sr = new StreamReader(wc.OpenRead(url));
            }
            catch (Exception ex)
            {
                throw new Exception("The Error Occured"+ ex.Message);
            }

            try
            {                
                XmlTextReader xmlReader = new XmlTextReader(sr);
                bool latread = false;
                bool longread = false;

                while (xmlReader.Read())
                {
                    xmlReader.MoveToElement();
                        switch (xmlReader.Name)
                        {
                            case "lat":

                                if (!latread)
                                {
                                    xmlReader.Read();
                                    this.Latitude = double.Parse(xmlReader.Value, System.Globalization.CultureInfo.InvariantCulture);
                                    latread = true;
                                    
                                }
                                break;
                            case "lng":
                                if (!longread)
                                {
                                    xmlReader.Read();
                                    this.Longitude = 
                                    double.Parse(xmlReader.Value, System.Globalization.CultureInfo.InvariantCulture);
                                    longread = true;
                                }
                            
                                break;
                        }   
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An Error Occured"+ ex.Message);
            }
        }
    }
}
