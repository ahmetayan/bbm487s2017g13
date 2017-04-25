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
    public partial class UserMain : Form
    {
        private int id;

        public UserMain()
        {
            InitializeComponent();
        }

        public UserMain(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
            InitializeComponent();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
   

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Hide();
            f1.Show(); // Shows Form2
        }


        private void UserMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile up = new UpdateProfile(id);
            up.Show();
        }



    }
}
