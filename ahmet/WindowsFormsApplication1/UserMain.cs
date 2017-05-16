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
    public partial class UserMain : Form
    {
        private int id;
        private int book_id;
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
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");




        private void UserMain_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(id.ToString());
            SqlDataAdapter sda = new SqlDataAdapter("Select b.bookID,b.bookName,b.description,b.authors,b.pageNumber from Books b inner join Rent r on b.bookID=r.bookID inner join Users u on u.userID=r.userID where u.userID = " + id, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridViewuserBooks.DataSource = ds.Tables[0];
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile up = new UpdateProfile(id);
            up.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Close();
            f1.Show(); // Shows Form2
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            this.Close();
            LoanBook lb = new LoanBook(id);
            lb.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select r.rentDate,b.cost from Books b inner join Rent r on b.bookID=r.bookID inner join Users u on u.userID=r.userID where u.userID = " + id + " and b.bookID =" + book_id, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DateTime recDate = new DateTime();
            recDate = Convert.ToDateTime(ds.Tables[0].Rows[0][0]);
            double cost = Convert.ToDouble(ds.Tables[0].Rows[0][1]);
            DateTime retDate = new DateTime();
            retDate = Convert.ToDateTime(recDate.AddMonths(1));
            DateTime thisDay = DateTime.Today;
            if (thisDay >= retDate)
            {
                Payment paym = new Payment(this.id, book_id);
                this.Hide();
                paym.Show();
            }
            else
            {
                
                conn.Open();
                SqlCommand delete = new SqlCommand("delete from Rent where bookID=@p1", conn);
                delete.Parameters.AddWithValue("@p1", book_id);
                delete.ExecuteNonQuery();


                SqlDataAdapter stockControl = new SqlDataAdapter("Select stock from Books where bookID =" + book_id, conn);
                DataSet dsStock = new DataSet();
                stockControl.Fill(dsStock);
                int stock = Convert.ToInt32(dsStock.Tables[0].Rows[0][0]);



                SqlCommand update = new SqlCommand("update [Books] set stock=@p2 where bookID=@p1", conn);
                update.Parameters.AddWithValue("@p1", book_id);
                update.Parameters.AddWithValue("@p2", stock + 1);
                update.ExecuteNonQuery();
                MessageBox.Show("You have succesfully returned the book!");
                conn.Close();
                this.Close();
                UserMain um = new UserMain(id);
                um.Show();
            }
           
           // UserMain_Load(null, null);
           // MessageBox.Show(book_id.ToString());
        }

        private void dataGridViewuserBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = dataGridViewuserBooks.SelectedCells[0].RowIndex;
            this.book_id = Convert.ToInt32(dataGridViewuserBooks.Rows[item].Cells[0].Value);

        }

        private void btnInf_Click(object sender, EventArgs e)
        {
            Information inf = new Information(id, book_id);
            inf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
