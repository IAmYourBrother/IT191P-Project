using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT191P_Project.Business_Site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        void CheckCredentials()
        {
            if((!string.IsNullOrEmpty(txtUsername.Text))&&(!string.IsNullOrEmpty(txtPassword.Text)))
            {
                /*Temporary login credentials
                 * 
                 * Later we will implment DB data to be stored
                 * in the session.
                 */
                if(txtUsername.Text.Equals("Admin") && txtPassword.Text.Equals("Admin"))
                {
                    Session["Username"] = txtUsername.Text;
                    Response.Redirect("../Admin Site/Dashboard.aspx");
                    Session.Remove("Username");
                }
            }
        }
    }
}