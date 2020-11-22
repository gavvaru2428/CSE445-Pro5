using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml;

namespace project5
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie decryptedCookie =
           Context.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (decryptedCookie != null)
            {
                FormsAuthenticationTicket ticket =
                    FormsAuthentication.Decrypt(decryptedCookie.Value);

                var identity = new GenericIdentity(ticket.Name);
                var roles = ticket.UserData.Split(',');
                var principal = new GenericPrincipal(identity, roles);

                HttpContext.Current.User = principal;
                Thread.CurrentPrincipal = HttpContext.Current.User;
            }
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            string str = GetStringFromFile("Errors.xml");
            string time = "_" + DateTime.Now.ToString() + "_";
            if (str == "" || str == "File not exist" || str == null || str == "\r\n")
            {
                //Handle new or empty file
                JObject obj = new JObject(new JProperty(time, JsonConvert.SerializeObject(ex.Message)));
                XmlDocument doc = JsonConvert.DeserializeXmlNode(obj.ToString(), "root");
                PutStringToFile("Errors.xml", doc.OuterXml);
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(str);
                string jsonText = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
                //Create a new cart for user or append the order to previously existing cart 
                JObject errors = JObject.Parse(jsonText);
                errors.AddFirst(new JProperty(time, JsonConvert.SerializeObject(ex.Message)));
                doc = JsonConvert.DeserializeXmlNode(errors.ToString(), "root");
                PutStringToFile("Errors.xml", doc.OuterXml);
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        //Write to a file
        public static void PutStringToFile(string fileName, string value)
        {
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data"); // Get path from server root to current
            fLocation = Path.Combine(fLocation, fileName); // From current to App_Data
            if (!System.IO.File.Exists(fLocation))
            {
                File.Create(fLocation);
            }
            using (StreamWriter sw = File.CreateText(fLocation))
            {
                sw.WriteLine(value);
                sw.Close();
            }

        }

        //Read from a file
        public static string GetStringFromFile(string fileName)
        {
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data"); // From server root to current
            fLocation = Path.Combine(fLocation, fileName); // From current to App_Data
            if (!File.Exists(fLocation))
            {
                return "File not exist";
            }
            using (StreamReader sr = File.OpenText(fLocation))
            {
                string s = sr.ReadToEnd();
                sr.Close();
                return s;
            }
        }
    }
}
