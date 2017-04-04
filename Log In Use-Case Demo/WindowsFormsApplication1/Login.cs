using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string userName = "user";
        string password = "user";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tBoxUserName.Text == userName && tBoxPassword.Text == password)
            {
                if (rbtnAdmin.Checked == true)
                {
                   // MessageBox.Show("Login as Admin is Successful!");
                    AdminMain f2 = new AdminMain();
                    this.Hide();
                    f2.Show(); // Shows Form2
                    

                }
                else if (rbtnLibrarian.Checked == true)
                {
                    LibrarianMain f3 = new LibrarianMain();
                    this.Hide();
                    f3.Show(); // Shows Form3
                    MessageBox.Show("Login as Librarian is Successful!");
                }
                else if (rbtnUser.Checked == true)
                {
                    UserMain f4 = new UserMain();
                    this.Hide();
                    f4.Show(); // Shows Form4
                    MessageBox.Show("Login as User is Successful!");
                }
                else
                    MessageBox.Show("Please choose one login option!");
            }
            else
                MessageBox.Show("User name and Password doesn't match, Try Again!");


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function will be available soon!");
        }
    }
}
