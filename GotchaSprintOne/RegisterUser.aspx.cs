using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GotchaSprintOne
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createaccButton_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO Users (username,userpass,userlevel,playgroup,place,picture) VALUES (@username,@userpass,@userlevel,@playgroup,@place,@picture);";
            string connectionString = "Data Source=(local);Initial Catalog=GotchaSprintOne;Integrated Security=True";
            string queryStringuserid = "Select userid FROM Users WHERE username='" + usernameInput.Text + "';";
            List<int> idresults = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.Parameters.AddWithValue("@username", usernameInput.Text);
                command.Parameters.AddWithValue("@userpass", userpassInput.Text);
                command.Parameters.AddWithValue("@userlevel", userlevelInput.Text);
                command.Parameters.AddWithValue("@playgroup", playgroupInput.Text);
                command.Parameters.AddWithValue("@place", placeInput.Text);
                command.Parameters.AddWithValue("@picture", picturelinkInput.Text);



                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
                else
                {
                    SqlCommand command2 = new SqlCommand(queryStringuserid, connection);
                    SqlDataReader reader = command2.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            idresults.Add(reader.GetInt32(1));
                        }
                    }
                    finally
                    {
                        reader.Close();

                        if (idresults.Count == 1)
                        {
                            Session["username"] = usernameInput.Text;
                            Session["userid"] = idresults.First().ToString();
                            Response.Redirect("Home.aspx");
                        }
                    }
                }
            }
        }
    }
}