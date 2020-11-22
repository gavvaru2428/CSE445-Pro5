using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
    public partial class AddToCartTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string url1 = "http://webstrar74.fulton.asu.edu/page7";
            int qty1, qty2, qty3;
            string userid = TextBox5.Text;
            JObject obj = new JObject(new JProperty("userid", userid));
            JObject obj1, obj2, obj3;
            List<JObject> arr = new List<JObject>();
            //If the text boxes are not empty then add the items to order
            if (TextBox6.Text != "")
            {
                qty1 = int.Parse(TextBox6.Text);
                obj1 = new JObject();
                obj1.AddFirst(new JProperty("name", "Echo Dot"));
                obj1.AddFirst(new JProperty("price", 30));
                obj1.AddFirst(new JProperty("quantity", qty1));
                arr.Add(obj1);
            }
            if (TextBox7.Text != "")
            {
                qty2 = int.Parse(TextBox7.Text);
                obj2 = new JObject();
                obj2.AddFirst(new JProperty("name", "Ipad"));
                obj2.AddFirst(new JProperty("price", 300));
                obj2.AddFirst(new JProperty("quantity", qty2));
                arr.Add(obj2);
            }

            if (TextBox8.Text != "")
            {
                qty3 = int.Parse(TextBox8.Text);
                obj3 = new JObject();
                obj3.AddFirst(new JProperty("name", "Iphone"));
                obj3.AddFirst(new JProperty("price", 500));
                obj3.AddFirst(new JProperty("quantity", qty3));
                arr.Add(obj3);
            }

            obj.AddFirst(new JProperty("order", arr));

            // Create the base address to the Add to Cart Service
            Uri baseUri = new Uri(url1 + "/api/Order/");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri.ToString());
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {

                streamWriter.Write(obj.ToString());
            }

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
                Label27.Text = readStream.ReadToEnd();
                return;
            }
            Label27.Text = "Error";
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