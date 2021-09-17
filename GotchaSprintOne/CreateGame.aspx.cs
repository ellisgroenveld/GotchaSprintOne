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
    public partial class CreateGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stringchecker = Session["username"] as string;
            if (String.IsNullOrEmpty(stringchecker))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Session not valid');", true);

                Response.Redirect("Home.aspx");
            }
            else
            {
                string sessionid = Session["userid"] as string;
                string queryString = "Select userlevel FROM Users WHERE userid='" + sessionid + "';";
                string connectionString = "Data Source=(local);Initial Catalog=GotchaSprintOne;Integrated Security=True";
                List<int> results = new List<int>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            results.Add(reader.GetInt32(0));
                        }
                    }
                    finally
                    {
                        reader.Close();

                        if (results.Count == 1)
                        {
                            if (results.First() > 1)
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Not enough priviliges');", true);
                                Response.Redirect("Home.aspx");
                            }
                            else
                            {
                                
                            }
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('SQL error');", true);
                        }
                    }
                }
            }
        }

        protected void adduserButton_Click(object sender, EventArgs e)
        {
            bool checker = false;
            foreach (var i in BulletedListUserids.Items)
            {
                if (useridInput.Text == i.ToString())
                {
                    checker = true;
                }
            }
            if (checker == false)
            {
                try
                {
                    int result = Int32.Parse(useridInput.Text);

                    string queryString = "Select userid FROM Users WHERE userid='" + result + "';";
                    string connectionString = "Data Source=(local);Initial Catalog=GotchaSprintOne;Integrated Security=True";
                    List<int> results = new List<int>();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryString, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        try
                        {
                            while (reader.Read())
                            {
                                results.Add(reader.GetInt32(0));
                            }
                        }
                        finally
                        {
                            reader.Close();

                            if (results.Count == 1)
                            {
                                BulletedListUserids.Items.Add(useridInput.Text);
                            }
                            else
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Not available user');", true);
                            }
                        }
                    }


                }
                catch (FormatException)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Only numbers allowed');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No double IDs');", true);

            }
            useridInput.Text = "";
        }

        protected void generateGame_Click(object sender, EventArgs e)
        {

        }
    }
}