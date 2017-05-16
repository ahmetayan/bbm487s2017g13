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
            btnShowBooks_Click(null, null);
            tboxCost.Text =Convert.ToString(0);
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            this.Close();
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
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from [Books] where bookName ='" + tboxBookName.Text + "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (count == 0)
            {
                SqlCommand insert = new SqlCommand("insert into Books (bookName,description,authors,pageNumber,cost,stock) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn);
                insert.Parameters.AddWithValue("@p1", tboxBookName.Text.ToString());
                insert.Parameters.AddWithValue("@p2", tboxDescription.Text.ToString());
                insert.Parameters.AddWithValue("@p3", tboxAuthors.Text.ToString());
                insert.Parameters.AddWithValue("@p4", tboxPageNumber.Text.ToString());
                insert.Parameters.AddWithValue("@p5", tboxCost.Text.ToString());
                insert.Parameters.AddWithValue("@p6", tboxStock.Text.ToString());
                insert.ExecuteNonQuery();
                MessageBox.Show("A New Book Successfully Added !");
                conn.Close();
            }
            else
            {
                MessageBox.Show("This Book Already in Stock!");
                conn.Close();
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("update [Books] set bookName=@p1,description=@p2,authors=@p3,pageNumber=@p4,cost=@p5,stock=@p6 where bookName=@p1", conn);
            update.Parameters.AddWithValue("@p1", tboxBookName.Text.ToString());
            update.Parameters.AddWithValue("@p2", tboxDescription.Text.ToString());
            update.Parameters.AddWithValue("@p3", tboxAuthors.Text.ToString());
            update.Parameters.AddWithValue("@p4", tboxPageNumber.Text.ToString());
            update.Parameters.AddWithValue("@p5", tboxCost.Text.ToString());
            update.Parameters.AddWithValue("@p6", tboxStock.Text.ToString());
            update.ExecuteNonQuery();
            MessageBox.Show("Book Updated Successfully !");
            //  btnShowUsers_Click(null, null);
            conn.Close();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("delete from Books where bookName=@p1", conn);
            delete.Parameters.AddWithValue("@p1", tboxBookName.Text);
            delete.ExecuteNonQuery();
            MessageBox.Show("Book succesfully deleted!");
            conn.Close();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = dataGridViewBooks.SelectedCells[0].RowIndex;

            String name = dataGridViewBooks.Rows[item].Cells[1].Value.ToString();
            String desc = dataGridViewBooks.Rows[item].Cells[2].Value.ToString();
            String authors = dataGridViewBooks.Rows[item].Cells[3].Value.ToString();
            String pageNum = dataGridViewBooks.Rows[item].Cells[4].Value.ToString();
            String cost = dataGridViewBooks.Rows[item].Cells[5].Value.ToString();
            String stock = dataGridViewBooks.Rows[item].Cells[6].Value.ToString();


            tboxBookName.Text = name;
            tboxDescription.Text = desc;
            tboxAuthors.Text = authors;
            tboxPageNumber.Text = pageNum;
            tboxCost.Text = cost;
            tboxStock.Text = stock;

        }
    }
}
