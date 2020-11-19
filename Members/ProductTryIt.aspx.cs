using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project5.Members
{
    public partial class ProductTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProduct_Click(object sender, EventArgs e)
        {


            lblProduct.Visible = false;

            String keyword = WebUtility.UrlEncode(txtProduct.Text);

            Regex r = new Regex("^[ A-Za-z0-9]*$");

            bool check = r.IsMatch(keyword);

            if (!check)
            {
                lblProduct.Text = "Please enter keyword without any special characters";

                lblProduct.Visible = true;

                return;
            }

                String baseURL = "http://webstrar74.fulton.asu.edu/page3";
            baseURL += "/api/FindProducts";


            try
            {
                using (var httpClient = new HttpClient())
                {
                    string productResponse = httpClient.GetStringAsync(new Uri($"{baseURL}?keyword={keyword}")).Result;

                    //validating the input zip code
                    if (productResponse == "null")
                    {
                        lblProduct.Text = "There are no products matching with the search word.";

                        lblProduct.Visible = true;

                        return;
                    }

                    List<String> list = JsonConvert.DeserializeObject<List<String>>(productResponse);

                    lblProduct.Text = "";

                    foreach (String str in list)
                    {
                        String[] strArr = str.Split(',');

                        //lblProduct.Text += "<asp:Image runat =\"server\" "+" ImageUrl =\"" +strArr[0]+"\" />"  + "<br />"+ strArr[1] + "<br />";

                        lblProduct.Text += strArr[0] + "<br />" + strArr[1] + "<br />" + strArr[2] + "<br />" + "<br />";
                    }

                    lblProduct.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblProduct.Text = "There are no products matching with the search word.";

                lblProduct.Visible = true;

                return;
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
    }
}