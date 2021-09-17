using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GotchaSprintOne
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stringchecker = Session["username"] as string;
            if (String.IsNullOrEmpty(stringchecker))
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["username"] = stringchecker;
            }
        }
    }
}