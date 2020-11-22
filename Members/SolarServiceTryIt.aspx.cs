using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project5.Members
{
    public partial class SolarServiceTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url1 = "http://webstrar74.fulton.asu.edu/page7";
            // Create the base address to the Energy Service
            Uri baseUri = new Uri(url1);
            // Define UriTemplate for passing parameter
            UriTemplate myTemplate = new UriTemplate("/api/Solar/{lat}/{lon}/");

            NameValueCollection parameters = new NameValueCollection();
            string latitude = TextBox1.Text;
            string longitude = TextBox2.Text;

            decimal lat, lon;
            //Check if the input is valid
            if (latitude == "" || latitude == null || !Decimal.TryParse(latitude, out lat))
            {
                Label10.Text = "Enter Valid Latitude"; return;
            }
            else if (longitude == "" || longitude == null || !Decimal.TryParse(longitude, out lon))
            {
                Label10.Text = "Enter Valid Longitude"; return;
            }
            // Assign values to the parameters
            parameters.Add("lat", lat.ToString());
            parameters.Add("lon", lon.ToString());
            //Build complete URI
            Uri completeUri = myTemplate.BindByName(baseUri, parameters);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(completeUri.ToString());
            request.Method = "GET";
            //Make the REST call
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Check the Response Status Code
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == "")
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                // Convert to string and assign to the output label
                Label10.Text = readStream.ReadToEnd().Replace("\"", "");
                return;
            }
            Label10.Text = "Error";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Server.Transfer("~/Default.aspx");
        }
    }
}