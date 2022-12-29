using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace CRM_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\eeick\Documents\Data.mdf; Integrated Security = True; Connect Timeout = 30");
            //SqlDataAdapter sqlData = new SqlDataAdapter("Select Count(*) From Table where user_name'" + usernameBox.Text + "' and password = '" + passwordBox.Text + "'", conn);
            //DataTable dataTable = new DataTable();
            //sqlData.Fill(dataTable);

            if (usernameBox.Text == "Admin" && passwordBox.Text == "Admin")
            {
                this.Hide();
                mainSchedular mainSchedular = new mainSchedular();
                mainSchedular.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
            }
        }
    }
}
