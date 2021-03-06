﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using PasswordProtection;

namespace project5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var a  = Request.QueryString["ReturnUrl"];
            if (!String.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
            {
                if (Request.QueryString["ReturnUrl"].Contains("Staff"))
                {
                    Response.Redirect("~/StaffLogin.aspx");

                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnMemLogin_Click(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;

            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Members.xml";
            string user = txtMemName.Text;

            string password = txtMemPass.Text;
            //Username and Password should not be empty
            if(String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {
                lblErrorLogin.Text = "Please enter username and password!";
                lblErrorLogin.Visible = true;
                return;

            }
            //Encryption/Decryption DLL Class
            DllClass dllClass = new DllClass();

            string decryptPass = "";
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);    // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    decryptPass = dllClass.decryptString(node["pwd"].InnerText); //Decrypt the password string stored in the xml

                    if (decryptPass.Equals(password))
                    {
                        SignIn(user, false);


                        if (!String.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                        {

                            // FormsAuthentication.RedirectFromLoginPage(txtMemName.Text, false);

                            Response.Redirect(Request.QueryString["ReturnUrl"]);

                        }
                        else
                        {
                            Response.Redirect("Members/Member.aspx");
                        }

                    }
                    else
                    {
                        //if username exists but password does match. 
                        lblErrorLogin.Text = "Please enter correct password";
                        lblErrorLogin.Visible = true;
                        return;
                    }
                }
            }
            lblErrorLogin.Text = "Please enter correct credentials.If you are a new user, Please register first.";
            lblErrorLogin.Visible = true; 
            return;

        }
        //Create a Cookie ticket with the username, set a role identifier and expiration time.
        private void SignIn(string username, bool createPersistentCookie)
        {
            var now = DateTime.UtcNow.ToLocalTime();
            TimeSpan expirationTimeSpan = FormsAuthentication.Timeout;

            var ticket = new FormsAuthenticationTicket(
                1,
                username,
                now,
                now.Add(expirationTimeSpan),
                createPersistentCookie,
                "Member",
                FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
                encryptedTicket)
            {
                HttpOnly = true,
                Secure = FormsAuthentication.RequireSSL,
                Path = FormsAuthentication.FormsCookiePath
            };

            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }

            Response.Cookies.Add(cookie);
        }

    }
}