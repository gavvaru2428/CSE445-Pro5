﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project5.Members
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductTryIt.aspx");
        }

        protected void btnWeather_Click(object sender, EventArgs e)
        {
            Response.Redirect("WeatherTryIt.aspx");
        }

        protected void btnDll_Click(object sender, EventArgs e)
        {
            Response.Redirect("DLLTryIt.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddToCartTryIt.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GetCartTotalTryIt.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("SolarServiceTryIt.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Server.Transfer("~/Default.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlaceOrderTryIt.aspx");
        }

    }
}