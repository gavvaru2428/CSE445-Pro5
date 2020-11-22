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
    public partial class GetCartTotalTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string url1 = "http://webstrar74.fulton.asu.edu/page7";
            string userid = TextBox9.Text;
            //Check if user id is empty
            if (userid == "")
            {
                Label36.Text = "Enter User ID"; return;
            }

            // Create the base address to the Cart Total Service
            Uri baseUri = new Uri(url1);
            // Define UriTemplate for passing parameter
            UriTemplate myTemplate = new UriTemplate("/api/Order/{userid}/");

            NameValueCollection parameters = new NameValueCollection();
            // Assign values to the parameters
            parameters.Add("userid", userid);
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
                string str = readStream.ReadToEnd();
                //Check if there is any error
                if (str == "-1.0")
                {
                    Label36.Text = "Error in processing";
                }
                else
                    Label36.Text = str;
                return;
            }
            Label36.Text = "Error";
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Server.Transfer("~/Default.aspx");
        }
    }
}