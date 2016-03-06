using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT191P_Project
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Username"]==null)
            {
                Response.Redirect("../SessionExpired.aspx");
            }
            navUser.InnerText= "Hello, "+ (string)Session["Username"];
            Logout.ServerClick += new EventHandler(Logout_Click);
        }

        void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../Business Site/Index.aspx");
        }
    }
}