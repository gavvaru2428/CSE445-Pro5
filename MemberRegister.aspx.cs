using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using PasswordProtection;

namespace project5
{
    public partial class MemberRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // Member registration method, it checks if a member with same name is present if so returns an error
        // password and retype password should match if not returns an error.
        // User is asked to enter a number/code present in the Captcha Image.
        //If all the above validation is passed then a new staff is entered into Members.xml
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //password match, not empty,xml search,xml add, redirect to login
            lblRegister.Visible = false;
            string captcha = imgVerBox.Text.ToLower();
            if (txtNameReg.Text == null || txtPassReg.Text == null || txtRetypePass.Text == null || !(txtPassReg.Text).Equals(txtRetypePass.Text))
            {
                lblRegister.Text = "Please enter correct values";
                lblRegister.Visible = true;
                return;
            }

            if (captcha != Session["CaptchaVerify"].ToString())
            {
                lblRegister.Text = "Please enter correcct verification captcha code!";
                lblRegister.Visible = true;
                return;
            }

            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Members.xml";
            string user = txtNameReg.Text;
            string password = txtPassReg.Text;

            DllClass dllClass = new DllClass();

            string pwdEncrypt = dllClass.enryptString(password);
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);                       // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    lblRegister.Text = String.Format("*Account with user name {0} already exists.", user);
                    lblRegister.Visible = true;
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

            Response.Redirect("MemberLogin.aspx");

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}