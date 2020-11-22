using PasswordProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace project5.Staff
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void deliveryBtn_Click(object sender, EventArgs e)
        {
            SuhasServiceRef.Service1Client suhasService = new SuhasServiceRef.Service1Client("soapService");
            try
            {
                if (!String.IsNullOrWhiteSpace(zipcode1TB.Text) && !String.IsNullOrWhiteSpace(zipcode2TB.Text))//Send the request only when text box contain some data
                {
                    string zipcode1 = zipcode1TB.Text;
                    string zipcode2 = zipcode2TB.Text;
                    string result = suhasService.distanceCalulator(zipcode1, zipcode2);
                    deliveryResultTB.Text = result;
                }
                else
                {   //Display the error message here!
                    zipcode1TB.Text = "Please enter a valid String!";
                    zipcode2TB.Text = "Please enter a valid String!";
                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void neareststoreBtn_Click(object sender, EventArgs e)
        {
            SuhasServiceRef.Service1Client suhasService = new SuhasServiceRef.Service1Client("soapService");
            try
            {
                if (!String.IsNullOrWhiteSpace(neareststoreTB.Text) && !String.IsNullOrWhiteSpace(neareststorezipcodeTB.Text))//Send the request only when text box contain some data
                {
                    string zipcode = neareststorezipcodeTB.Text;
                    string storename = neareststoreTB.Text;
                    string result = suhasService.findNearestStore(zipcode, storename);
                    nearestStoreResultTB.Text = result;
                }
                else
                {   //Display the error message here!
                    neareststorezipcodeTB.Text = "Please enter a valid String!";
                    neareststoreTB.Text = "Please enter a valid String!";
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void addStaffBtn_Click(object sender, EventArgs e)
        {
            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Staff.xml";
            string user = addStaffusername.Text;
            string password = addStaffPass.Text;
            string retypepassword = addStaffretypepass.Text;

            if (String.IsNullOrEmpty(retypepassword) || String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {
                lbladdStaff.Text = "Please enter all three textboxes username, password and retype password!";
                lbladdStaff.Visible = true;
                return;
            }

            if (!(password).Equals(retypepassword))
            {
                lbladdStaff.Text = "Error! Passwords dont match!";
                lbladdStaff.Visible = true;
                return;
            }

            DllClass dllClass = new DllClass();

            string pwdEncrypt = dllClass.enryptString(password);
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);                       // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    lbladdStaff.Text = String.Format("*Account with user name {0} already exists.", user);
                    lbladdStaff.Visible = true;
                    return;
                }
            }


            XmlElement myMember = myDoc.CreateElement("member", rootElement.NamespaceURI);
            rootElement.AppendChild(myMember);
            XmlElement myUser = myDoc.CreateElement("name", rootElement.NamespaceURI);
            myMember.AppendChild(myUser);
            myUser.InnerText = user;

            XmlElement myPwd = myDoc.CreateElement("pwd", rootElement.NamespaceURI);
            myMember.AppendChild(myPwd);
            myPwd.InnerText = pwdEncrypt;

            myDoc.Save(filepath);

            lbladdStaff.Text = String.Format("New Staff with name {0} is added to Staff.xml.", user);
            lbladdStaff.Visible = true;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Server.Transfer("~/Default.aspx");
        }
    }
}