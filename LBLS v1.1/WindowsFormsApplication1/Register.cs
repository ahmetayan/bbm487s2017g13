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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void uSERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.USER' table. You can move, or remove it, as needed.


        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");

        private void btnRegister_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from [Users] where UserName ='" + tboxUsername.Text + "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (count == 0)
            {
                SqlCommand insert = new SqlCommand("insert into Users (UserName,UserPassword,RealName,eMail,phoneNumber,address,job,role) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);
                insert.Parameters.AddWithValue("@p1", tboxUsername.Text);
                insert.Parameters.AddWithValue("@p2", tboxPass.Text);
                insert.Parameters.AddWithValue("@p3", tboxRealname.Text);
                insert.Parameters.AddWithValue("@p4", tboxMail.Text);
                insert.Parameters.AddWithValue("@p5", tboxPhone.Text);
                insert.Parameters.AddWithValue("@p6", tboxAddress.Text);
                insert.Parameters.AddWithValue("@p7", tboxJob.Text);
                insert.Parameters.AddWithValue("@p8", "user");
                insert.ExecuteNonQuery();
                MessageBox.Show("Successfull !");
                conn.Close();
                Login log = new Login();
                this.Hide();
                log.Show();
                conn.Close();
            }
            else
            {
                MessageBox.Show("This Username Already Taken !");
                conn.Close();
            }
        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Hide();
            f1.Show();
            conn.Close();
        }

    }
}
