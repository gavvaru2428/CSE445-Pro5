using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project5.Members
{
    public partial class WeatherTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWeather_Click(object sender, EventArgs e)
        {
            lblWeather.Visible = false;

            String baseURL = "http://webstrar74.fulton.asu.edu/page3";
            baseURL += "/api/Weather";

            String zipcode = txtWeather.Text;

            using (var httpClient = new HttpClient())
            {
                string zipCodeResponse = httpClient.GetStringAsync(new Uri($"{baseURL}?zipcode={zipcode}")).Result;

                //validating the input zip code
                if (zipCodeResponse == "null")
                {
                    lblWeather.Text = "please enter correct zipcode";

                    lblWeather.Visible = true;

                    return;
                }

                List<String> list = JsonConvert.DeserializeObject<List<String>>(zipCodeResponse);

                lblWeather.Text = list[0] + "<br />" + list[1] + "<br />" + list[2] + "<br />" + list[3] + "<br />" + list[4];

                lblWeather.Visible = true;
            }

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