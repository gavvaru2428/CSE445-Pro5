using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using PasswordProtection;

namespace project5.Members
{
    public partial class DLLTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                lblEncrypt.Visible = false;

                DllClass dllClasss = new DllClass();

                lblEncrypt.Text = dllClasss.enryptString(txtStr.Text);

                lblEncrypt.Visible = true;
            }
            catch (Exception ex)
            {
                lblEncrypt.Text = "Pleasee enter correct String using alphabets and numbers";

                lblEncrypt.Visible = true;
            }

        }

        protected void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {

                lblDecrypt.Visible = false;

                DllClass dllClasss = new DllClass();

                lblDecrypt.Text = dllClasss.decryptString(txtDecrypt.Text);

                lblDecrypt.Visible = true;
            }
            catch(Exception ex)
            {
                lblDecrypt.Text = "Pleasee enter encrypted string obtainded from the above.";

                lblDecrypt.Visible = true;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Server.Transfer("~/Default.aspx");
        }
    }
}