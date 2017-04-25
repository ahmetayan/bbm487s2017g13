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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        public AdminMain(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        private int id;
        private void Form2_Load(object sender, EventArgs e)
        {
 
            SqlDataAdapter allUsers = new SqlDataAdapter("Select * from [Users]", conn);


            DataSet ds = new DataSet();
            allUsers.Fill(ds);
            dataGridViewUsers.DataSource = ds.Tables[0];
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Hide();
            f1.Show(); // Shows Form2
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Users]", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridViewUsers.DataSource = ds.Tables[0];
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (tboxAddress.TextLength < 300)
            {

                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from [Users] where UserName ='" + tboxUserName.Text + "'", conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (count == 0)
                {
                    SqlCommand insert = new SqlCommand("insert into Users (UserName,UserPassword,RealName,eMail,phoneNumber,address,job,role) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);
                    insert.Parameters.AddWithValue("@p1", tboxUserName.Text.ToString());
                    insert.Parameters.AddWithValue("@p2", tboxPassword.Text.ToString());
                    insert.Parameters.AddWithValue("@p3", tboxRealName.Text.ToString());
                    insert.Parameters.AddWithValue("@p4", tboxMail.Text.ToString());
                    insert.Parameters.AddWithValue("@p5", tboxPhone.Text.ToString());
                    insert.Parameters.AddWithValue("@p6", tboxAddress.Text.ToString());
                    insert.Parameters.AddWithValue("@p7", tboxJob.Text.ToString());
                    insert.Parameters.AddWithValue("@p8", comboxRole.Text.ToString());
                    insert.ExecuteNonQuery();
                    MessageBox.Show("A New User Successfully Added !");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("This Username Already Taken!");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Address value is too long");
                conn.Close();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("delete from Users where UserName=@p1 and UserPassword=@p2", conn);
            delete.Parameters.AddWithValue("@p1", tboxUserName.Text);
            delete.Parameters.AddWithValue("@p2", tboxPassword.Text);
            delete.ExecuteNonQuery();
            conn.Close();

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = dataGridViewUsers.SelectedCells[0].RowIndex;

            String name = dataGridViewUsers.Rows[item].Cells[1].Value.ToString();
            String pass = dataGridViewUsers.Rows[item].Cells[2].Value.ToString();
            String rname = dataGridViewUsers.Rows[item].Cells[3].Value.ToString();
            String eMail = dataGridViewUsers.Rows[item].Cells[4].Value.ToString();
            String phone = dataGridViewUsers.Rows[item].Cells[5].Value.ToString();
            String address = dataGridViewUsers.Rows[item].Cells[6].Value.ToString();
            String job = dataGridViewUsers.Rows[item].Cells[7].Value.ToString();
            String role = dataGridViewUsers.Rows[item].Cells[8].Value.ToString();

            tboxAddress.Text=address;
            tboxJob.Text = job;
            tboxMail.Text = eMail;
            tboxPassword.Text = pass;
            tboxPhone.Text = phone;
            tboxRealName.Text = rname;
            comboxRole.Text = role;
            tboxUserName.Text = name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("update [Users] set UserName=@p1,UserPassword=@p2,RealName=@p3,eMail=@p4,phoneNumber=@p5,address=@p6,job=@p7,role=@p8 where UserName=@p1 and UserPassword=@p2", conn);
            update.Parameters.AddWithValue("@p1", tboxUserName.Text);
            update.Parameters.AddWithValue("@p2", tboxPassword.Text);
            update.Parameters.AddWithValue("@p3", tboxRealName.Text);
            update.Parameters.AddWithValue("@p4", tboxMail.Text);
            update.Parameters.AddWithValue("@p5", tboxPhone.Text);
            update.Parameters.AddWithValue("@p6", tboxAddress.Text);
            update.Parameters.AddWithValue("@p7", tboxJob.Text);
            update.Parameters.AddWithValue("@p8", comboxRole.Text);
            update.ExecuteNonQuery();
            MessageBox.Show("User Updated Successfully !");
          //  btnShowUsers_Click(null, null);
            conn.Close();
        }
    }
}
