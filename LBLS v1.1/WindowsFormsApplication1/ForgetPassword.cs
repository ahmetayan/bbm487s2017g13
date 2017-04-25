using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlDataAdapter loginControl = new SqlDataAdapter("Select count(*) from [Users] where eMail ='" + tboxEmail.Text + "'" , conn);
            DataSet dsLogin = new DataSet();
            loginControl.Fill(dsLogin);
            int control = Convert.ToInt32(dsLogin.Tables[0].Rows[0][0]);
            if (control != 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select UserPassword from [Users] where eMail ='" + tboxEmail.Text + "'", conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                String password = ds.Tables[0].Rows[0][0].ToString();
                lblResult.Text = password;
                conn.Close();
            }
            else
            {
                MessageBox.Show("No matches found for this email address");
            }
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
