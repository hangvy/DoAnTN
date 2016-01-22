using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Login : DevComponents.DotNetBar.OfficeForm
    {

        private string conn;
        private MySqlConnection connect;
        public Login()
        {
            InitializeComponent();
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=doantn;Uid=root;Pwd=root;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from account where loginname=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string username = reader.GetString("loginname");
                string password = reader.GetString("password");
                string role = reader.GetString("role");
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            string strPass=txtPass.Text.Trim();
            string strName=txtUsername.Text.Trim();
            if (strPass.Equals("") && strName.Equals(""))
            {
                MessageBox.Show("Enter username and password, please !");
            }
            if (validate_login(strName,strPass))
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

    }
}
