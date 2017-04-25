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

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select userID, UserName, UserPassword, role from [Users] where UserName ='" + tBoxUserName.Text + "' and UserPassword= '" + tBoxPassword.Text + "'", conn);
            SqlDataAdapter loginControl = new SqlDataAdapter("Select count(*) from [Users] where UserName ='" + tBoxUserName.Text + "' and UserPassword= '" + tBoxPassword.Text + "'", conn);
            DataSet dsLogin = new DataSet();
            loginControl.Fill(dsLogin);
            int control = Convert.ToInt32(dsLogin.Tables[0].Rows[0][0]);
            if (control != 0)
            {
                DataSet ds = new DataSet();
                sda.Fill(ds);


                int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                String role = ds.Tables[0].Rows[0][3].ToString();
                

                if (role.Equals("user"))
                {
                    UserMain f1 = new UserMain(id);
                    this.Hide();
                    f1.Show(); // Shows Form2
                }

                else if (role.Equals("admin"))
                {


                    AdminMain f2 = new AdminMain(id);
                    this.Hide();
                    f2.Show(); // Shows Form2
                }
                else if (role.Equals("librarian"))
                {


                    LibrarianMain f3 = new LibrarianMain(id);
                    this.Hide();
                    f3.Show(); // Shows Form2
                }

            }
            else
            {
                MessageBox.Show("User name and Password doesn't match, Try Again!");
                btnForget.Visible = true;
                conn.Close();
            }
                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("This function will be available soon!");
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
        }

        }

    
       

       
   
    }


