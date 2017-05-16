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
    public partial class LoanBook : Form
    {
        private int id;
        private int book_id=-1;
        public LoanBook()
        {
            InitializeComponent();
        }
        public LoanBook(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=ASUS;Initial Catalog=FirstDB;Integrated Security=True");
        private void LoanBook_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Books", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridViewBooks.DataSource = ds.Tables[0];
        
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = dataGridViewBooks.SelectedCells[0].RowIndex;
            this.book_id = Convert.ToInt32(dataGridViewBooks.Rows[item].Cells[0].Value);
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

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (book_id == -1)
                return;
            conn.Open();
            SqlDataAdapter sdaStock = new SqlDataAdapter("Select stock from Books where bookID =" + book_id, conn);
            DataSet dsStock = new DataSet();
            sdaStock.Fill(dsStock);          
            int stockCount = Convert.ToInt32(dsStock.Tables[0].Rows[0][0]);

            if (stockCount >= 1)
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from [Rent] where bookID =" + book_id + " and userID =" + id, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (count == 0)
                {
                    SqlCommand insert = new SqlCommand("insert into Rent (userID,bookID) values (@p1,@p2)", conn);
                    insert.Parameters.AddWithValue("@p1", id);
                    insert.Parameters.AddWithValue("@p2", book_id);

                    insert.ExecuteNonQuery();


                    SqlCommand update = new SqlCommand("update [Books] set stock=@p2 where bookID=@p1", conn);
                    update.Parameters.AddWithValue("@p1", book_id);
                    update.Parameters.AddWithValue("@p2", Convert.ToInt32(tboxStock.Text) - 1);
                    update.ExecuteNonQuery();
                    //  btnShowUsers_Click(null, null);


                    MessageBox.Show("A New Book Successfully Added !");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("You already have this book!");
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("There is no book in stock!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserMain f1 = new UserMain(id);
            this.Close();
            f1.Show();
        }
    }
}
