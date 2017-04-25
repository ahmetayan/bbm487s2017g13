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
    public partial class UpdateProfile : Form
    {
        private int id;

        public UpdateProfile()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        public UpdateProfile(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
            InitializeComponent();
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from [Users] where UserName ='" + tboxUserName.Text + "'", conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (count != 0)
                {
                    SqlCommand update = new SqlCommand("update [Users] set UserName=@p1,UserPassword=@p2,RealName=@p3,eMail=@p4,phoneNumber=@p5,address=@p6,job=@p7 where userID= '" + id + "'", conn);
                    update.Parameters.AddWithValue("@p1", tboxUserName.Text);
                    update.Parameters.AddWithValue("@p2", tboxPassword.Text);
                    update.Parameters.AddWithValue("@p3", tboxRealName.Text);
                    update.Parameters.AddWithValue("@p4", tboxMail.Text);
                    update.Parameters.AddWithValue("@p5", tboxPhone.Text);
                    update.Parameters.AddWithValue("@p6", tboxAddress.Text);
                    update.Parameters.AddWithValue("@p7", tboxJob.Text);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Your Profile Updated Successfully !");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("This Username Already Taken!");
                    conn.Close();
                }
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select userName,userPassword,realName,eMail,phoneNumber,address,job from [Users] where userID ='" + id + "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //  int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            String name = ds.Tables[0].Rows[0][0].ToString();
            String pass = ds.Tables[0].Rows[0][1].ToString();
            String rname = ds.Tables[0].Rows[0][2].ToString();
            String eMail = ds.Tables[0].Rows[0][3].ToString();
            String phone = ds.Tables[0].Rows[0][4].ToString();
            String address = ds.Tables[0].Rows[0][5].ToString();
            String job = ds.Tables[0].Rows[0][6].ToString();

            tboxAddress.Text = address;
            tboxJob.Text = job;
            tboxMail.Text = eMail;
            tboxPassword.Text = pass;
            tboxPhone.Text = phone;
            tboxRealName.Text = rname;
            tboxUserName.Text = name;
            conn.Close();
        }
    }
}
