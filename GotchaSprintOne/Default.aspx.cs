using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GotchaSprintOne
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string queryString = "Select username, userid FROM Users WHERE username='" + usernameInput.Text + "';";
            string connectionString = "Data Source=(local);Initial Catalog=GotchaSprintOne;Integrated Security=True";
            List<string> results = new List<string>();
            List<int> idresults = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        results.Add(reader.GetString(0));
                        idresults.Add(reader.GetInt32(1));
                    }
                }
                finally
                {
                    reader.Close();

                    if (results.Count == 1)
                    {
                        Session["username"] = results.First();
                        Session["userid"] = idresults.First().ToString();
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Your username was empty or not correct!');", true);
                    }
                }
            }
            
            
        }
    }
}