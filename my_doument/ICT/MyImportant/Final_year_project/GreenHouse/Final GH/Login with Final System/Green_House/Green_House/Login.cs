using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Green_House
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lg_Click(object sender, EventArgs e)
        {

            try
            {


                SqlConnection con = new SqlConnection("Data Source=ACER-PC;Initial Catalog=green_house;Integrated Security=True");
                SqlCommand cmd;
                SqlDataReader dr;



                if (untextBox1.Text == "" && pwtextBox2.Text == "")
                {
                    MessageBox.Show("Please Enter UserName and Password");
                }
                else
                {
                    try
                    {

                        con.Open();
                        string query = "Userlogin"; //stored Procedure Name
                        cmd = new SqlCommand(query, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usename", untextBox1.Text);
                        cmd.Parameters.AddWithValue("@word", pwtextBox2.Text);
                        int usercount = (Int32)cmd.ExecuteScalar();
                        if (usercount == 1)  //if user credential is matched then Usercount value is 1 otherwise it is 0
                        {
                            this.Hide(); //hiding form 1
                            Home M1 = new Home();//ing user Name to Second form so we can user Logged user Name
                            M1.Show();
                        }
                        else
                        {



                            MessageBox.Show("UserName or Password is Wrong"); //if user Name is not available in database

                        }
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Login Failed");

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Login Failed");

            }
        }
    }
}
