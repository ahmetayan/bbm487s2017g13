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
    public partial class LibrarianMain : Form
    {
        private int id;
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        public LibrarianMain()
        {
            InitializeComponent();
  
        }

        public LibrarianMain(int id)
        {
            // TODO: Complete member initialization
            this.id = id;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Hide();
            f1.Show(); // Shows Form2
        }


        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Books", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridViewBooks.DataSource = ds.Tables[0];
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

        }
    }
}
